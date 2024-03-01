using System.ComponentModel.DataAnnotations;

namespace EmailServiceApi.Dto
{
    public class EmailDto
    {
        [Display(Name = "Remetente")]
        [Required(ErrorMessage = "Informe o remetente ", AllowEmptyStrings = false)]
        public string From { get; set; }

        [Display(Name = "Destinatário")]
        [Required(ErrorMessage = "Informe o destinatário", AllowEmptyStrings = false)]
        public string To { get; set; }

        [Display(Name = "Assunto")]
        [Required(ErrorMessage = "Informe o assunto do email", AllowEmptyStrings = false)]
        public string Subject { get; set; }

        [Display(Name = "Corpo")]
        [Required(ErrorMessage = "Informe o corpo do email", AllowEmptyStrings = false)]
        public string Body { get; set; }
    }
}
