using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.Models
{
    public class ContactPerson
    {
        [Key] 
        public Guid ContactPersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public Supplier Supplier { get; set; }

    }
}
