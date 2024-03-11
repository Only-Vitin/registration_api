using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using RegistrationApi.Dto;
using RegistrationApi.Entities.Users;
using RegistrationApi.Services.Users;
using RegistrationApi.Services.Exceptions;

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
            if(user == null) return NotFound();

            return Ok(user);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserDto userDto)
        {
            try
            {
                var user = UserFactory.Create(userDto);
                if(user == null)
                {
                    return BadRequest(new ResponseMessageDto("Verifique os campos específicos/fields"));
                }

                User createdUser = await Task.Run(() => _userService.Post(user));
                return StatusCode(StatusCodes.Status201Created, createdUser);
            }
            catch(HttpRequestException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("{userId}")]
        public IActionResult Put(int userId, [FromBody] UserDto userDto)
        {
            try
            {
                var updatedUser = UserFactory.Create(userDto);
                if(updatedUser == null)
                {
                    return BadRequest(new ResponseMessageDto("Verifique o tipo do usuário"));
                }

                _userService.Put(updatedUser, userId);
                return NoContent();
            }
            catch(NotFoundException ex)
            {
                return NotFound(new ResponseMessageDto(ex.Message));
            }
        }

        [HttpDelete("{userId}")]
        public IActionResult Delete(int userId)
        {
            try
            {
                _userService.Delete(userId);
                return NoContent();
            }
            catch(NotFoundException ex)
            {
                return NotFound(new ResponseMessageDto(ex.Message));
            }
        }
    }
}
