using System.Collections.Generic;

using RegistrationApi.Entities.Users;

namespace RegistrationApi.Interfaces.Users
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Update(Employee updatedEmployee, int id);
    }
}
