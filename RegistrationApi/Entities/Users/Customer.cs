using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Users
{
    [Table("Customer")]
    public class Customer : User
    {
        [Required]
        public DateTime RegistrationDate { get; set; }

        public TimeSpan CustomerFor
        {
            get => DateTime.Now.Subtract(RegistrationDate);
        }

        [Required]
        public double TotalAmountSpent { get; set; }
    }
}
