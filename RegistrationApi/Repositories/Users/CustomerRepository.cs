using System;
using AutoMapper;
using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Data;
using RegistrationApi.Entities.Users;
using RegistrationApi.Interfaces.Users;

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

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customer;
        }

        public Customer GetById(int id)
        {
            return _context.Customer.Where(c => c.Id == id).SingleOrDefault();
        }

        public void Update(Customer updatedCustomer, int id)
        {
            Customer customer = _context.Customer.Where(c => c.Id == id).SingleOrDefault();
            _mapper.Map(updatedCustomer, customer);
        }
    }
}
