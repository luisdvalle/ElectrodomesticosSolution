using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuisDelValle.WinningSolution.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace LuisDelValle.WinningSolution.WebApp.Controllers
{
    public class DataController : Controller
    {
        private IDataService<Item> _dataService;

        public DataController(IDataService<Item> dataService)
        {
            _dataService = dataService;
        }

        public IActionResult All()
        {
            List<Item> item = _dataService.GetAll().ToList();

            return View(item);
        }
    }
}