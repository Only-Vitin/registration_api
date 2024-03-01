using System.Collections.Generic;

using RegistrationApi.Entities.Users;

namespace RegistrationApi.Interfaces.Users
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
        void Update(Customer updatedCustomer, int id);
    }
}
