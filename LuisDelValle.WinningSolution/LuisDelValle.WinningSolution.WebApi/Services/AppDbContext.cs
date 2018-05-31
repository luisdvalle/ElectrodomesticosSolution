using Blueshift.EntityFrameworkCore.MongoDB.Annotations;
using LuisDelValle.WinningSolution.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace LuisDelValle.WinningSolution.WebApi.Services
{
    [MongoDatabase("appdb")]
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Items { get; set; }

        public AppDbContext()
            : this(new DbContextOptions<AppDbContext>())
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> appDbContextOptions)
            : base(appDbContextOptions)
        {
        }
    }
}
