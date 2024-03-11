using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Entities.Users;
using RegistrationApi.Interfaces.Users;
using RegistrationApi.Services.Exceptions;

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
            var employees = _employeeRepository.GetAll().ToList();
            if(employees.Count == 0) throw new NotFoundException("Nenhum funcionário encontrado");

            return employees;
        }
    }
}
