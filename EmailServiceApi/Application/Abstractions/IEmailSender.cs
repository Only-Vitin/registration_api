namespace EmailServiceApi.Application.Abstractions
{
    public interface IEmailSender
    {
        bool SendEmail(string from, string to, string subject, string body);
    }
}
