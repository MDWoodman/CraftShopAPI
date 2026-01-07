namespace CraftShopAPI.Application.Factories
{
    public class CreateBaseProductDto
    {
      
        public string Type { get; set; }
        public string Name { get; internal set; }
        public string Material { get; internal set; }
        public string Color { get; internal set; }
    }
}