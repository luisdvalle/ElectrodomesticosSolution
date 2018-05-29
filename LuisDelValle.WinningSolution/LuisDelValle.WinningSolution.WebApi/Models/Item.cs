using LuisDelValle.WinningSolution.WebApi.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace LuisDelValle.WinningSolution.WebApi.Services
{
    [BsonDiscriminator(Required = true, RootClass = true)]
    public class Item
    {
        [BsonId]
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Attribute Attribute { get; set; }

    }
}