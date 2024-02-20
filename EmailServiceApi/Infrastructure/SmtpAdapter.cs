using System;
using System.Net;
using System.Net.Mail;
using EmailServiceApi.Application.Abstractions;
using EmailServiceApi.Core.Abstractions;

namespace EmailServiceApi.Infrastructure
{
    public class SmtpAdapter : IEmailSender
    {
        public bool SendEmail(IEmail email)
        {
            try
            {
                MailMessage mailMessage = new(
                    email.SenderEmail, email.RecipientEmail, email.Title, email.Message
                );

                SmtpClient client = new("smtp.gmail.com", 587);
                client.EnableSsl = true; 
                NetworkCredential credential = new("silvas.joaov@gmail.com", "#0102ecjkJuaum@Vitor.50");
                client.Credentials = credential;

                client.UseDefaultCredentials = true;

                client.Send(mailMessage);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message, e.InnerException);
                return false;
            }
        }
    }
}
