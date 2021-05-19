using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rema1000.Models;

namespace Rema1000.Services.CaategoryServices
{
    public interface ICategoryService
    {

        Task<IEnumerable<Category>> GetAllCategory();
        Task<Category> GetCategoryById(int id);
        Task CreateCategory(Category createCategory);
        Task UpdateCategory(Category updateCategory);
        Task DeleteCategory(int id);
    }
}
