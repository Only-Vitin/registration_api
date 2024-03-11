using RegistrationApi.Data;

namespace RegistrationApi.Repositories.Products
{
    public class ProductRepository
    {
        private readonly EFContext _context;

        public ProductRepository(EFContext context)
        {
            _context = context;
        }

        
    }
}
