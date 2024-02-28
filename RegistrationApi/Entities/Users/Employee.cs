using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Users
{
    [Table("Employee")]
    public class Employee : User
    {
        [Required]
        public double Salary { get; set; }

        [Required]
        public DateTime HiringDate { get; set; }

        public string ContractedTime 
        { 
            get => $"{DateTime.Now.Subtract(HiringDate).Days} dias";
        }
    }
}
