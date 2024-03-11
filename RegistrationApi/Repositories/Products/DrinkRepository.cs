using RegistrationApi.Data;

namespace RegistrationApi.Repositories.Products
{
    public class DrinkRepository
    {
        private readonly EFContext _context;

        public DrinkRepository(EFContext context)
        {
            _context = context;
        }

        
    }
}
