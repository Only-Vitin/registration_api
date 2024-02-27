using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Products
{
    [Table("Drink")]
    public class Drink : Product
    {
        [Required]
        public double AlcoholContent { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }
    }
}
