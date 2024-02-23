using System;
using System.Collections.Generic;

namespace RegistrationApi.Entities.Users
{
    public abstract class User
    {
        protected int Id { get; set; }
        protected string Name { get; private set; }
        protected DateTime BirthDate { get; set; }
        protected string Gender { get; set; }
        protected string CPF { get; set; }
        protected string Email { get; private set; }
        protected string Password { get; private set; }

        protected ICollection<Token> Tokens { get; set; }
    }
}
