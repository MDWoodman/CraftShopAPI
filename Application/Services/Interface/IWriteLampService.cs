using CraftShopAPI.Application.DTO;
using CraftShopAPI.Domain.Entities;

namespace CraftShopAPI.Application.Services.Interface
{
    public interface IWriteLampService
    {
        // Define methods for lamp-related operations
        Task<int> CreateLampAsync(Lamp lamp);
        Task<int> UpdateLampAsync(int lampId, Lamp lamp);
        Task<int> DeleteLampAsync(int lampId);
    }
}
