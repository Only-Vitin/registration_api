using System.Collections.Generic;

using RegistrationApi.Entities.Users;

namespace RegistrationApi.Abstractions
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void UpdateCustomer(Customer updatedCustomer, int id);
    }
}
