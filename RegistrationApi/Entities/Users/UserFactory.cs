using System;

using RegistrationApi.Dto;

namespace RegistrationApi.Entities.Users
{
    public abstract class UserFactory
    {
        public static User Create(UserDto userDto)
        {
            if(userDto.Type == 1)
            {
                return new Customer()
                {
                    Name = userDto.Name,
                    BirthDate = userDto.BirthDate,
                    Gender = userDto.Gender,
                    CPF = userDto.CPF,
                    Email = userDto.Email,
                    Password = userDto.Password,
                    RegistrationDate = DateTime.Parse(userDto.Fields["registrationdate"]),
                    TotalAmountSpent = double.Parse(userDto.Fields["totalamountspent"])
                };
            }
            return new Employee()
            {
                Name = userDto.Name,
                BirthDate = userDto.BirthDate,
                Gender = userDto.Gender,
                CPF = userDto.CPF,
                Email = userDto.Email,
                Password = userDto.Password,
                Salary = double.Parse(userDto.Fields["salary"]),
                HiringDate = DateTime.Parse(userDto.Fields["hiringdate"])
            };
        }
    }
}
