using System.Collections.Generic;

using RegistrationApi.Entities.Users;

namespace RegistrationApi.Interfaces.Users
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        void UpdateEmployee(Employee updatedEmployee, int id);
    }
}
