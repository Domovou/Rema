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
    ///<summary>Controller responsible for handling Suppliers </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }


        ///<summary>Gets the all Suppliers</summary>
        [HttpGet]
        public async Task<IEnumerable<Supplier>> GetSuppliers()
        {
            return await _supplierService.GetAllSuppliers();
        }

        ///<summary>Gets the information on the Supplier of a given Cvr number</summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<Supplier>> GetSupplierById(string id)
        {
            return await _supplierService.GetSupplierByCvrNumber(id);
        }

        /// <summary>This POST method creates a new Supplier </summary>
        [HttpPost]
        public async Task<IActionResult> CreateSupplier([FromBody] Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                await _supplierService.CreateSupplier(supplier);
            }

            return Created($"api/supplierService", null);
        }

        ///<summary>This PUT method updates the Supplier with the given id </summary>
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

        /// <summary>This DELETE method deletes the Supplier with the given id </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier(Guid id)
        {
            await _supplierService.DeleteSupplier(id);
            return NoContent();
        }
    }
}

