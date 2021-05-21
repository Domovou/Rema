using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription{ get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SalesPrice { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal InternalPrice { get; set; }
        [Required]
        public int UnitInStock { get; set; }
        [Required]
        public string MeasurementUnit { get; set; }
        [Required]
        [System.Text.Json.Serialization.JsonIgnore]
        public Supplier ProductSupplier { get; set; }
        [Required]
        [System.Text.Json.Serialization.JsonIgnore]
        public Category ProductCategory { get; set; }

    }
}
