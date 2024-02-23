using System;

namespace RegistrationApi.Entities.Users
{
    public class Employee : User
    {
        public double Salary { get; set; }
        public DateTime HiringDate { get; set; }
        public TimeSpan ContractedTime 
        { 
            get => DateTime.Now.Subtract(HiringDate);
        }
        public TimeSpan OvertimeWorked { get; set; }
    }
}

