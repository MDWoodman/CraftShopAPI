namespace CraftShopAPI.Application.Services.Interface
{
    public interface IWriteChairService
    {
        // Define methods for chair-related operations
        Task<int> CreateChairAsync(DTO.CreateChairDTO createChairDTO);
        int UpdateChair(int chairId, DTO.CreateChairDTO updateChairDTO);
        int DeleteChair(int chairId);
    }
}
