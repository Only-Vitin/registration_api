using System.Text;
using System.Net.Http;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace RegistrationApi.Email
{
    public class EmailSenderHttp : IEmailSender
    {
        public async Task<bool> SendAsync(string from, string to, string subject, string body)
        {
            Dictionary<string, object> data = new()
            {
                { "from", from },
                { "to", to },
                { "subject", subject },
                { "body", body }
            };

            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };


            HttpClient _cliente = new(handler);
            var response = await _cliente.PostAsync("https://localhost:7001/api/send_email", content);
            if(response.IsSuccessStatusCode)
                return true;
            return false;
        }
    }
}
