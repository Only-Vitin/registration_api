using Microsoft.AspNetCore.Mvc;

using EmailServiceApi.Dto;

namespace EmailServiceApi.Application.Abstractions
{
    public interface IHttpService
    {
        IActionResult PostEmailInfos(EmailDto emailDto);
    }
}
