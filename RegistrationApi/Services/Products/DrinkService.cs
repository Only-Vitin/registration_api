using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Entities.Products;
using RegistrationApi.Services.Exceptions;
using RegistrationApi.Interfaces.Products;

namespace RegistrationApi.Services.Products
{
    public class DrinkService
    {
        private readonly IDrinkRepository _drinkRepository;

        public DrinkService(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        public IEnumerable<Drink> Get()
        {
            var drinks = _drinkRepository.GetAll().ToList();
            if(drinks.Count == 0) throw new NotFoundException("Nenhuma bebida foi encontrada");

            return drinks;
        }
    }
}
