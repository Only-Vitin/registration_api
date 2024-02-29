using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Users
{
    [Table("User")]
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get;  set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string CPF { get; set; }
        public string Email { get;  set; }
        public string Password { get;  set; }

        public ICollection<Token> Tokens { get; set; }
    }
}
