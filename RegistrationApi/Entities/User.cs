using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistrationApi.Entities
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Informe o seu nome")]
        public string Name { get; private set; }

        [Required(ErrorMessage = "Informe o seu email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Informe um email válido")]
        public string Email { get; private set; }

        [Required(ErrorMessage = "Informe a sua senha")]
        [DataType(DataType.Password)]
        public string Password { get; private set; }

        public ICollection<Token> Tokens { get; set; }
    }
}
