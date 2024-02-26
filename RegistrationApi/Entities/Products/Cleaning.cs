using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Products
{
    [Table("Cleaning")]
    public class Cleaning : Product
    {
        public string Surface { get; set; }
        public string Fragrance { get; set; }
        public string UsagePrecautions { get; set; }
    }
}
