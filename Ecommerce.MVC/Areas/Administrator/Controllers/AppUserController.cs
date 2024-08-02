using ECommerce.BLL.ViewModels.AppUserViewModels;
using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppUserRole> _roleManager;

        public AppUserController(UserManager<AppUser> userManager, RoleManager<AppUserRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
          
            var users = _userManager.Users.Select(x => new AppUserListViewModel
            {
                ID = x.Id.ToString(),
                Gender = x.Gender,
                BirthDate = x.BirthDate,
                EmailConfirmed = x.EmailConfirmed,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                Username = x.UserName,
                Address = x.Address
            }).ToList();
            return View(users);
        }


        public IActionResult Details(string id)
        {
            //kullanıcı detayı tek bir sayfada gösterilecek.
            return View();
        }


        public async Task<IActionResult> AddToRole(string id, string roleName) 
        { 
            
            var user=await _userManager.FindByIdAsync(id);
            if (user!=null)
            {
                _userManager.AddToRoleAsync(user,roleName);
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }

           
           
        }

        public IActionResult ForgotPassword(int id)
        {
            return View();  
        }

        public async Task<IActionResult> Update(string id)
        {

            AppUser user=await _userManager.FindByIdAsync(id);
            
            if (user != null)
            {

                AppUserListViewModel appUserListView = new AppUserListViewModel
                {
                    ID = user.Id.ToString(),
                    Username = user.UserName,
                    BirthDate = user.BirthDate,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    EmailConfirmed = user.EmailConfirmed,
                    Address = user.Address

                };
                return View(appUserListView);
            }
            else
            {
                return RedirectToAction("Index");
            }

            
        }

        [HttpPost]
        public async Task<IActionResult> Update(AppUserListViewModel updated)
        {
            AppUser user = new AppUser
            {
                Id = Guid.Parse(updated.ID),
                UserName = updated.Username,
                BirthDate = updated.BirthDate,
                Gender = updated.Gender,
                Email = updated.Email,
                Address = updated.Address,
                PhoneNumber = updated.PhoneNumber,
                EmailConfirmed = updated.EmailConfirmed,
            };

            //todo: Update metodu içerisinde rol güncelleme işlemi de dahil edilecek.

          var result=  await _userManager.UpdateAsync(user);

            return View();
        }

        public IActionResult DeleteUser(string id)
        {
            return View();
        }
    }
}
