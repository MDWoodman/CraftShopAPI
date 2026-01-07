namespace CraftShopAPI.Infrastructure.Repositories
{
    public interface IWriteLampRepositories
    {
        Task<int> AddLamp(Domain.Entities.Lamp lamp);
        Task<int> DeleteLamp(int lampId);
        Task<int> UpdateLamp(int lampId, Domain.Entities.Lamp updatedLamp);
    }
}
