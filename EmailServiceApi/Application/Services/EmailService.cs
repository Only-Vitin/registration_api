using System;
using System.Text.RegularExpressions;
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

        public bool SendEmailService(string from, string to, string subject, string body)
        {
            try
            {
                _emailSender.SendEmail(from, to, subject, body);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool ValidateEmail(string email)
        {
            Regex emailRegex = new(@"^([\w\.\-]{1,63})@([\p{L}\d\-]+)((\.[\w\-]+)+)$");
            return emailRegex.IsMatch(email);
        }
    }
}
