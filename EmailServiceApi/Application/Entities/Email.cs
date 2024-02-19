namespace EmailServiceApi.Aplication.Entities
{
    public class Email
    {
        public string Sender { get; set; }
        public string  Recipient { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
