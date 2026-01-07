using AutoMapper;

namespace CraftShopAPI.Application.Mappers
{
    public class LampMappingProfile : Profile
    {
       
        void LampMappersProfile()
        {
           CreateMap<Domain.Entities.Lamp, Application.DTO.CreateLampDTO>().ForMember
                (dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Material, opt => opt.MapFrom(src => src.Material))
               .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Color))
               .ForMember(dest => dest.HasDimmer, opt => opt.MapFrom(src => src.HasDimmer))
               .ForMember(dest => dest.BulbType, opt => opt.MapFrom(src => src.BulbType))
               .ForMember(dest => dest.ShadeShape, opt => opt.MapFrom(src => src.ShadeShape));


        }

    }
}
