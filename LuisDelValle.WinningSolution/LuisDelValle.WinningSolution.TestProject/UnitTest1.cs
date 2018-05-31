using LuisDelValle.WinningSolution.Abstractions;
using LuisDelValle.WinningSolution.WebApi.Models;
using LuisDelValle.WinningSolution.WebApi.Services;
using Microsoft.EntityFrameworkCore;
using Mongo2Go;
using MongoDB.Driver;
using Moq;
using System;
using Xunit;

namespace LuisDelValle.WinningSolution.TestProject
{
    //public class DatabaseFixture
    //{
    //    private AppDbContext _dbContext;
    //    public DatabaseFixture()
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
    //        optionsBuilder.UseInMemoryDatabase("TestDb");
    //        _dbContext = new AppDbContext(optionsBuilder.Options);

    //        // Adding sample data
    //        _dbContext.Items.Add(new Product
    //        {
    //            Id = 1, name = "Test Name", price = 50.1, sku = "Sku Test",
    //            attribute = new Models.Attribute
    //            {
    //                fantastic = new Models.Fantastic { name = "Test Name", type = 1, value = true },
    //                rating = new Models.Rating { name = "Test Name", type = "1", value = 1.5 }
    //            }
    //        });

    //        _dbContext.Items.Add(new Product
    //        {
    //            Id = 1, name = "Test Name", price = 100.1, sku = "Sku Test",
    //            attribute = new Models.Attribute
    //            {
    //                fantastic = new Models.Fantastic { name = "Test Name", type = 1, value = false },
    //                rating = new Models.Rating { name = "Test Name", type = "1", value = 2.5 }
    //            }
    //        });

    //        _dbContext.Items.Add(new Product
    //        {
    //            Id = 1, name = "Test Name", price = 200.1, sku = "Sku Test",
    //            attribute = new Models.Attribute
    //            {
    //                fantastic = new Models.Fantastic { name = "Test Name", type = 1, value = true },
    //                rating = new Models.Rating { name = "Test Name", type = "1", value = 3.5 }
    //            }
    //        });
    //    }
    //}
        
    public class UnitTest1 //: IClassFixture<DatabaseFixture>
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            //var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            //optionsBuilder.UseInMemoryDatabase("testdb").UseMongoDb(;

            // Act

            // Assert
        }
    }
}
