using System.Collections.Generic;

using RegistrationApi.Entities.Users;

namespace RegistrationApi.Interfaces.Users
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void UpdateCustomer(Customer updatedCustomer, int id);
    }
}
