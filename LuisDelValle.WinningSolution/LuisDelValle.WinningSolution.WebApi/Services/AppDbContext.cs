using Blueshift.EntityFrameworkCore.MongoDB.Annotations;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace LuisDelValle.WinningSolution.WebApi.Services
{
    [MongoDatabase("appdb")]
    public class AppDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public AppDbContext()
            : this(new DbContextOptions<AppDbContext>())
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> appDbContextOptions)
            : base(appDbContextOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = "mongodb://localhost";
            var mongoUrl = new MongoUrl(connectionString);

            MongoClientSettings settings = MongoClientSettings.FromUrl(mongoUrl);

            MongoClient mongoClient = new MongoClient(settings);
            options.UseMongoDb(mongoClient);
        }
    }
}
