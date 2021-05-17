using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rema1000.Models;
using Rema1000.Services.ProductService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rema1000.Controllers
{    /// <summary>Controller responsible for GET/POST/DELETE for managing Products </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _product;

        public ProductController(IProductService product)
        {
            _product = product;
        }

       
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<Product>> GetProduct()
        {
           return await _product.GetAllProducts();

        }
       

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(Guid id)
        {
            return await _product.GetProductById(id);
        }

        // GET api/<ProductController>/product/name
        [HttpGet("product/{categoryName}")]
        public async Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {
            return await _product.GetAllProductsByCategory(categoryName);
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                await _product.CreateProduct(product);
            }

            return Created($"api/product", null);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(Guid id, [FromBody] Product productForUpdate)
        {
            if (id != productForUpdate.ProductId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _product.UpdateProduct(productForUpdate);
            }

            return NoContent();
        }
        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            await _product.DeleteProduct(id);
            return NoContent();
        }
    }
}
