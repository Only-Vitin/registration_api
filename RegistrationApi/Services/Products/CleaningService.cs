using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Entities.Products;
using RegistrationApi.Services.Exceptions;
using RegistrationApi.Interfaces.Products;

namespace RegistrationApi.Services.Products
{
    public class CleaningService
    {
        private readonly ICleaningRepository _cleaningRepository;

        public CleaningService(ICleaningRepository cleaningRepository)
        {
            _cleaningRepository = cleaningRepository;
        }

        public IEnumerable<Cleaning> Get()
        {
            var cleanings = _cleaningRepository.GetAll().ToList();
            if(cleanings.Count == 0) throw new NotFoundException("Nenhum produto de limpeza foi encontrado");

            return cleanings;
        }
    }
}
