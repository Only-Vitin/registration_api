using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Abstractions;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> Get()
        {
            return _customerRepository.GetAllCustomers().ToList();
        }

        public Customer GetById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }
    }
}
