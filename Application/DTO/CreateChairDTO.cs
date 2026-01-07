using CraftShopAPI.Application.Factories;

namespace CraftShopAPI.Application.DTO
{
    public class CreateChairDTO : CreateBaseProductDto
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public bool HasCushion { get; set; }
        public string Style { get; set; }
        public int NumberOfLegs { get; set; }
    }
}
