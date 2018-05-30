using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuisDelValle.WinningSolution.Abstractions;
using LuisDelValle.WinningSolution.Models;
using LuisDelValle.WinningSolution.WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LuisDelValle.WinningSolution.WebApp.Controllers
{
    public class ItemController : Controller
    {
        private IRestClient<IEnumerable<Item>> _restClient;

        public ItemController(IRestClient<IEnumerable<Item>> restClient)
        {
            _restClient = restClient;
            _restClient.Host = "http://localhost:56346/";
        }

        [HttpPost]
        public async Task<IActionResult> GetAll()
        {
            _restClient.Path = "api/product";
            List<Item> items = await _restClient.GetResponseAsync() as List<Item>;

            // mapping to vm.
            ProductsViewModel vm = new ProductsViewModel
            {
                Message = "All products in inventory",
                NumberProducts = items.Count(),
                Products = items
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> GetMinPrice()
        {
            _restClient.Path = "api/product/minimumprice";
            List<Item> items = await _restClient.GetResponseAsync() as List<Item>;

            // mapping to vm.
            ProductsViewModel vm = new ProductsViewModel
            {
                Message = "All products with the minimum price",
                NumberProducts = items.Count(),
                Products = items
            };

            return View(vm);
        }
    }
}