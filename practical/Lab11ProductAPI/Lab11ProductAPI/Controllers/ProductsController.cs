using Lab11ProductAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab11ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 85000,
                Quantity = 10
            },

            new Product
            {
                Id = 2,
                Name = "Mouse",
                Price = 800,
                Quantity = 50
            },

            new Product
            {
                Id = 3,
                Name = "Keyboard",
                Price = 1500,
                Quantity = 30
            },

            new Product
            {
                Id = 4,
                Name = "Monitor",
                Price = 25000,
                Quantity = 15
            }
        };

        // GET: api/products
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(products);
        }

        // GET: api/products/1
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(
                p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}