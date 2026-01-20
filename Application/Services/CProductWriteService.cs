// NIE SPEŁNIA SOLID


//using CraftShopAPI.Application.Builders;
//using CraftShopAPI.Application.DTO;
//using CraftShopAPI.Application.Factories;
//using CraftShopAPI.Application.Services.Interface;
//using CraftShopAPI.Domain.Entities;
//using CraftShopAPI.Infrastructure.Repositories;

//namespace CraftShopAPI.Application.Services
//{
//    public class CProductWriteService : IProductWriteService
//    {
//        private readonly IProductWriteRepository _productWriteRepository;
//        private readonly IProductFactory _productFactory;
//        public CProductWriteService(IProductWriteRepository productWriteRepository , IProductFactory productFactory)
//        {
//            _productFactory = productFactory;
//            _productWriteRepository = productWriteRepository;
//        }
//        public async Task<int> CreateProductAsync(CreateBaseProductDto createBaseProductDto)
//        {
//            var product = _productFactory.CreateProduct(createBaseProductDto);

//            switch (product)
//            {
//                case Lamp lamp:
//                    var lampBuilder = new LampBuilder();
//                    var _lamp = lampBuilder
//                        .SetName(createBaseProductDto.Name)
//                        .SetMaterial(createBaseProductDto.Material)
//                        .SetColor(createBaseProductDto.Color)
//                        .SetDimmer(((CreateLampDTO)createBaseProductDto).HasDimmer)
//                        .SetBulbType(((CreateLampDTO)createBaseProductDto).BulbType)
//                        .SetShadeShape(((CreateLampDTO)createBaseProductDto).ShadeShape)
//                        .Build();

//                    var lampId = await _productWriteRepository.CreateProductAsync(_lamp);
//                    return lampId;

//                    break;
//                case Chair chair:

//                    var chairBuilder = new ChairBuilder();
//                    var _chair = chairBuilder
//                        .SetName(createBaseProductDto.Name)
//                        .SetMaterial(createBaseProductDto.Material)
//                        .SetColor(createBaseProductDto.Color)
//                        .SetHasCushion(((CreateChairDTO)createBaseProductDto).HasCushion)
//                        .SetStyle(((CreateChairDTO)createBaseProductDto).Style)
//                        .SetNumberOfLegs(((CreateChairDTO)createBaseProductDto).NumberOfLegs)
//                        .Build();
//                    var chairId = await _productWriteRepository.CreateProductAsync(_chair);
//                    return chairId;

//                    break;
//                case CrystalDecor crystalDecor:
//                    // Additional logic for CrystalDecor if needed
//                    break;
//                default:
//                    throw new ArgumentException("Unsupported product type");
//            }

//            // You likely want to persist the product and return its ID.
//            // Example:
//            // return _productWriteRepository.AddAsync(product);

//            throw new NotImplementedException();
//        }
//    }
//}
