using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Abstractions;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Services
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

        public Employee GetById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }
    }
}
