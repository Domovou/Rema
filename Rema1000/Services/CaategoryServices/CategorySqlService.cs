using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rema1000.Data;
using Rema1000.Models;

namespace Rema1000.Services.CaategoryServices
{
    public class CategorySqlService : ICategoryService
    {
        private readonly Rema1000Context _context;

        public CategorySqlService(Rema1000Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategory()
        {
            return await _context.Categories.ToListAsync();
        }


        public async Task<Category> GetCategoryById(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(p => p.CategoryId == id);
        }

        public async Task CreateCategory(Category categoryToCreate)
        {
            await _context.Categories.AddAsync(categoryToCreate);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateCategory(Category categoryToUpdate)
        {
            try
            {
                _context.Categories.Update(categoryToUpdate);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong - contact admin");
            }
        }

        public async Task DeleteCategory(int id)
        {
            var deletePr = await _context.Categories.FindAsync(id);
            try
            {
                _context.Categories.Remove(deletePr);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong - contact admin");
            }
        }

    }
}
