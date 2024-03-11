using System.Collections.Generic;
using RegistrationApi.Entities.Products;

namespace RegistrationApi.Interfaces.Products
{
    public interface ICleaningRepository
    {
        IEnumerable<Cleaning> GetAll();
        Cleaning GetById(int id);
        void Update(Cleaning updatedCleaning, int id);
    }
}
