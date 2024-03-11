using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Entities.Users;
using RegistrationApi.Interfaces.Users;

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
            return _customerRepository.GetAll().ToList();
        }
    }
}
