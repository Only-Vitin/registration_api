using RegistrationApi.Data;
using RegistrationApi.Entities.Products;
using RegistrationApi.Interfaces.Products;

namespace RegistrationApi.Repositories.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly EFContext _context;

        public ProductRepository(EFContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            _context.Product.Add(product);
        }

        public void Delete(Product product)
        {
            _context.Product.Remove(product);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
