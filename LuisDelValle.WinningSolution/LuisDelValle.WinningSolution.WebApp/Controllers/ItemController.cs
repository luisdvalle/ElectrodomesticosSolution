using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuisDelValle.WinningSolution.Abstractions;
using LuisDelValle.WinningSolution.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuisDelValle.WinningSolution.WebApp.Controllers
{
    public class ItemController : Controller
    {
        private IRestClient<List<Item>> _restClient;

        public ItemController(IRestClient<List<Item>> restClient)
        {
            _restClient = restClient;
        }

        public async Task<IActionResult> All()
        {
            List<Item> items = await _restClient.GetResponseAsync() as List<Item>;

            return View(items);
        }
    }
}