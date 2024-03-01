using RegistrationApi.Entities.Users;

namespace RegistrationApi.Interfaces.Users
{
    public interface IUserRepository
    {
        void Add(User user);
        void Delete(User User);
        void SaveChanges();
    }
}
