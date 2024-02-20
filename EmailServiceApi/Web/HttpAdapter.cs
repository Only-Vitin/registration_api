using Microsoft.AspNetCore.Mvc;
using EmailServiceApi.Application.Services;
using EmailServiceApi.Application.Abstractions;
using EmailServiceApi.Aplication.Entities;

namespace EmailServiceApi.Web
{
    [ApiController]
    [Route("api/send_email")]
    public class HttpAdapter : ControllerBase, IEmailController<IActionResult>
    {
        private readonly EmailService _emailService;

        public HttpAdapter(EmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult RetrieveEmailInfos([FromBody] Email email)
        {
            if(_emailService.SendEmailService(email))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
