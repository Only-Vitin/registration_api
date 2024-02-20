using EmailServiceApi.Aplication.Entities;

namespace EmailServiceApi.Application.Abstractions
{
    public interface IEmailController<T>
    {
        T RetrieveEmailInfos(Email email);
    }
}
