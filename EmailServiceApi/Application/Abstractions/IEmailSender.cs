using EmailServiceApi.Application.Abstractions;

namespace EmailServiceApi.Core.Abstractions
{
    public interface IEmailSender
    {
        bool SendEmail(IEmail email);
    }
}
