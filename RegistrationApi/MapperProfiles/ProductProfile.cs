using AutoMapper;

using RegistrationApi.Entities.Products;

namespace RegistrationApi.MapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Food, Food>()
                .ForMember(e => e.Id, opt => opt.Ignore());
            CreateMap<Cleaning, Cleaning>()
                .ForMember(e => e.Id, opt => opt.Ignore());
            CreateMap<Drink, Drink>()
                .ForMember(e => e.Id, opt => opt.Ignore());
        }
    }
}
