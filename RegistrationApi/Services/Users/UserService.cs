#nullable enable

using System;
using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Interfaces.Users;
using RegistrationApi.Entities.Users;
using RegistrationApi.Email;
using System.Threading.Tasks;

namespace RegistrationApi.Services.Users
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEmailSender _emailSender;

        public UserService(IUserRepository userRepository, ICustomerRepository customerRepository, IEmployeeRepository employeeRepository, IEmailSender emailSender)
        {
            _userRepository = userRepository;
            _customerRepository = customerRepository;
            _employeeRepository = employeeRepository;
            _emailSender = emailSender;
        }

        public IEnumerable<object> Get()
        {
            var employees = _employeeRepository.GetAll().ToList();
            var customers = _customerRepository.GetAll().ToList();

            List<object> allUsers = new();
            allUsers = allUsers.Concat(employees).ToList().Concat(customers).ToList();

            return allUsers;
        }

        public User? GetById(int id)
        {
            var employee = _employeeRepository.GetById(id);
            if(employee != null) return employee;

            return _customerRepository.GetById(id);
        }

        public async Task<User> Post(User user)
        {
            _userRepository.Add(user);
            _userRepository.SaveChanges();
            
            await _emailSender.SendAsync("silvas.joaov@gmail.com", user.Email, "Valide seu cadastro!", EmailMessage.CreateUserBody);
            return user;
        }

        public bool Put(User updatedUser, int id)
        {
            try
            {
                if(updatedUser is Customer customer)
                    _customerRepository.Update(customer, id);
                else if(updatedUser is Employee employee)
                    _employeeRepository.Update(employee, id);
                    
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
                _userRepository.Delete(user);
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
