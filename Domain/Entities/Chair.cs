namespace CraftShopAPI.Domain.Entities
{
    public class Chair : BaseProduct
    {
        public string Material { get; set; }
        public string Color { get; set; }
        public bool HasCushion { get; set; }
        public int NumberOfLegs { get; set; }
        public string Style { get; set; }
        public string Name { get; set; }

        public int ProductId { get; set; }
    }
}
