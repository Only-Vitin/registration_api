using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Entities.Users;
using RegistrationApi.Interfaces.Users;
using RegistrationApi.Services.Exceptions;

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
            var customers = _customerRepository.GetAll().ToList();
            if(customers.Count == 0) throw new NotFoundException("Nenhum cliente encontrado");

            return customers;
        }
    }
}
