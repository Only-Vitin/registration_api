using System;

namespace RegistrationApi.Entities.Products
{
    public class Food : Product
    {
        public string Allergens { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
