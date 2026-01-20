namespace CraftShopAPI.Application.Services.Interface
{
    public interface IReadLampService
    {
        // Define methods for reading lamp-related data
        Task<Domain.Entities.Lamp> GetLampById(int lampId);
        Task<IEnumerable<Domain.Entities.Lamp>> GetAllLamps();
        Task<Domain.Entities.Lamp> GetLampByNameLike(string name);

    }
}
