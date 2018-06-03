using LuisDelValle.WinningSolution.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace LuisDelValle.WinningSolution.WebApi.Models
{
    [BsonDiscriminator(Required = true, RootClass = true)]
    public class Product
    {
        [BsonId]
        public int Id { get; set; }
        [BsonElement("sku")]
        public string Sku { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("price")]
        public double Price { get; set; }
        [BsonElement("Attribute")]
        public Attribute Attribute { get; set; }
    }
}
