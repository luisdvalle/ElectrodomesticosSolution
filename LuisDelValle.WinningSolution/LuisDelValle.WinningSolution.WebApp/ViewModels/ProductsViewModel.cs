using LuisDelValle.WinningSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuisDelValle.WinningSolution.WebApp.ViewModels
{
    public class ProductsViewModel
    {
        public string Message { get; set; }
        public int NumberProducts { get; set; }
        public List<Item> Products { get; set; }
    }
}
