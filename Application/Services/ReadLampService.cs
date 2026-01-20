using CraftShopAPI.Application.Services.Interface;
using CraftShopAPI.Domain.Entities;
using CraftShopAPI.Infrastructure.Repositories;

namespace CraftShopAPI.Application.Services
{
    public class ReadLampService : IReadLampService
    {
        private readonly IReadLampRepositories _readLampRepositories;
        public ReadLampService(IReadLampRepositories readLampRepositories)
        {
           _readLampRepositories = readLampRepositories;
        }
        async public Task<IEnumerable<Lamp>> GetAllLamps()
        {
            return await _readLampRepositories.GetAllLamps();
        }

        async public Task<Lamp> GetLampById(int lampId)
        {
           return await _readLampRepositories.GetLampById(lampId);
        }

        async public Task<Lamp> GetLampByNameLike(string name)
        {
            return await _readLampRepositories.GetLampByNameLike(name);
        }
    }
}
