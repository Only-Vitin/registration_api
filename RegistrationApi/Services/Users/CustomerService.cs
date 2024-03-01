using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Interfaces.Users;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Services.Users
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
    }
}
