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
