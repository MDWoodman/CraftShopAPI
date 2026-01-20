using AutoMapper;
using CraftShopAPI.Application.DTO;
using CraftShopAPI.Domain.Entities;

namespace CraftShopAPI.Application.Mappers
{
    public class LampMappingProfile : Profile
    {
       
        public  LampMappingProfile()
        {
            //CreateMap<Domain.Entities.Lamp, Application.DTO.CreateLampDTO>().ForMember
            //     (dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.Material, opt => opt.MapFrom(src => src.Material))
            //    .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Color))
            //    .ForMember(dest => dest.HasDimmer, opt => opt.MapFrom(src => src.HasDimmer))
            //    .ForMember(dest => dest.BulbType, opt => opt.MapFrom(src => src.BulbType))
            //    .ForMember(dest => dest.ShadeShape, opt => opt.MapFrom(src => src.ShadeShape));

                   
            CreateMap<CreateLampDTO, Lamp>()
              .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
              .ForMember(dest => dest.Material, opt => opt.MapFrom(src => src.Material))
              .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Color))
              .ForMember(dest => dest.HasDimmer, opt => opt.MapFrom(src => src.HasDimmer))
              .ForMember(dest => dest.BulbType, opt => opt.MapFrom(src => src.BulbType))
              .ForMember(dest => dest.ShadeShape, opt => opt.MapFrom(src => src.ShadeShape))
              // Ignore ProductId on create (set by DB/service) - adjust if you want to map it
              .ForMember(dest => dest.ProductId, opt => opt.Ignore());

            CreateMap<Lamp, ReadLampDTO>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ProductId))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Material, opt => opt.MapFrom(src => src.Material))
            .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Color))
            .ForMember(dest => dest.HasDimmer, opt => opt.MapFrom(src => src.HasDimmer))
            .ForMember(dest => dest.BulbType, opt => opt.MapFrom(src => src.BulbType))
            .ForMember(dest => dest.ShadeShape, opt => opt.MapFrom(src => src.ShadeShape));
        }

    }
}
