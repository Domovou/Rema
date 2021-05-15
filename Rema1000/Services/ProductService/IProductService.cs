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
        Product GetProductById(int id);
        Product GetProductByName(int id);
        void CreateProduct(Product createProduct);
        void UpdateProduct(Product updateProduct);
        void DeleteProduct(int id);
       // ProductSerialNumbers GetNumberBySerialNumber(Guid number);
    }
}
