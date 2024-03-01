using System.Collections.Generic;

using RegistrationApi.Entities.Users;

namespace RegistrationApi.Abstractions
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void DeleteUser(User User);
        void SaveChanges();
    }
}
