using System.Net;
using System.Net.Mail;

using EmailServiceApi.Application.Abstractions;

namespace EmailServiceApi.Infrastructure
{
    public class SmtpAdapter : IEmailSender
    {
        public void SendEmail(string from, string to, string subject, string body)
        {
            MailMessage emailMessage = new(from, to, subject, body){ IsBodyHtml = true };

            SmtpClient client = new("smtp.gmail.com", 587){ EnableSsl = true };
            NetworkCredential credential = new("silvas.joaov@gmail.com", "thic nztt pzig smjd");
            client.Credentials = credential;

            client.Send(emailMessage);
        }
    }
}
