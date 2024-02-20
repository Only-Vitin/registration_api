using EmailServiceApi.Core.Abstractions;
using EmailServiceApi.Application.Abstractions;
using EmailServiceApi.Aplication.Entities;

namespace EmailServiceApi.Application.Services
{
    public class EmailService
    {
        private readonly IEmailSender _emailSender;

        public EmailService(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public bool SendEmailService(IEmail email)
        {
            return _emailSender.SendEmail(email);
        }
    }
}