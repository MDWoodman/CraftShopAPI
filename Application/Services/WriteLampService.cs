using CraftShopAPI.Application.Builders;
using CraftShopAPI.Application.DTO;
using CraftShopAPI.Application.Services.Interface;
using CraftShopAPI.Domain.Entities;
using CraftShopAPI.Infrastructure;
using CraftShopAPI.Infrastructure.Repositories;

namespace CraftShopAPI.Application.Services
{
    public class WriteLampService : IWriteLampService
    {
        private readonly IWriteLampRepositories _writeLampRepositories;
        public WriteLampService(IWriteLampRepositories writeLampRepositories)
        {
            _writeLampRepositories = writeLampRepositories;
        }
        async public Task<int> CreateLampAsync(Lamp lamp )
        {
           

            var lampId =  await _writeLampRepositories.AddLamp(lamp);

            return lampId;
        }

      

        async public Task<int> DeleteLampAsync(int lampId)
        {
            await _writeLampRepositories.DeleteLamp(lampId);
            return lampId;
        }

      

       async  public Task<int> UpdateLampAsync(int lampId, Lamp lamp)
        {
            await _writeLampRepositories.UpdateLamp(lampId, lamp);

            return lampId;
          
        }
    }
}
