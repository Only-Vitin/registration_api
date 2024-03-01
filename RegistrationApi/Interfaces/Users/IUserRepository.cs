using RegistrationApi.Entities.Users;

namespace RegistrationApi.Interfaces.Users
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void DeleteUser(User User);
        void SaveChanges();
    }
}
