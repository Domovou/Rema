using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rema1000.Models;
using Rema1000.Services.SupplierService;

namespace Rema1000.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }


        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<Supplier>> GetSuppliers()
        {
            return await _supplierService.GetAllSuppliers();

        }


        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Supplier>> GetSupplierById(Guid id)
        {
            return await _supplierService.GetSupplierById(id);
        }

        // GET api/<ProductController>/supplierService/name

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> CreateSupplier([FromBody] Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                await _supplierService.CreateSupplier(supplier);
            }

            return Created($"api/supplierService", null);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSuppliery(Guid id, [FromBody] Supplier supplierForUpdate)
        {
            if (id != supplierForUpdate.SupplierId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _supplierService.CreateSupplier(supplierForUpdate);
            }

            return NoContent();
        }
        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier(Guid id)
        {
            await _supplierService.DeleteSupplier(id);
            return NoContent();
        }
    }
}

