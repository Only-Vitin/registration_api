using System;
using System.Net;
using System.Net.Mail;
using EmailServiceApi.Application.Abstractions;

namespace EmailServiceApi.Infrastructure
{
    public class SmtpAdapter : IEmailSender
    {
        public bool SendEmail(string from, string to, string subject, string body)
        {
            try
            {
                MailMessage emailMessage = new(from, to, subject, body);

                SmtpClient client = new("smtp.gmail.com", 587){ EnableSsl = true };
                NetworkCredential credential = new("myEmail", "myPassword");
                client.Credentials = credential;
                client.UseDefaultCredentials = false;

                client.Send(emailMessage);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
                return false;
            }
        }
    }
}
