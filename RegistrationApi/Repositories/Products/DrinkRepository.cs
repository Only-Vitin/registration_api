using AutoMapper;
using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Data;
using RegistrationApi.Entities.Products;
using RegistrationApi.Interfaces.Products;

namespace RegistrationApi.Repositories.Products
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly EFContext _context;
        private readonly IMapper _mapper;

        public DrinkRepository(EFContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Drink> GetAll()
        {
            return _context.Drink;
        }

        public Drink GetById(int id)
        {
            return _context.Drink.Where(d => d.Id == id).SingleOrDefault();
        }

        public void Update(Drink updatedDrink, int id)
        {
            Drink drink = _context.Drink.Where(d => d.Id == id).SingleOrDefault();
            _mapper.Map(updatedDrink, drink);
        }
    }
}
