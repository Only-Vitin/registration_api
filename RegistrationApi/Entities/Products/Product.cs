using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Products
{
    [Table("Product")]
    public abstract class Product
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public long BarCode { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
