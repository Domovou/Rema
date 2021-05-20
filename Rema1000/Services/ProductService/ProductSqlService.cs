using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rema1000.Data;
using Rema1000.Models;

namespace Rema1000.Services.ProductService
{
    public class ProductSqlService : IProductService
    {
        private readonly Rema1000Context _context;

        public ProductSqlService(Rema1000Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
           // return  _products;
            return await _context.Products.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductsByCategory(string categoryName)
        {
            List<Product> products = await _context.Products.Include(x=> x.ProductCategory).ToListAsync();
            List<Product> temList = new List<Product>();
            foreach (Product pr in products)
            {
                if (pr.ProductCategory.CategoryName == categoryName)
                {
                    temList.Add(pr);
                }


            }
            return temList;
            //return await _context.Products.Where(p => p.ProductCategory.CategoryName == categoryName);
         //   return await new NotImplementedException();
        }
        public async Task<Product> GetProductById(Guid id)
        {
         //   return _products.FirstOrDefault(p => p.ProductId == id);
         return await  _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public async Task CreateProduct(Product productToCreate)
        {
            await _context.Products.AddAsync(productToCreate);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateProduct( Product productToUpdate)
        {
            try
            {
                _context.Products.Update(productToUpdate);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong - contact admin");
            }
        }

        public async Task DeleteProduct(Guid id)
        {
            var deletePr = await _context.Products.FindAsync(id);
            try
            {
                _context.Products.Remove(deletePr);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong - contact admin");
            }
        }

    }
}
