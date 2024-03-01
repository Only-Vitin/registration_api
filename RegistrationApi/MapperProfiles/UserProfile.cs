using AutoMapper;

using RegistrationApi.Entities.Users;

namespace RegistrationApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Employee, Employee>()
                .ForMember(e => e.Id, opt => opt.Ignore());
            CreateMap<Customer, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}
