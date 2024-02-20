using Microsoft.AspNetCore.Mvc;
using EmailServiceApi.Application.Services;
using EmailServiceApi.Application.Abstractions;
using EmailServiceApi.Dto;

namespace EmailServiceApi.Adapters.Presentation
{
    [ApiController]
    [Route("api/send_email")]
    public class HttpAdapter : ControllerBase, IHttpService
    {
        private readonly EmailService _emailService;

        public HttpAdapter(EmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult RetrieveEmailInfos([FromBody] EmailDto email)
        {
            _emailService.SendEmailService(email.From, email.To, email.Subject, email.Body);
            return Ok();
        }
    }
}
