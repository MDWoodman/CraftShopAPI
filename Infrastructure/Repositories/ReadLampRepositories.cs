namespace CraftShopAPI.Infrastructure.Repositories
{
    public class ReadLampRepositories : IReadLampRepositories
    {
        private readonly CraftShopDbContext _context;
        public ReadLampRepositories(CraftShopDbContext context)
        {
            _context = context;
        }
        async public Task<Domain.Entities.Lamp?> GetLampById(int lampId)
        {
            var lamp = await _context.Lamps.FindAsync(lampId);

            if(lamp != null)
            {
                return await Task.FromResult(lamp);
            }

            return null;
        }
        async public Task<IEnumerable<Domain.Entities.Lamp>> GetAllLamps()
        {
            return await Task.FromResult(_context.Lamps.ToList());
        }
        async public Task<Domain.Entities.Lamp?> GetLampByNameLike(string name)
        {
            var lamp = await Task.FromResult(_context.Lamps.FirstOrDefault(l => l.Name.Contains(name)));
            if (lamp != null)
            {
                return lamp;
            }
            return null;
        }
    }
}
