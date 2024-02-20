using EmailServiceApi.Application.Abstractions;

namespace EmailServiceApi.Aplication.Entities
{
    public class Email : IEmail
    {
        public Email(string senderEmail, string recipientEmail, string title, string message)
        {
            SenderEmail = senderEmail;
            RecipientEmail = recipientEmail;
            Title = title;
            Message = message;
        }

        public string SenderEmail { get; set; }
        public string  RecipientEmail { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
