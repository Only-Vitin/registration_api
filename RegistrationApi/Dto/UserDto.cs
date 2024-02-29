using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistrationApi.Dto
{
    public class UserDto
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o nome", AllowEmptyStrings = false)]
        public string Name { get;  set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "Informe a data de nascimento", AllowEmptyStrings = false)]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Gênero")]
        [Required(AllowEmptyStrings = true)]
        public string Gender { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Informe o CPF", AllowEmptyStrings = false)]
        [RegularExpression(@"^([0-9]{3}\.[0-9]{3}\.[0-9]{3}-[0-9]{2})|(^[0-9]{11})$")]
        public string CPF { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Informe o email", AllowEmptyStrings = false)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^((([a-z0-9_\-\.]+)@(([a-z0-9_\-]+)\.)+([a-z]{2,6})))|^((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\]))$")]
        public string Email { get;  set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string Password { get;  set; }

        [Display(Name = "1 - Cliente | 2 - Funcionário")]
        [Required(ErrorMessage = "Informe o tipo do usuário", AllowEmptyStrings = false)]
        [Range(1, 2)]
        public int Type { get; set; }

        [Display(Name = "Campos específicos")]
        [Required(AllowEmptyStrings = false)]
        public Dictionary<string, string> Fields { get; set; }
    }
}
