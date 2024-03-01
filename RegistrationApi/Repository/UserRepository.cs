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

        public UserRepository(EFContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.User.Add(user);
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
