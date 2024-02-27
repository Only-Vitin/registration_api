using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Products
{
    [Table("Cleaning")]
    public class Cleaning : Product
    {
        public string Surface { get; set; }
        public string UsagePrecautions { get; set; }

        [Required]
        public string Fragrance { get; set; }
    }
}
