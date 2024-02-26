using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities.Products
{
    [Table("Product")]
    public abstract class Product
    {
        public int Id { get; set; }
        public long BarCode { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
    }
}
