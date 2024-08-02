using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.ViewModels.CategoryViewModels;
using ECommerce.BLL.ViewModels.ProductViewModels;
using ECommerce.Common.ImageHelpers;
using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {

            var products = _productService.GetAllProducts().Select(x => new ProductViewModel
            {
                ProductId = x.ID,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                CategoryId = x.CategoryId,
                Status = x.Status,
                ImagePath = x.ImagePath,
            }).ToList();

            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.CategoryListItem = _categoryService.GetAllCategories().Select(x => new CategoryViewModel
            {
                CategoryName = x.CategoryName,
                Description = x.Description,
                Id = x.ID,
            }).Select(s=>new SelectListItem
            {
                Text=s.CategoryName,
                Value=s.Id.ToString()
            });
           
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel productViewModel, IFormFile productImage)
        {
            if (ModelState.IsValid)
            {

               var ImageEditResult= ImageHelper.Upload(productImage.FileName);

                if (ImageEditResult == "0")
                {
                    TempData["Error"] = "Görsel izin verilen formatta değil";
                    return View();
                }
                else
                {
                   var path= Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", ImageEditResult);
                    using (var stream=new FileStream(path, FileMode.Create))
                    {
                        productImage.CopyToAsync(stream);
                    }


                        Product product = new Product
                        {
                            ID = productViewModel.ProductId,
                            ProductName = productViewModel.ProductName,
                            UnitPrice = productViewModel.UnitPrice,
                            UnitsInStock = productViewModel.UnitsInStock,
                            CategoryId = productViewModel.CategoryId,
                            Status = productViewModel.Status,
                            ImagePath=ImageEditResult
                        };

                    var result = await _productService.CreateProductAsync(product);

                    return RedirectToAction("Index", "Home");
                }

                
            }
            else
            {
                return View(productViewModel);
            }
        
        }
    }
}
