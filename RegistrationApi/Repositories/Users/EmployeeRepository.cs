using AutoMapper;
using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Data;
using RegistrationApi.Entities.Users;
using RegistrationApi.Interfaces.Users;

namespace RegistrationApi.Repositories.Users
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EFContext _context;
        private readonly IMapper _mapper;

        public EmployeeRepository(EFContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employee;
        }

        public Employee GetById(int id)
        {
            return _context.Employee.Where(e => e.Id == id).SingleOrDefault();
        }

        public void Update(Employee updatedEmployee, int id)
        {
            Employee employee = _context.Employee.Where(e => e.Id == id).SingleOrDefault();
            _mapper.Map(updatedEmployee, employee);
        }
    }
}
