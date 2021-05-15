using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.Models
{
    public class MeasurementUnit
    {
        [Key]
        public Guid MeasurementUnitId { get; set; }

        public string MeasurementName { get; set; }
    }
}
