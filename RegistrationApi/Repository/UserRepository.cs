using AutoMapper;
using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Data;
using RegistrationApi.Abstractions;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly EFContext _context;
        private readonly IMapper _mapper;

        public UserRepository(EFContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<User> GetAllUsers()
        {
            List<User> users = new();

            var customers = _context.Customer.ToList();
            var employees = _context.Employee.ToList();

            foreach(var customer in customers)
            {
                users.Add(customer);
            }

            foreach(var employee in employees)
            {
                users.Add(employee);
            }

            List<User> orderUsers = users.OrderBy(u => u.Id).ToList();

            return orderUsers;
        }
        
        public void AddUser(User user)
        {
            _context.User.Add(user);
        }

        public void UpdateUser(User updatedUser)
        {
            User user = _context.Customer.Where(c => c.Id == updatedUser.Id).SingleOrDefault();
            _mapper.Map(updatedUser, user);
        }

        public void DeleteUser(User user)
        {
            _context.User.Remove(user);
        }
        
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
