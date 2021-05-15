using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.Models
{
    public class Address
    {
        [Key]
        public Guid AddressId { get; set; }

        public string StreetName { get; set; }
        public string City { get; set; }
        public int PostNr { get; set; }

        public Supplier Supplier { get; set; }


    }
}
