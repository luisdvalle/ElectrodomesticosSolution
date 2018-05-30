using LuisDelValle.WinningSolution.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace LuisDelValle.WinningSolution.WebApi.Models
{
    [BsonDiscriminator(Required = true, RootClass = true)]
    public class Product
    {
        [BsonId]
        public int Id { get; set; }
        public string sku { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public Attribute attribute { get; set; }
    }
}
