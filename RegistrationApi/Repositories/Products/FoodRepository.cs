using AutoMapper;
using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Data;
using RegistrationApi.Entities.Products;
using RegistrationApi.Interfaces.Products;

namespace RegistrationApi.Repositories.Products
{
    public class FoodRepository : IFoodRepository
    {
        private readonly EFContext _context;
        private readonly IMapper _mapper;

        public FoodRepository(EFContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Food> GetAll()
        {
            return _context.Food;
        }

        public Food GetById(int id)
        {
            return _context.Food.Where(f => f.Id == id).SingleOrDefault();
        }

        public void Update(Food updatedFood, int id)
        {
            Food food = _context.Food.Where(f => f.Id == id).SingleOrDefault();
            _mapper.Map(updatedFood, food);
        }
    }
}
