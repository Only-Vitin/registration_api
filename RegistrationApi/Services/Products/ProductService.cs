#nullable enable

using System;
using System.Linq;
using System.Collections.Generic;

using RegistrationApi.Entities.Products;
using RegistrationApi.Services.Exceptions;
using RegistrationApi.Interfaces.Products;

namespace RegistrationApi.Services.Products
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICleaningRepository _cleaningRepository;
        private readonly IDrinkRepository _drinkRepository;
        private readonly IFoodRepository _foodRepository;

        public ProductService(IProductRepository productRepository, ICleaningRepository cleaningRepository, IDrinkRepository drinkRepository, IFoodRepository foodRepository)
        {
            _productRepository = productRepository;
            _cleaningRepository = cleaningRepository;
            _drinkRepository = drinkRepository;
            _foodRepository = foodRepository;
        }

        public IEnumerable<object> Get()
        {
            var cleanings = _cleaningRepository.GetAll().ToList();
            var drinks = _drinkRepository.GetAll().ToList();
            var foods = _foodRepository.GetAll().ToList();

            List<object> allProducts = new();
            allProducts = allProducts.Concat(cleanings).Concat(drinks).Concat(foods).ToList();
            if(allProducts.Count == 0) throw new NotFoundException("Nenhum usuário encontrado");

            return allProducts;
        }

        public Product? GetById(int id)
        {
            var cleanings = _cleaningRepository.GetById(id);
            if(cleanings != null) return cleanings;

            var drinks = _drinkRepository.GetById(id);
            if(drinks != null) return drinks;

            return _foodRepository.GetById(id);
        }

        public Product Post(Product product)
        {
            _productRepository.Add(product);
            _productRepository.SaveChanges();

            return product;
        }

        public void Put(Product updatedProduct, int id)
        {
            try
            {
                if(updatedProduct is Cleaning cleaning)
                    _cleaningRepository.Update(cleaning, id);
                else if(updatedProduct is Drink drink)
                    _drinkRepository.Update(drink, id);
                else if(updatedProduct is Food food)
                    _foodRepository.Update(food, id);

                _productRepository.SaveChanges();
            }
            catch(ArgumentException)
            {
                throw new NotFoundException("Id não encontrado");
            }
        }

        public void Delete(int id)
        {
            try
            {
                var product = GetById(id);

                _productRepository.Delete(product);
                _productRepository.SaveChanges();
            }
            catch(ArgumentNullException)
            {
                throw new NotFoundException("Id não encontrado");
            }
        }
    }
}
