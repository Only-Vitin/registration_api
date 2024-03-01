#nullable enable

using System;
using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Abstractions;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public UserService(IUserRepository userRepository, ICustomerRepository customerRepository, IEmployeeRepository employeeRepository)
        {
            _userRepository = userRepository;
            _customerRepository = customerRepository;
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<object> Get()
        {
            var employees = _employeeRepository.GetAllEmployees().ToList();
            var customers = _customerRepository.GetAllCustomers().ToList();

            List<object> allUsers = new();
            allUsers = allUsers.Concat(employees).ToList().Concat(customers).ToList();

            return allUsers;
        }

        public User? GetById(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            if(employee != null) return employee;

            return _customerRepository.GetCustomerById(id);
        }

        public User Post(User user)
        {
            _userRepository.AddUser(user);
            _userRepository.SaveChanges();

            return user;
        }

        public bool Put(User updatedUser, int id)
        {
            try
            {
                if(updatedUser is Customer customer)
                    _customerRepository.UpdateCustomer(customer, id);
                else if(updatedUser is Employee employee)
                    _employeeRepository.UpdateEmployee(employee, id);
                    
                _userRepository.SaveChanges();
                return true;
            }
            catch(ArgumentException)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            var user = GetById(id);

            try
            {
                _userRepository.DeleteUser(user);
                _userRepository.SaveChanges();
                return true;
            }
            catch(ArgumentNullException)
            {
                return false;
            }
        }
    }
}
