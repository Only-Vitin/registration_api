using System;

namespace RegistrationApi.Entities.Users
{
    public class Customer : User
    {
        public DateTime RegistrationDate { get; set; }
        public TimeSpan CustomerFor
        {
            get => DateTime.Now.Subtract(RegistrationDate);
        }
        public double TotalAmountSpent { get; set; }
    }
}
