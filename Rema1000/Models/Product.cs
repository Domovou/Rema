using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription{ get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int UtininStock { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
        public Supplier ProductSupplier { get; set; }
        public Category ProductCategory { get; set; }

    }
}
