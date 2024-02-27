using System;
using System.Collections.Generic;
using System.Linq;
using RegistrationApi.Abstractions;
using RegistrationApi.Data;
using RegistrationApi.Dto;

namespace RegistrationApi.Repository
{
    public class CustomerRepository : IUserRepository
    {
        private readonly EFContext _context;

        public CustomerRepository(EFContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll<T>()
        {
            var users = _context.User;
            var customers = _context.Customer;

            var customersJoin = users.Join(customers, u => u.Id, c => c.Id, (users, customers) => new 
            {
                Name = users.Name,  
                BirthDate = users.BirthDate,
                Gender = users.Gender,
                CPF = users.CPF,
                Email = users.Email,
                Password = users.Password,
                RegistrationDate = customers.RegistrationDate,
                CustomerFor = customers.CustomerFor,
                TotalAmountSpent = customers.RegistrationDate
            });

            return customersJoin;
        }

        // T GetById(int id);
        // void Add(T user);
        // void Update(T updatedUser);
        // void Delete(T user);
        // void SaveChanges();
    }
}
