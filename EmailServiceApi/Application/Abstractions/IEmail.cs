namespace EmailServiceApi.Application.Abstractions
{
    public interface IEmail
    {
        public string SenderEmail { get; set; }
        public string  RecipientEmail { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}