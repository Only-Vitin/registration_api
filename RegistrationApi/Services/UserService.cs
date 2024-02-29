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

        public User Post(User user)
        {
            _userRepository.AddUser(user);
            _userRepository.SaveChanges();

            return user;
        }

        public void Put(User user)
        {
            _userRepository.UpdateUser(user);
            _userRepository.SaveChanges();
        }

        public void Delete(User user)
        {
            _userRepository.DeleteUser(user);
            _userRepository.SaveChanges();
        }
    }
}