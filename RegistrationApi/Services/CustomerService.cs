using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Abstractions;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUserRepository _userRepository;

        public CustomerService(ICustomerRepository customerRepository, IUserRepository userRepository)
        {
            _customerRepository = customerRepository;
            _userRepository = userRepository;
        }

        public List<Customer> Get()
        {
            var customers = _customerRepository.GetAllCustomers().ToList();
            return customers;
        }

        public Customer GetById(int id)
        {
            return _customerRepository.GetCustomerById(id);
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
