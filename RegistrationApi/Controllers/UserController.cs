#nullable enable
using Microsoft.AspNetCore.Mvc;

using RegistrationApi.Dto;
using RegistrationApi.Services;
using RegistrationApi.Entities.Users;

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

        [HttpGet("customer/{userId}")]
        public IActionResult GetCustomerById(int userId)
        {
            var customer = _customerService.GetById(userId);
            return Ok(customer);
        }

        [HttpGet("employee/{userId}")]
        public IActionResult GetEmployeeById(int userId)
        {
            var employee = _employeeService.GetById(userId);
            return Ok(employee);
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] UserDto userDto)
        {
            User? user = UserFactory.Create(userDto);
            if(user != null)
            {
                User createdUser = _userService.Post(user);
                return Ok(createdUser);
            }
            return BadRequest();
        }
    }
}
