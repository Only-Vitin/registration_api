using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Users
{
    [Table("Customer")]
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
