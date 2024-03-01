using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using RegistrationApi.Dto;
using RegistrationApi.Entities.Users;
using RegistrationApi.Services.Users;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Post([FromBody] UserDto userDto)
        {
            var user = UserFactory.Create(userDto);
            if(user != null)
            {
                User createdUser = await Task.Run(() => _userService.Post(user));

                return StatusCode(StatusCodes.Status201Created, createdUser);
            }
            ResponseMessageDto messageDto = new("Verifique os campos específicos/fields");
            return BadRequest(messageDto);
        }

        [HttpPut("{userId}")]
        public IActionResult Put(int userId, [FromBody] UserDto userDto)
        {
            var updatedUser = UserFactory.Create(userDto);
            if(updatedUser != null)
            {
                if(_userService.Put(updatedUser, userId))
                    return NoContent();
                return NotFound();
            }
            ResponseMessageDto messageDto = new("Verifique o tipo do usuário");
            return BadRequest(messageDto);
        }

        [HttpDelete("{userId}")]
        public IActionResult Delete(int userId)
        {
            if(_userService.Delete(userId))
                return NoContent();
            return NotFound();
        }
    }
}
