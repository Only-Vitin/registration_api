using AutoMapper;
using System.Linq;
using RegistrationApi.Dto;
using System.Collections.Generic;
using RegistrationApi.Abstractions;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _userRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public List<Customer> Get()
        {
            var customers = _userRepository.GetAll().ToList();
            return customers;
        }

        public Customer GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public Customer Post(User user)
        {
            _userRepository.Add(user);
            _userRepository.SaveChanges();

            return customer;
        }

        public void Put(UserDto customerDto)
        {
            _userRepository.Update(customerDto);
            _userRepository.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            _userRepository.Delete(customer);
            _userRepository.SaveChanges();
        }
    }
}
