using AutoMapper;
using System.Linq;
using RegistrationApi.Data;
using System.Collections.Generic;
using RegistrationApi.Abstractions;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly EFContext _context;

        public CustomerRepository(EFContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customer;
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customer.Where(c => c.Id == id).SingleOrDefault();
        }
    }
}
