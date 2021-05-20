using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription{ get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SalesPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal InternalPrice { get; set; }
        public int UtintInStock { get; set; }
        public string MeasurementUnit { get; set; }
      
        [System.Text.Json.Serialization.JsonIgnore]
        public Supplier ProductSupplier { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Category ProductCategory { get; set; }

    }
}
