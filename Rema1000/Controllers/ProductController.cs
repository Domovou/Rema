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
        public async Task<IEnumerable<Product>>  GetProduct()
        {
           return await _product.GetAllProducts();

        }
        [HttpGet("{productType}")]
        public IEnumerable<ProductType> GetProductType(ProductType productType)
        {
           // return _product.GetAllProducts();
           throw new NotImplementedException();
        }


        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
