using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.Models
{
    public class ProductType
    {
        [Key]
        public Guid ProductTypeId { get; set; }
        public string ProductTypeIName { get; set; }
        public string ProductTypeIDescription { get; set; }
        public Category Category { get; set; }
    }
}
