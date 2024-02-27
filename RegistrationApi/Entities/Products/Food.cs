using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Products
{
    [Table("Food")]
    public class Food : Product
    {
        [Required]
        public string Allergens { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }
    }
}
