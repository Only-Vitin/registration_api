using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using RegistrationApi.Dto;
using RegistrationApi.Entities.Products;
using RegistrationApi.Services.Products;
using RegistrationApi.Services.Exceptions;

namespace RegistrationApi.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        private readonly CleaningService _cleaningService;
        private readonly DrinkService _drinkService;
        private readonly FoodService _foodService;

        public ProductController(ProductService productService, CleaningService cleaningService, DrinkService drinkService, FoodService foodService)
        {
            _productService = productService;
            _cleaningService = cleaningService;
            _drinkService = drinkService;
            _foodService = foodService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var products = _productService.Get();
                return Ok(products);
            }
            catch(NotFoundException ex)
            {
                return NotFound(new ResponseMessageDto(ex.Message));
            }
        }

        [HttpGet("cleaning")]
        public IActionResult GetCleanings()
        {
            try
            {
                var cleanings = _cleaningService.Get();
                return Ok(cleanings);
            }
            catch(NotFoundException ex)
            {
                return NotFound(new ResponseMessageDto(ex.Message));
            }
        }

        [HttpGet("drink")]
        public IActionResult GetDrinks()
        {
            try
            {
                var drinks = _drinkService.Get();
                return Ok(drinks);
            }
            catch(NotFoundException ex)
            {
                return NotFound(new ResponseMessageDto(ex.Message));
            }
        }

        [HttpGet("food")]
        public IActionResult GetFoods()
        {
            try
            {
                var foods = _foodService.Get();
                return Ok(foods);
            }
            catch(NotFoundException ex)
            {
                return NotFound(new ResponseMessageDto(ex.Message));
            }
        }

        [HttpGet("{productId}")]
        public IActionResult GetById(int productId)
        {
            var product = _productService.GetById(productId);
            if(product == null) return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProductDto productDto)
        {
            try
            {
                var product = ProductFactory.Create(productDto);
                if(product == null)
                {
                    return BadRequest(new ResponseMessageDto("Verifique os campos específicos/fields"));
                }

                Product createdProduct = _productService.Post(product);
                return StatusCode(StatusCodes.Status201Created, createdProduct);
            }
            catch(FormatException)
            {
                return BadRequest(new ResponseMessageDto("Formato errado de algum parâmetro do JSON, verifique o tipo das variáveis"));
            }
        }

        [HttpPut("{productId}")]
        public IActionResult Put(int productId, [FromBody] ProductDto productDto)
        {
            try
            {
                var updatedProduct = ProductFactory.Create(productDto);
                if(updatedProduct == null)
                {
                    return BadRequest(new ResponseMessageDto("Verifique os campos específicos/fields"));
                }

                _productService.Put(updatedProduct, productId);
                return NoContent();
            }
            catch(NotFoundException ex)
            {
                return NotFound(new ResponseMessageDto(ex.Message));
            }
        }

        [HttpDelete("{productId}")]
        public IActionResult Delete(int productId)
        {
            try
            {
                _productService.Delete(productId);
                return NoContent();
            }
            catch(NotFoundException ex)
            {
                return NotFound(new ResponseMessageDto(ex.Message));
            }
        }
    }
}
