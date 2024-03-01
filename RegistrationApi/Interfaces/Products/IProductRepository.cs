using RegistrationApi.Entities.Products;

namespace RegistrationApi.Interfaces.Products
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Delete(Product product);
        void SaveChanges();
    }
}
