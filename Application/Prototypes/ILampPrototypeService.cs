using CraftShopAPI.Domain.Entities;

namespace CraftShopAPI.Application.Prototypes
{
    public interface ILampPrototypeService
    {
        public Task<int> CloneLampAsync(int lampId);
       
    }
}
