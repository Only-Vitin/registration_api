using EmailServiceApi.Application.Abstractions;

namespace EmailServiceApi.Application.Services
{
    public class EmailService
    {
        private readonly IEmailSender _emailSender;

        public EmailService(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public string SendEmailService(string from, string to, string subject, string body)
        {
            if(_emailSender.SendEmail(from, to, subject, body))
            {
                return "Email enviado com sucesso!";
            }
            return "Aconteceu um erro, email não enviado";
        }
    }
}