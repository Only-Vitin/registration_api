using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Entities.Products;
using RegistrationApi.Services.Exceptions;
using RegistrationApi.Interfaces.Products;

namespace RegistrationApi.Services.Products
{
    public class FoodService
    {
        private readonly IFoodRepository _foodRepository;

        public FoodService(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public IEnumerable<Food> Get()
        {
            var foods = _foodRepository.GetAll().ToList();
            if(foods.Count == 0) throw new NotFoundException("Nenhum alimento foi encontrado");

            return foods;
        }
    }
}
