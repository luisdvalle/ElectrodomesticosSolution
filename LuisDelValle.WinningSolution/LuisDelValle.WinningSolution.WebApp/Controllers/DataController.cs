using System.Collections.Generic;
using System.Linq;
using LuisDelValle.WinningSolution.Abstractions;
using LuisDelValle.WinningSolution.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuisDelValle.WinningSolution.WebApp.Controllers
{
    public class DataController : Controller
    {
        private IDataService<Product> _dataService;

        public DataController(IDataService<Product> dataService)
        {
            _dataService = dataService;
        }

        public IActionResult All()
        {
            List<Product> products = _dataService.GetAll().ToList();

            return View(products);
        }
    }
}