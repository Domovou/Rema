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
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
      private ICategoryService _categoryService;

            public CategoryController(ICategoryService categoryService)
            {
                _categoryService = categoryService;
            }


            // GET: api/<ProductController>
            [HttpGet]
            public async Task<IEnumerable<Category>> GetCategory()
            {
                return await _categoryService.GetAllCategory();

            }


            // GET api/<ProductController>/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Category>> GetCategoryById(int id)
            {
                return await _categoryService.GetCategoryById(id);
            }

            // GET api/<ProductController>/categoryService/name
         
            // POST api/<ProductController>
            [HttpPost]
            public async Task<IActionResult> CreateCategory([FromBody] Category category)
            {
                if (ModelState.IsValid)
                {
                    await _categoryService.CreateCategory(category);
                }

                return Created($"api/categoryService", null);
            }

            // PUT api/<ProductController>/5
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
            // DELETE api/<ProductController>/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteCategory(int id)
            {
                await _categoryService.DeleteCategory(id);
                return NoContent();
            }
        }
    }

