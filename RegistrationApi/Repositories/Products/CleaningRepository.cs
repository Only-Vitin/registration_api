using RegistrationApi.Data;

namespace RegistrationApi.Repositories.Products
{
    public class CleaningRepository
    {
        private readonly EFContext _context;

        public CleaningRepository(EFContext context)
        {
            _context = context;
        }

        
    }
}
