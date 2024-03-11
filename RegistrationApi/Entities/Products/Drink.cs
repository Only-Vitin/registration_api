using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Products
{
    [Table("Drink")]
    public class Drink : Product
    {
        public double AlcoholContent { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
