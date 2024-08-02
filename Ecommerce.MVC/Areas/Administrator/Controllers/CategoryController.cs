using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.ViewModels.CategoryViewModels;
using ECommerce.BLL.ViewModels.ProductViewModels;
using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    //[Authorize(Roles = "Admin")]

    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public CategoryController(ICategoryService categoryService,IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public IActionResult Index()
        {
            var categories = _categoryService
                .GetAllCategories()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new CategoryListViewModel
                {
                    Id = x.ID,
                    CategoryName = x.CategoryName,
                    Description = x.Description,
                    IsActive = x.IsActive,
                    Status = x.Status
                }).ToList();
            return View(categories);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel categoryViewModel)
        {

            if (ModelState.IsValid)
            {
                Category category = new Category
                {
                    CategoryName = categoryViewModel.CategoryName,
                    Description = categoryViewModel.Description,
                };

             string result=await _categoryService.CreateCategory(category);
                TempData["Result"] = result;
                return RedirectToAction("Index", "Home");

            }
            else
            {
           
                return View(categoryViewModel);
            }
        }

        public IActionResult Update(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            CategoryListViewModel categoryListViewModel = new CategoryListViewModel
            {
                CategoryName = category.CategoryName,
                Description = category.Description,
                IsActive = category.IsActive,
                Status = category.Status
            };
            if (categoryListViewModel != null)
            {
                return View(categoryListViewModel);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryListViewModel category)
        {
            if (ModelState.IsValid)
            {
                Category updated = new Category
                {
                    ID = category.Id,
                    CategoryName = category.CategoryName,
                    Description = category.Description,
                    IsActive = category.IsActive,
                    Status = category.Status
                };

              var result=await  _categoryService.UpdateCategory(updated);
                TempData["Result"] = result;
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }
           
        }

        public IActionResult Details(int id)
        {
            var products = _productService.GetProductByCategoryId(id);

            if (products.Count > 0)
            {
                var productsMV = products.Select(x => new ProductViewModel()
                {
                    ProductId = x.ID,
                    ProductName = x.ProductName,
                    UnitPrice = x.UnitPrice,
                    UnitsInStock = x.UnitsInStock,
                    ImagePath = x.ImagePath,
                    Status = x.Status,
                    IsActive = x.IsActive
                }).ToList();

                return View(productsMV);
            }

            return RedirectToAction("Index", "Home");
        }

        ///List Active Categories
        public IActionResult Active()
        {
            var categories = _categoryService
                .GetActiveCategories()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new CategoryListViewModel
                {
                    Id = x.ID,
                    CategoryName = x.CategoryName,
                    Description = x.Description,
                    IsActive = x.IsActive,
                    Status = x.Status
                }).ToList();
            return View(categories);
        }

        ///List Passive Categories
        public IActionResult Passive()
        {
            var categories = _categoryService
                .GetPassiveCategories()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new CategoryListViewModel
                {
                    Id = x.ID,
                    CategoryName = x.CategoryName,
                    Description = x.Description,
                    IsActive = x.IsActive,
                    Status = x.Status
                }).ToList();
            return View(categories);
        }

        /// <summary>
        /// Delete data from database
        /// </summary>
        [HttpGet]
        public IActionResult Destroy(int id)
        {
            var deleted = _categoryService.GetCategoryById(id);

            if (deleted != null)
            {
                return View(deleted);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Destroy(Category category)
        {
            if (category != null)
            {
                string result = await _categoryService.DestroCategory(category);

                TempData["Result"] = result;

                return RedirectToAction("Index", "Category");
            }

            return View(category);
        }


    }
}
