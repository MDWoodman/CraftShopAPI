namespace CraftShopAPI.Infrastructure.Repositories
{
    public class WriteLampRepository : IWriteLampRepositories
    {
        CraftShopDbContext _context;
        public WriteLampRepository(CraftShopDbContext craftShopDbContext)
        {
            _context = craftShopDbContext;

        }

        async public Task<int> AddLamp(Domain.Entities.Lamp lamp)
        {

            await _context.Lamps.AddAsync(lamp);
            await _context.SaveChangesAsync();
            return lamp.ProductId;

        }

        async public Task<int> DeleteLamp(int lampId)
        {
            var lamp = await _context.Lamps.FindAsync(lampId);
            if (lamp != null)
            {
                _context.Lamps.Remove(lamp);
                await _context.SaveChangesAsync();
                return lampId;
            }
            return -1; // Indicate that the lamp was not found
        }
        async public Task<int> UpdateLamp(int lampId, Domain.Entities.Lamp updatedLamp)
        {
            var lamp = await _context.Lamps.FindAsync(lampId);
            if (lamp != null)
            {
                lamp.Name = updatedLamp.Name;
                lamp.Material = updatedLamp.Material;
                lamp.Color = updatedLamp.Color;
                lamp.HasDimmer = updatedLamp.HasDimmer;
                lamp.BulbType = updatedLamp.BulbType;
                lamp.ShadeShape = updatedLamp.ShadeShape;
                _context.Lamps.Update(lamp);
                await _context.SaveChangesAsync();
                return lampId;
            }
            return -1; // Indicate that the lamp was not found
        }
    }
}
