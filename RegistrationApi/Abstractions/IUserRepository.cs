using System.Collections;
using System.Collections.Generic;

namespace RegistrationApi.Abstractions
{
    public interface IUserRepository
    {
        IEnumerable GetAll();
        T GetById<T>(int id);
        void Add<T>(T user);
        void Update<T>(T updatedUser);
        void Delete<T>(T user);
        void SaveChanges();
    }
}
