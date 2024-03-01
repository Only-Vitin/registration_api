using System.Collections.Generic;
using RegistrationApi.Entities.Products;

namespace RegistrationApi.Interfaces.Products
{
    public interface IFoodRepository
    {
        IEnumerable<Food> GetAll();
        Food GetById(int id);
        void Update(Food updatedFood, int id);
    }
}
