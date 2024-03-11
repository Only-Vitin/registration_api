using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Users
{
    [Table("Customer")]
    public class Customer : User
    {
        public DateTime RegistrationDate { get; set; }

        public string CustomerFor
        {
            get => $"{DateTime.Now.Subtract(RegistrationDate).Days} dias";
        }
        public double TotalAmountSpent { get; set; }
    }
}
