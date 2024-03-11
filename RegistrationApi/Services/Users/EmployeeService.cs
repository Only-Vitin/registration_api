using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Entities.Users;
using RegistrationApi.Interfaces.Users;

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
            return _employeeRepository.GetAll().ToList();
        }
    }
}
