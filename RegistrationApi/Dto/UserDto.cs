using System;
using System.Collections.Generic;

namespace RegistrationApi.Dto
{
    public class UserDto
    {
        public string Name { get;  set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string CPF { get; set; }
        public string Email { get;  set; }
        public string Password { get;  set; }
        public int Type { get; set; } 
        public Dictionary<string, string> Fields { get; set; }
    }
}
