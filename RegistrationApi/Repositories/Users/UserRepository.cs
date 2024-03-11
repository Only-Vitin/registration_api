using RegistrationApi.Data;
using RegistrationApi.Entities.Users;
using RegistrationApi.Interfaces.Users;

namespace RegistrationApi.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly EFContext _context;

        public UserRepository(EFContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.User.Add(user);
        }

        public void Delete(User user)
        {
            _context.User.Remove(user);
        }
        
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
