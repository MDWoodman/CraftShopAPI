using CraftShopAPI.Application.DTO;

namespace CraftShopAPI.Application.Services.Interface
{
    public interface ICreateLampService
    {
        // Define methods for lamp-related operations
        int CreateLamp(CreateLampDTO createLampDTO);
    }
}
