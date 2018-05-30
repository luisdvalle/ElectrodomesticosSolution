namespace LuisDelValle.WinningSolution.Models
{
    public class Item
    {
        public virtual int Id { get; set; }
        public virtual string Sku { get; set; }
        public virtual string Name { get; set; }
        public virtual double Price { get; set; }
        public virtual Attribute Attribute { get; set; }

    }
}