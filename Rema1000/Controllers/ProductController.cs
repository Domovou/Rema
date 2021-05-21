using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rema1000.Models;
using Rema1000.Services.ProductService;


namespace Rema1000.Controllers
{       
    ///<summary>Controller responsible for handling products </summary>
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _product;

        public ProductController(IProductService product)
        {
            _product = product;
        }


        ///<summary>Gets the information of all products</summary>
        [HttpGet]
        public async Task<IEnumerable<Product>> GetProduct()
        {
           return await _product.GetAllProducts();

        }


        ///<summary>Gets the information on the product of a given id</summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(Guid id)
        {
            return await _product.GetProductById(id);
        }

        ///<summary>Gets the all products of the given Category</summary>
        [HttpGet("product/{categoryName}")]
        public async Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {
            return await _product.GetAllProductsByCategory(categoryName);
        }

        /// <summary>This POST method creates a new Product </summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                await _product.CreateProduct(product);
            }

            return Created($"api/product", null);
        }

        ///<summary>This PUT method updates the product with the given id </summary>
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
        /// <summary>This DELETE method deletes the product with the given id </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            await _product.DeleteProduct(id);
            return NoContent();
        }
    }
}
