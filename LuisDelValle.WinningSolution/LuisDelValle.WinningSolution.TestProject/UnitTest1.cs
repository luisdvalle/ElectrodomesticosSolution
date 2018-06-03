using AutoFixture;
using LuisDelValle.WinningSolution.WebApi.Models;
using LuisDelValle.WinningSolution.WebApi.Services;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LuisDelValle.WinningSolution.TestProject
{
    public class UnitTest1
    {
        DataService<Product> dataService;

        public UnitTest1()
        {
            var fixture = new Fixture();
            var products = new List<Product>
            {
                fixture.Build<Product>()
                .With(p => p.Price, 500.50).Create(),
                fixture.Build<Product>()
                .With(p => p.Price, 250.50).Create(),
                fixture.Build<Product>()
                .With(p => p.Price, 250.50).Create(),
                fixture.Build<Product>()
                .With(p => p.Price, 300).Create()
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Product>>();
            dbSetMock.As<IQueryable<Product>>().Setup(m => m.Provider).Returns(products.Provider);
            dbSetMock.As<IQueryable<Product>>().Setup(m => m.Expression).Returns(products.Expression);
            dbSetMock.As<IQueryable<Product>>().Setup(m => m.ElementType).Returns(products.ElementType);
            dbSetMock.As<IQueryable<Product>>().Setup(m => m.GetEnumerator()).Returns(products.GetEnumerator());

            var appContextMock = new Mock<AppDbContext>();
            appContextMock.Setup(x => x.Items).Returns(dbSetMock.Object);

            dataService = new DataService<Product>(appContextMock.Object, dbSetMock.Object);
        }

        [Fact]
        public void Query_GetAllProductsWithMaxPrice__Returns1Product()
        {
            // Arrange

            // Act
            var maxPrice = dataService.GetAll().Max(p => p.Price);
            var allProductsMaxPrice = dataService.Query(p => p.Price == maxPrice);

            // Assert
            Assert.Single(allProductsMaxPrice);
            Assert.Equal(500.50, allProductsMaxPrice.First().Price);
        }

        [Fact]
        public void Query_GetAllProductsWithMinPrice__Returns2Product()
        {
            // Arrange

            // Act
            var minPrice = dataService.GetAll().Min(p => p.Price);
            var allProductsMinPrice = dataService.Query(p => p.Price == minPrice);

            // Assert
            Assert.Equal(2, allProductsMinPrice.Count());
            Assert.Equal(250.50, allProductsMinPrice.First().Price);
        }

        [Fact]
        public void Query_GetAllProductsWithPrice300__Returns1Product()
        {
            // Arrange

            // Act
            var allProductsMinPrice = dataService.Query(p => p.Price == 300);

            // Assert
            Assert.Single(allProductsMinPrice);
            Assert.Equal(300, allProductsMinPrice.First().Price);
        }
    }
}
