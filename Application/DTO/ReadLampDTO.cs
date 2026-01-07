namespace CraftShopAPI.Application.DTO
{
    public class ReadLampDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public bool HasDimmer { get; set; }
        public string BulbType { get; set; }
        public string ShadeShape { get; set; }
    }
}
