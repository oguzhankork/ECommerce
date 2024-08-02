using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Repositories.Concretes;
using ECommerce.BLL.ViewModels.CategoryViewModels;
using ECommerce.BLL.ViewModels.ShipperViewModels;
using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class ShipperController : Controller
    {
        private readonly IShipperService _shipperService;

        public ShipperController(IShipperService shipperService)
        {
            _shipperService = shipperService;
        }
        public IActionResult Index()
        {
            var shippers = _shipperService.GetAllShippers().OrderByDescending(x => x.CreatedDate).Select(x => new ShipperViewModel
            {
                Id = x.ID,
                CompanyName = x.CompanyName,
                IsActive = x.IsActive,
                Status = x.Status
            }).ToList();
            return View(shippers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ShipperViewModel shipperViewModel)
        {

            if (ModelState.IsValid)
            {
                Shipper shipper = new Shipper
                {
                    CompanyName = shipperViewModel.CompanyName
                };

                string result = await _shipperService.CreateShipper(shipper);
                TempData["Result"] = result;
                return RedirectToAction("Index", "Home");

            }
            else
            {

                return View(shipperViewModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var updated = _shipperService.GetShipperById(id);

            if (updated!=null)
            {
                return View(updated);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(Shipper shipper)
        {
            if (!ModelState.IsValid)
            {
                return View(shipper);
            }

            string result = await _shipperService.UpdateShipperAsync(shipper);

            TempData["result"] = result;

            return RedirectToAction("Index", "Shipper");

        }
    }
}
