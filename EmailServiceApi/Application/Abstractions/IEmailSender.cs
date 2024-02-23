namespace EmailServiceApi.Application.Abstractions
{
    public interface IEmailSender
    {
        void SendEmail(string from, string to, string subject, string body);
    }
} 
