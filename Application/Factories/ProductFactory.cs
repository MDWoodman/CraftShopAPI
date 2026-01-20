using CraftShopAPI.Domain.Entities;

namespace CraftShopAPI.Application.Factories
{
    public class ProductFactory : IProductFactory
    {
        public BaseProduct CreateProduct(CreateBaseProductDto createBaseProductDto)
        {
            createBaseProductDto.Type = createBaseProductDto.Type.ToLower();
            return createBaseProductDto.Type switch
            {
                "lamp" => new Lamp(),
                "chair" => new Chair(),
                "crystaldecor" => new CrystalDecor(),
                _ => throw new ArgumentException("Invalid product type")
            };
         }
    }
}
