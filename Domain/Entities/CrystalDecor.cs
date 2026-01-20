namespace CraftShopAPI.Domain.Entities
{
    public class CrystalDecor : BaseProduct
    {

        public string CrystalType { get; set; }

        public string Color { get; set; }
        public string Shape { get; set; }
        public bool IsHandcrafted { get; set; }
        public string Name { get; set; }

        public int ProductId { get; set; }



    }
}
