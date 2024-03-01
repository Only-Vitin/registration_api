using System.Threading.Tasks;

namespace RegistrationApi.Email
{
    public interface IEmailSender
    {
        Task<bool> SendAsync(string from, string to, string subject, string body);
    }
}
