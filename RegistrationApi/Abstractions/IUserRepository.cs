using RegistrationApi.Dto;
using RegistrationApi.Entities;
using System.Collections.Generic;

namespace RegistrationApi.Abstractions
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        User GetUserByEmail(string email);
        void AddUser(User user);
        void UpdateUser(InputUserDto updatedUser, User user);
        void DeleteUser(User user);
        void SaveChanges();
    }
}
