using Bogus;
using Ecommerce.MVC.Helpers;
using Ecommerce.MVC.Models;
using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.ViewModels.AppUserViewModels;
using ECommerce.BLL.ViewModels.CreditCartViewModels;
using ECommerce.BLL.ViewModels.ProductViewModels;
using ECommerce.Common.CartHelpers;
using ECommerce.Common.EmailHelpers;
using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics;
using System.Web;

namespace Ecommerce.MVC.Controllers
{
  
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IProductService productService, IOrderService orderService, IOrderDetailService orderDetailService)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _productService = productService;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetActiveProducts()
               .OrderByDescending(x => x.CreatedDate)
               .Select(x => new ProductViewModel
               {
                   ProductId = x.ID,
                   ProductName = x.ProductName,
                   UnitPrice = x.UnitPrice,
                   UnitsInStock = x.UnitsInStock,
                   IsActive = x.IsActive,
                   Status = x.Status,
                   ImagePath = x.ImagePath,
                   CategoryId = x.CategoryId
               }).ToList();

            return View(products);

        }


        public IActionResult AddToCart(int id)
        {
            //parametredeki id'e ait veritabanında ürün var mı?
            var product=_productService.GetProductById(id);
            if (product != null)
            {
                Cart cartSession; //null

                CartItem cartItem = new CartItem
                {
                    Id = product.ID,
                    UnitPrice = product.UnitPrice,
                    ProductName = product.ProductName,

                };
                



                if (SessionHelper.GetProductFromJson<Cart>(HttpContext.Session,User.Identity.Name)==null)//Session içerisindeki boş mu?
                    //todo: _userManager.GetUserId(HttpContext.User) yerine giriş yapan kullanıcı'nın Id'sini tanımlayın.
                {
                    cartSession = new Cart();
                }
                else
                {
                    cartSession = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, User.Identity.Name);

                }
                cartSession.AddItem(cartItem);
                SessionHelper.SetJsonProduct(HttpContext.Session, User.Identity.Name, cartSession);

                if (_userManager.GetUserId(HttpContext.User) == null)
                {
                    TempData["Error"] = "Lütfen giriş yapınız";
                    return RedirectToAction("Index");
                }

                TempData["Success"] = "Sepete ürün eklendi!";
                TempData["CartCount"] = (SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, User.Identity.Name).MyCart.Count);


                return RedirectToAction("Index");

            }
            //var varolan ürünün bilgilerinin getirilmesi.
            //Session kontrolü.
            //Eğer session oluşturulmuşsa var olan session'un cart içerisine aktarılması.
            //Eğer session yoksa yeni bir cart ile birlikte session'ın oluşturulması.
            //Ürün bilgilerin cartItem'a taşınması
            //CartItem'in session içerisinde bulunan Cart>MyCart eklenmesi.
            else
            {
                return View();
            }

            
        }


        [Authorize]
        public IActionResult MyCart()
        {
          var sessionCart=  SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, User.Identity.Name);

            if (sessionCart != null)
            {
            return View(sessionCart);
            }
            return RedirectToAction("Index");
        }

        [Authorize]
        public async Task<IActionResult> CompleteCart()
        {



            return View();


          
        }

        [HttpPost]
        public async Task<IActionResult> CompleteCart(CreditCartViewModel creditCartViewModel)
        {

            //todo: parametreden gelen kredi kartı bilgilerinin kontrlü sağlanmıyor. Bu yüzden fake bir kontrol işlemi yazılabilinir.

            //Sipariş oluşturma işlemi

            if (ModelState.IsValid)
            {
                if (User.Identity.IsAuthenticated)
                {
                    Cart cart = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, User.Identity.Name);

                    if (cart != null)
                    {
                        Order order = new Order();
                        AppUser user = await _userManager.GetUserAsync(User);
                        order.User = user;
                        Random rnd = new Random();
                        order.OrderNumber = $"O-{rnd.Next(1, 100000)}";
                        order.Address = user.Address;

                        await _orderService.CreateOrder(order);

                        OrderDetail orderDetail = new OrderDetail();
                        foreach (var item in cart.MyCart)
                        {
                            Product product = _productService.GetProductById(item.Value.Id);
                            orderDetail.Product = product;
                            orderDetail.UnitPrice = item.Value.UnitPrice;
                            orderDetail.Quantity = Convert.ToInt16(item.Value.Quantity);
                            order.OrderDetails.Add(orderDetail);
                            _orderDetailService.CreateOrderDetail(orderDetail);
                        }

                        TempData["Success"] = $"{order.OrderNumber} numaralı siparişiniz alınmıştır. Kargoya verdiğimizde ayrıca bilgilendireceğiz.";

                        string htmlBody = $"<h1>Sipariş Alındı</h1> <br/> <h2>{order.OrderNumber}</h2> <br/> <p>Siparişiniz oluşturuldu. Tekrar bilgilendirme yapacağız</p>";

                       

                        //EmailSender
                        EmailSender.SendEmail(user.Email, $"{order.OrderNumber} Siparişiniz Alındı",htmlBody );
                        return RedirectToAction("Index");

                    }
                    else
                    {
                        return View();
                    }
                }

                return View();
            }
            else
            {
                return View("MyCart");
            }


           
        }



        //Kullanıcı Kayıt

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {

            if (ModelState.IsValid)
            {
                //AuotoMapper: 
                AppUser user = new AppUser
                {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.Username
                };

                var result = await _userManager.CreateAsync(user, registerViewModel.ConfirmPassword);

                if (result.Succeeded)
                {
                    var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    var encodeToken = HttpUtility.UrlEncode(emailToken);


                    string confirmationLink = Url.Action("Activation", "Home", new { id = user.Id, token = encodeToken }, Request.Scheme);

                    string body = $"Merhaba {registerViewModel.Username} kayıt olduğunuz için teşekkürler. Hesabını aktif hale getirebilmek için ilgili linki tıklayın. {confirmationLink}";

                    //todo: Konfirmasyon maili gönderilecek.
                    EmailSender.SendEmail(registerViewModel.Email, "Aktivasyon Maili", body);

                    TempData["Success"] = $"belirlemiş olduğunuz {registerViewModel.Email} adresine aktivasyon maili gönderildi. Lütfen ilgili linki tıklayarak üyeliğinizi aktif hale getirin.";

                }
                else
                {
                    TempData["Error"] = $"Bir hata meydana geldi";
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(registerViewModel);
            }

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {



                var user = await _userManager.FindByEmailAsync(loginViewModel.Email);

                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.Remember, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                   
                }

                return View();

            }
            else
            {
                return View(loginViewModel);
            }

        }

        public async Task<IActionResult> Signout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await _signInManager.SignOutAsync();
               
            }


            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Activation(string id, string token)
        {
            //kullanıcı konfirmasyon işlemi
            if (id != null && token != null)
            {
                var existsUser = await _userManager.FindByIdAsync(id);

                if (existsUser != null)
                {

                    var decodeToken = HttpUtility.UrlDecode(token);
                    /*
                     
CfDJ8IyhGRoZa+FJhssgP0zt4BN08sO+3/vgebmCRaj2ywsh9Lhe1w+fCwRO98bkQ0rT4DBzXGzGHv+wGZHcU2MbN10ZGY+b/5p64SUFv7S017cxVQxm2Mis9Tm05jY7+IxDpMyoHEya2oR1q+HKRjq1U7qV9yXQflIDC+M8rJ4A8aYbOgzg1MprZ4uT9fuLaH759J/rfXKnNjr5W+GXzJ4edbLvdY23NJvKraNGxC+FdaZzkoT8YScDG2Uu5cVqlfdPPQ==
                     */
                    var result = await _userManager.ConfirmEmailAsync(existsUser, decodeToken);
                    if (result.Succeeded)
                    {
                        TempData["Success"] = "hesabınız aktif hale getirildi.";
                        return RedirectToAction("Index");
                    }
                }
            }
            return View();
        }

        public IActionResult TestMail()
        {


            EmailSender.SendEmail("fatih.gunalp@gmail.com", "Test Maili", "bu bir test mailidir.");
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult Denied()
        {
            return View();
        }


        public IActionResult TestTable()
        {
            return View();
        }






        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
