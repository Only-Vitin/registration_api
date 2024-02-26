using System;
using Microsoft.AspNetCore.Mvc;
using RegistrationApi.Entities.Users;
using RegistrationApi.Factory.ConcreteCreator;
using RegistrationApi.Factory.Creator;

namespace RegistrationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost("{userType}")]
        public IActionResult PostUser(int userType, [FromBody] User userInfos)
        {
            UserFactory userFactory = null;
            switch(userType)
            {
                case 1:
                    userFactory = new CustomerFactory();
                    break;
                case 2:
                    userFactory = new EmployeeFactory();
                    break;
            }

            User user = userFactory.Create();
            Console.WriteLine(user.GetType());

            return Ok();
        }
    }
}