using System;

namespace RegistrationApi.Entities.Products
{
    public class Drink : Product
    {
        public double AlcoholContent { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
