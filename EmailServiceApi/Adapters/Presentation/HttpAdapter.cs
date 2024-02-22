using Microsoft.AspNetCore.Mvc;
using EmailServiceApi.Application.Services;
using EmailServiceApi.Application.Abstractions;
using EmailServiceApi.Dto;
using Microsoft.AspNetCore.Http;
using System;

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
        public IActionResult PostEmailInfos([FromBody] EmailDto email)
        {
            if(!_emailService.ValidateEmail(email.From)) 
                return BadRequest(new ResponseMessageDto("Email do remetente está incorreto: " + email.From));

            if(!_emailService.ValidateEmail(email.To)) 
                return BadRequest(new ResponseMessageDto("Email do destinatário está incorreto: " + email.To));

            if(!_emailService.SendEmailService(email.From, email.To, email.Subject, email.Body))
                return StatusCode(StatusCodes.Status500InternalServerError, new ResponseMessageDto("Erro ao enviar o email"));

            return Ok(new ResponseMessageDto("Email enviado com sucesso"));
        }
    }
}
