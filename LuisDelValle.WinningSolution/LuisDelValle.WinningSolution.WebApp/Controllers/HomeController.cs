using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuisDelValle.WinningSolution.Abstractions;
using LuisDelValle.WinningSolution.Models;
using LuisDelValle.WinningSolution.WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LuisDelValle.WinningSolution.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IRestClient<IEnumerable<Item>> _restClient;

        public HomeController(IRestClient<IEnumerable<Item>> restClient)
        {
            _restClient = restClient;
            _restClient.Host = "http://localhost:56346/";
        }
        public IActionResult Index(ProductsViewModel vm)
        {
            if (vm.Message == null)
            {
                vm.Message = "";
                vm.Products = new List<Item>();
                vm.NumberProducts = 0;
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> All()
        {
            _restClient.Path = "api/product";
            List<Item> items = await _restClient.GetResponseAsync() as List<Item>;

            // mapping to vm.
            ProductsViewModel vm = new ProductsViewModel
            {
                Message = "All products in inventory",
                NumberProducts = items.Count(),
                Products = new List<Item>()
            };

            foreach (var item in items)
            {
                vm.Products.Add(item);
            }

            return RedirectToAction("Index", "Home", vm);
        }
    }
}