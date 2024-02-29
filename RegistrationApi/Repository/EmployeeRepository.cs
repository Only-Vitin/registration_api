using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Data;
using RegistrationApi.Abstractions;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EFContext _context;

        public EmployeeRepository(EFContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employee;
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employee.Where(e => e.Id == id).SingleOrDefault();
        }
    }
}
