using System;

namespace RegistrationApi.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get;  set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string CPF { get; set; }
        public string Email { get;  set; }
        public string Password { get;  set; }
        public DateTime RegistrationDate { get; set; }
        public TimeSpan CustomerFor { get; set; }
        public double TotalAmountSpent { get; set; }
    }
}