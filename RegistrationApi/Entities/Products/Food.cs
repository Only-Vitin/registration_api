using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Products
{
    [Table("Food")]
    public class Food : Product
    {
        public string Allergens { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
