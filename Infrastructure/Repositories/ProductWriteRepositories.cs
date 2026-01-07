// NIE SPEŁNIA SOLID

//using CraftShopAPI.Domain.Entities;

//namespace CraftShopAPI.Infrastructure.Repositories
//{
//    public class ProductWriteRepositories : IProductWriteRepository
//    {
//        private readonly CraftShopDbContext _craftShopDbContext;
//        public ProductWriteRepositories(CraftShopDbContext craftShopDbContext)
//        {
//            _craftShopDbContext = craftShopDbContext;
//        }
//        async  public Task<int> CreateProductAsync(BaseProduct product)
//        {
          
//            switch (product)
//            {
//                case Lamp lamp:
//                    _craftShopDbContext.Lamps.Add(lamp);
//                    break;
//                case Chair chair:
//                    _craftShopDbContext.Chairs.Add(chair);
//                    break;
//                case CrystalDecor crystalDecor:
//                    _craftShopDbContext.CrystalDecors.Add(crystalDecor);
//                    break;
//                default:
//                    throw new ArgumentException("Unsupported product type");
//            }
//            return await _craftShopDbContext.SaveChangesAsync();

//        }
//    }
//}
