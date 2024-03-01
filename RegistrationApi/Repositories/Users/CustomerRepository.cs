using System;
using AutoMapper;
using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Data;
using RegistrationApi.Interfaces.Users;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Repositories.Users
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly EFContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(EFContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customer;
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customer.Where(c => c.Id == id).SingleOrDefault();
        }

        public void UpdateCustomer(Customer updatedCustomer, int id)
        {
            Customer customer = _context.Customer.Where(c => c.Id == id).SingleOrDefault();
            if(customer == null)
                throw new ArgumentException("Id não existe");
            _mapper.Map(updatedCustomer, customer);
        }
    }
}
