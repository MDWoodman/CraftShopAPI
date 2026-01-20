using CraftShopAPI.Application.Factories;

namespace CraftShopAPI.Application.DTO
{
    public class CreateLampDTO : CreateBaseProductDto
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public bool HasDimmer { get; set; }
        public string BulbType { get; set; }
        public string ShadeShape { get; set; }
        public string Type { get; set; }
    }
}
