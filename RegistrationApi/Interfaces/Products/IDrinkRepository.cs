using System.Collections.Generic;
using RegistrationApi.Entities.Products;

namespace RegistrationApi.Interfaces.Products
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> GetAll();
        Drink GetById(int id);
        void Update(Drink updatedDrink, int id);
    }
}
