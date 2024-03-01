using System;
using AutoMapper;
using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Data;
using RegistrationApi.Interfaces.Users;
using RegistrationApi.Entities.Users;

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
            if(employee == null)
                throw new ArgumentException("Id não existe");
            _mapper.Map(updatedEmployee, employee);
        }
    }
}
