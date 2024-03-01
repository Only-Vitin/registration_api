using AutoMapper;
using System.Linq;

using RegistrationApi.Data;
using RegistrationApi.Abstractions;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly EFContext _context;
        private readonly IMapper _mapper;

        public UserRepository(EFContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddUser(User user)
        {
            _context.User.Add(user);
        }

        public void UpdateUser(User updatedUser)
        {
            User user = _context.Customer.Where(c => c.Id == updatedUser.Id).SingleOrDefault();
            _mapper.Map(updatedUser, user);
        }

        public void DeleteUser(User user)
        {
            _context.User.Remove(user);
        }
        
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
