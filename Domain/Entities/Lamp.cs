namespace CraftShopAPI.Domain.Entities
{
    public class Lamp : BaseProduct
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public bool HasDimmer { get; set; }
        public string BulbType { get; set; }
        public string ShadeShape { get; set; }

    }
}
