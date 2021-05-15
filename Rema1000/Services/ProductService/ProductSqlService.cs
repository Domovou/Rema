using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rema1000.Data;
using Rema1000.Models;

namespace Rema1000.Services.ProductService
{
    public class ProductSqlService : IProductService
    {
        private readonly Rema1000Context _context;
        private readonly IEnumerable<Product> _products;

        public ProductSqlService(Rema1000Context context)
        {
            _context = context;
            _products = new List<Product>
            {
                new Product
                {
                    Price = 10,
                    ProductId = Guid.NewGuid(),
                    ProductDescription = "test1",
                    ProductName = "MyTest1"
                },
                new Product
                {
                    Price = 20,
                    ProductId = Guid.NewGuid(),
                    ProductDescription = "test2",
                    ProductName = "MyTest2"
                }
            };
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return  _products;
            //return await _context.Products.ToListAsync();
        }

        //public MockRepo()
        //{
        //    makerSpaces = new List<MakerSpace>
        //    {
        //        new MakerSpace{
        //            MakerSpaceId=new Guid(),
        //            MakerSpaceName="FabLab UCL",
        //            /*MakerSpacePostCode="2700",
        //            MakerSpaceCity="CityVille",
        //            MakerSpaceStreet="StreetStreet"*/
        //        },
        //        new MakerSpace{
        //            MakerSpaceId=new Guid(),
        //            MakerSpaceName="BackYardMakerSpace",
        //            /*MakerSpacePostCode="5000",
        //            MakerSpaceCity="SmallCity",
        //            MakerSpaceStreet="TheStreetAle"*/
        //        },
        //        new MakerSpace {
        //            MakerSpaceId = new Guid(),
        //            MakerSpaceName = "A Third one",
        //            /* MakerSpacePostCode="2500",
        //             MakerSpaceCity="BigCity",
        //             MakerSpaceStreet="CarStreet"*/
        //        }
        //    };

            public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByName(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateProduct(Product createNumber)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product updateNumber)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
