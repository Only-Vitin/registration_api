using System.ComponentModel.DataAnnotations;

namespace RegistrationApi.Dto
{
    public class InputUserDto
    {
        [Required(ErrorMessage = "Informe o seu nome")]
        public string Name { get; private set; }

        [Required(ErrorMessage = "Informe o seu email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Informe um email válido")]
        public string Email { get; private set; }

        [Required(ErrorMessage = "Informe a sua senha")]
        public string Password { get; private set; }
    }
}
