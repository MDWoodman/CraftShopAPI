using CraftShopAPI.Domain.Entities;
using CraftShopAPI.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Query;

namespace CraftShopAPI.Application.Prototypes
{
    public class LampPrototypeService : ILampPrototypeService
    {

        IWriteLampRepositories _writeLampRepositories;
        IReadLampRepositories _readLampRepositories;
        public LampPrototypeService(IWriteLampRepositories writeLampRepositories , IReadLampRepositories readLampRepositories) 
        {
            _writeLampRepositories = writeLampRepositories;
            _readLampRepositories = readLampRepositories;
        }
       
        async public Task<int> CloneLampAsync(int lampId)
        {
            var lamp = await _readLampRepositories.GetLampById(lampId);

            var clonedLamp = lamp.Clone();
           
            int newLampId = await _writeLampRepositories.AddLamp(clonedLamp);
            return newLampId;
            
        }
    }
}