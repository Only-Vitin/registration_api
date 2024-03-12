using AutoMapper;
using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Data;
using RegistrationApi.Entities.Products;
using RegistrationApi.Interfaces.Products;

namespace RegistrationApi.Repositories.Products
{
    public class CleaningRepository : ICleaningRepository
    {
        private readonly EFContext _context;
        private readonly IMapper _mapper;

        public CleaningRepository(EFContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Cleaning> GetAll()
        {
            return _context.Cleaning;
        }

        public Cleaning GetById(int id)
        {
            return _context.Cleaning.Where(c => c.Id == id).SingleOrDefault();
        }

        public void Update(Cleaning updatedCleaning, int id)
        {
            Cleaning cleaning = _context.Cleaning.Where(c => c.Id == id).SingleOrDefault();
            _mapper.Map(updatedCleaning, cleaning);
        }
    }
}
