using Microsoft.AspNetCore.Mvc;

using RegistrationApi.Dto;
using RegistrationApi.Services;
using RegistrationApi.Entities.Users;
using Microsoft.AspNetCore.Http;

namespace RegistrationApi.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly CustomerService _customerService;
        private readonly EmployeeService _employeeService;

        public UserController(UserService userService, CustomerService customerService, EmployeeService employeeService)
        {
            _userService = userService;
            _customerService = customerService;
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _userService.Get();
            return Ok(users);
        }

        [HttpGet("customer")]
        public IActionResult GetCustomers()
        {
            var users = _customerService.Get();
            return Ok(users);
        }

        [HttpGet("employee")]
        public IActionResult GetEmployees()
        {
            var users = _employeeService.Get();
            return Ok(users);
        }

        [HttpGet("{userId}")]
        public IActionResult GetById(int userId)
        {
            var user = _userService.GetById(userId);
            if(user != null) return Ok(user);

            return NotFound();
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] UserDto userDto)
        {
            var user = UserFactory.Create(userDto);
            if(user != null)
            {
                User createdUser = _userService.Post(user);
                return StatusCode(StatusCodes.Status201Created, createdUser);
            }
            ResponseMessageDto messageDto = new("Verifique o tipo do usuário");
            return BadRequest(messageDto);
        }
    }
}
