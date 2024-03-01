using RegistrationApi.Data;
using RegistrationApi.Interfaces.Users;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Repositories.Users
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
