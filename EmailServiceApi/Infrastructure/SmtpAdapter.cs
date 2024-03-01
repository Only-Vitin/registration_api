using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;

using EmailServiceApi.Application.Abstractions;

namespace EmailServiceApi.Infrastructure
{
    public class SmtpAdapter : IEmailSender
    {
        private readonly SmtpConfig _smtpConfig;

        public SmtpAdapter(IOptions<SmtpConfig> options)
        {
            _smtpConfig = options.Value;
        }

        public void SendEmail(string from, string to, string subject, string body)
        {
            MailMessage emailMessage = new(from, to, subject, body){ IsBodyHtml = true };

            SmtpClient client = new("smtp.gmail.com", 587){ EnableSsl = true };
            NetworkCredential credential = new("silvas.joaov@gmail.com", _smtpConfig.Key);
            client.Credentials = credential;

            client.Send(emailMessage);
        }
    }
}
