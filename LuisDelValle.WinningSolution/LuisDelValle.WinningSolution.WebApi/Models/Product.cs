using LuisDelValle.WinningSolution.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace LuisDelValle.WinningSolution.WebApi.Models
{
    [BsonDiscriminator(Required = true, RootClass = true)]
    public class Product : Item
    {
        [BsonId]
        public override int Id { get; set; }
    }
}
