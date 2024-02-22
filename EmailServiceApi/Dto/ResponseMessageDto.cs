namespace EmailServiceApi.Dto
{
    public struct ResponseMessageDto
    {
        public ResponseMessageDto(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}