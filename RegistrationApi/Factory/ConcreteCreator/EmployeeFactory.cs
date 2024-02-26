using RegistrationApi.Entities.Users;
using RegistrationApi.Factory.Creator;

namespace RegistrationApi.Factory.ConcreteCreator
{
    public class EmployeeFactory : UserFactory
    {
        public override User Create()
        {
            return new Employee();
        }
    }
}
