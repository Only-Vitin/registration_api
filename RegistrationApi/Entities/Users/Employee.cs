using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Users
{
    [Table("Employee")]
    public class Employee : User
    {
        public double Salary { get; set; }
        public DateTime HiringDate { get; set; }

        public string ContractedTime 
        { 
            get => $"{DateTime.Now.Subtract(HiringDate).Days} dias";
        }
    }
}
