using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rema1000.Models;

namespace Rema1000.Services.ProductService
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<IEnumerable<Product>> GetAllProductsByCategory(string categoryName);
        Task<Product>GetProductById(Guid id);
        Task CreateProduct(Product createProduct);
        Task UpdateProduct(Product updateProduct);
        Task DeleteProduct(Guid id);
    }
}
