using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistrationApi.Dto
{
    public class ProductDto
    {
        [Display(Name = "Código de barras")]
        [Required(ErrorMessage = "Informe o código de barras", AllowEmptyStrings = false)]
        public long BarCode { get; set; }

        [Display(Name = "Nome deo produto")]
        [Required(ErrorMessage = "Informe o nome do produto", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Informe a marca", AllowEmptyStrings = false)]
        public string Brand { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Informe o preço", AllowEmptyStrings = false)]
        public double Price { get; set; }

        [Display(Name = "Tipo do produto")]
        [Required(ErrorMessage = "Informe o tipo do produto", AllowEmptyStrings = false)]
        [Range(1,3)]
        public int Type { get; set; }

        [Display(Name = "Campos específicos")]
        [Required(AllowEmptyStrings = false)]
        public Dictionary<string, string> Fields { get; set; }
    }
}
