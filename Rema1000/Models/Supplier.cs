using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.Models
{
    public class Supplier
    {
        public Guid SupplierId { get; set; }
        [Required]
        public string CvrNumber { get; set; }
        [Required]
        public string SupplierName { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string City { get; set; }
        [Required]
        [StringLength(4, MinimumLength = 4)]
        public int PostNr { get; set; }
        public List<Product> SupplierProducts { get; set; }
        public List<ContactPerson> SupplierContactPersons { get; set; }
    }
}
