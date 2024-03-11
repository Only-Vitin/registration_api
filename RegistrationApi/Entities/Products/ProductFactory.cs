#nullable enable

using System;
using System.Collections.Generic;
using RegistrationApi.Dto;

namespace RegistrationApi.Entities.Products
{
    public abstract class ProductFactory
    {
        public static Product? Create(ProductDto productDto)
        {
            try
            {
                if(productDto.Type == 1)
                {
                    return new Cleaning()
                    {
                        BarCode = productDto.BarCode,
                        Name = productDto.Name,
                        Brand = productDto.Brand,
                        Price = productDto.Price,
                        Surface = productDto.Fields["surface"],
                        UsagePrecautions = productDto.Fields["usageprecautions"],
                        Fragrance = productDto.Fields["fragrance"]
                    };
                }
                else if(productDto.Type == 2)
                {
                    return new Drink()
                    {
                        BarCode = productDto.BarCode,
                        Name = productDto.Name,
                        Brand = productDto.Brand,
                        Price = productDto.Price,
                        AlcoholContent = double.Parse(productDto.Fields["alcoholcontent"]),
                        ExpirationDate = DateTime.Parse(productDto.Fields["expirationdate"])
                    };
                }
                else if(productDto.Type == 3)
                {
                    return new Food()
                    {
                        BarCode = productDto.BarCode,
                        Name = productDto.Name,
                        Brand = productDto.Brand,
                        Price = productDto.Price,
                        Allergens = productDto.Fields["allergens"],
                        ExpirationDate = DateTime.Parse(productDto.Fields["expirationdate"])
                    };
                }
                return null;
            }
            catch(KeyNotFoundException)
            {
                return null;
            }
        }
    }
}
