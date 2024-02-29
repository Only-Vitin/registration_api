using System.Collections.Generic;

using RegistrationApi.Entities.Users;

namespace RegistrationApi.Abstractions
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        void AddUser(User customerDto);
        void UpdateUser(User updatedCustomer);
        void DeleteUser(User User);
        void SaveChanges();
    }
}
