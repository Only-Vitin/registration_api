using Microsoft.AspNetCore.Mvc;

using RegistrationApi.Dto;
using RegistrationApi.Services;
using RegistrationApi.Entities.Users;

namespace RegistrationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public UserController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var customers = _customerService.Get();
            return Ok(customers);
        }

        [HttpGet("{userId}")]
        public IActionResult GetById(int userId)
        {
            var customer = _customerService.GetById(userId);
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserDto userDto)
        {
            User user = UserFactory.Create(userDto);
            var createdCustomer = _customerService.Post(user);

            return Ok(createdCustomer);
        }
    }
}
