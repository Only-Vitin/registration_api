using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Interfaces.Users;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Services.Users
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> Get()
        {
            return _employeeRepository.GetAllEmployees().ToList();
        }
    }
}
