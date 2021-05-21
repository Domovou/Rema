using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rema1000.Models;
using Rema1000.Services.CaategoryServices;

namespace Rema1000.Controllers
{
    ///<summary>Controller responsible for handling Categories</summary>

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        ///<summary>Gets the collection of all Categories</summary>
        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategory()
        {
            return await _categoryService.GetAllCategory();

        }
        
        ///<summary>Gets the Category by given id </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategoryById(int id)
        {
            return await _categoryService.GetCategoryById(id);
        }

        /// <summary>This POST method creates a new Category </summary>
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] Category category)
        {
            if (ModelState.IsValid)
            {
                await _categoryService.CreateCategory(category);
            }

            return Created($"api/categoryService", null);
        }

        ///<summary> This PUT method updates the Category with the given id </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] Category categoryForUpdate)
        {
            if (id != categoryForUpdate.CategoryId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _categoryService.UpdateCategory(categoryForUpdate);
            }

            return NoContent();
        }

        /// <summary> This DELETE method deletes the product with the given id </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteCategory(id);
            return NoContent();
        }
    }
}

