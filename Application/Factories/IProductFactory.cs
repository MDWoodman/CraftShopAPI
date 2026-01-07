using CraftShopAPI.Domain.Entities;

namespace CraftShopAPI.Application.Factories
{
    public interface IProductFactory
    {
        BaseProduct CreateProduct(CreateBaseProductDto createBaseProductDto);
    }
}
