using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.Models
{
    public class Supplier
    {
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public int PostNr { get; set; }
        public List<Product> SupplierProducts { get; set; }
        public List<ContactPerson> SupplierContactPersons { get; set; }
    }
}
