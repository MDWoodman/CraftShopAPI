namespace CraftShopAPI.Infrastructure.Repositories
{
    public interface IReadLampRepositories
    {
        Task<Domain.Entities.Lamp?> GetLampById(int lampId);
        Task<IEnumerable<Domain.Entities.Lamp>> GetAllLamps();
        Task<Domain.Entities.Lamp?> GetLampByNameLike(string name);
    }
}
