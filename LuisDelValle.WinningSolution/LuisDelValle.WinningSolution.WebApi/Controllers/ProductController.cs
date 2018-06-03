using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuisDelValle.WinningSolution.Abstractions;
using LuisDelValle.WinningSolution.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LuisDelValle.WinningSolution.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IDataService<Product> _dataService;

        public ProductController(IDataService<Product> dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _dataService.GetAll();
        }

        [HttpGet]
        [Route("minimumprice")]
        public IEnumerable<Product> GetMinPrice()
        {
            var minPriceValue = _dataService.GetAll().Min(p => p.Price);

            return _dataService.Query(p => p.Price == minPriceValue);
        }

        [HttpGet]
        [Route("maximumprice")]
        public IEnumerable<Product> GetMaxPrice()
        {
            var maxPriceValue = _dataService.GetAll().Max(p => p.Price);

            return _dataService.Query(p => p.Price == maxPriceValue);
        }

        [HttpGet]
        [Route("filterprice/{price}")]
        public IEnumerable<Product> GetFilterPrice(double price)
        {
            return _dataService.Query(p => p.Price == price);
        }

        [HttpGet]
        [Route("fantastic/{value}")]
        public IEnumerable<Product> GetFantasticFilter(bool value)
        {
            return _dataService.Query(p => p.Attribute.fantastic.value == value);
        }

        [HttpGet]
        [Route("rating/maximumvalue")]
        public IEnumerable<Product> GetMaximumRatingValue()
        {
            var maxRatingValue = _dataService.GetAll().Max(p => p.Attribute.rating.value);

            return _dataService.Query(p => p.Attribute.rating.value == maxRatingValue);
        }

        [HttpGet]
        [Route("rating/minimumvalue")]
        public IEnumerable<Product> GetMinimumRatingValue()
        {
            var minRatingValue = _dataService.GetAll().Min(p => p.Attribute.rating.value);

            return _dataService.Query(p => p.Attribute.rating.value == minRatingValue);
        }

        [HttpGet]
        [Route("filterratingvalue/{value}")]
        public IEnumerable<Product> GetFilterRating(double value)
        {
            return _dataService.Query(p => p.Attribute.rating.value == value);
        }
    }
}