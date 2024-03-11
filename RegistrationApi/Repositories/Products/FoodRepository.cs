using RegistrationApi.Data;

namespace RegistrationApi.Repositories.Products
{
    public class FoodRepository
    {
        private readonly EFContext _context;

        public FoodRepository(EFContext context)
        {
            _context = context;
        }

        
    }
}
