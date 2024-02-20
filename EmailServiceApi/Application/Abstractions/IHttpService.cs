using EmailServiceApi.Dto;
using Microsoft.AspNetCore.Mvc;

namespace EmailServiceApi.Application.Abstractions
{
    public interface IHttpService
    {
        IActionResult RetrieveEmailInfos(EmailDto emailDto);
    }
}