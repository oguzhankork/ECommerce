using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.ViewModels.SupplierViewModels;
using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class SupplierController : Controller
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        //Supplier Home (List All Suppliers)
        public IActionResult Index()
        {
            var suppliers = _supplierService.GetAllSuppliers()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new SupplierViewModelAdmin
                {
                    SupplierId = x.ID,
                    CompanyName = x.CompanyName,
                    Address = x.Address,
                    ContactName = x.ContactName,
                    PhoneNumber = x.PhoneNumber,
                    IsActive = x.IsActive,
                    Status = x.Status,
                }).ToList();
            return View(suppliers);
        }


        //Get: Create Supplier
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Post: Create Supplier
        [HttpPost]
        public async Task<IActionResult> Create(SupplierViewModelUser supplierVM)
        {
            if (ModelState.IsValid)
            {
                Supplier supplier = new Supplier()
                {
                    CompanyName = supplierVM.CompanyName,
                    ContactName = supplierVM.ContactName,
                    Address = supplierVM.Address,
                    PhoneNumber = supplierVM.PhoneNumber
                };
                string result = await _supplierService.AddSupplierAsync(supplier);
                TempData["Result"] = result;

                return RedirectToAction("Index", "Supplier");
            }
            else
            {
                return View(supplierVM);
            }
        }

        //Get: Update Supplier
        [HttpGet]
        public IActionResult Update(int id)
        {
            var updated = _supplierService.GetSupplierById(id);


            if (updated != null)
            {
                return View(updated);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        //Post: Update Supplier
        [HttpPost]
        public async Task<IActionResult> Update(Supplier supplier)
        {
            if (!ModelState.IsValid)
            {
                return View(supplier);
            }

            string result = await _supplierService.UpdateSupplierAsync(supplier);

            TempData["result"] = result;

            return RedirectToAction("Index", "Supplier");

        }

        //List Active Suppliers
        public IActionResult Active()
        {
            var suppliers = _supplierService.GetActiveSuppliers()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new SupplierViewModelAdmin
                {
                    SupplierId = x.ID,
                    CompanyName = x.CompanyName,
                    Address = x.Address,
                    ContactName = x.ContactName,
                    PhoneNumber = x.PhoneNumber,
                    IsActive = x.IsActive,
                    Status = x.Status,
                }).ToList();
            return View(suppliers);
        }

        //List Passive Suppliers
        public IActionResult Passive()
        {
            var suppliers = _supplierService.GetPassiveSuppliers()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new SupplierViewModelAdmin
                {
                    SupplierId = x.ID,
                    CompanyName = x.CompanyName,
                    Address = x.Address,
                    ContactName = x.ContactName,
                    PhoneNumber = x.PhoneNumber,
                    IsActive = x.IsActive,
                    Status = x.Status,
                }).ToList();
            return View(suppliers);
        }

        //Get: Delete data from database (Destroy Data)
        [HttpGet]
        public IActionResult Destroy(int id)
        {
            var deleted = _supplierService.GetSupplierById(id);

            if (deleted != null)
            {
                return View(deleted);
            }

            return RedirectToAction("Index", "Home");
        }

        //Post: Delete data from database (Destroy Data)
        [HttpPost]
        public async Task<IActionResult> Destroy(Supplier supplier)
        {
            if (supplier != null)
            {
                string result = await _supplierService.DestroySupplierAsync(supplier);

                TempData["Result"] = result;

                return RedirectToAction("Index", "Supplier");
            }

            return View(supplier);
        }
    }
}
