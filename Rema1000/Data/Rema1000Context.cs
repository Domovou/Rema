using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rema1000.Models;

namespace Rema1000.Data
{
    public class Rema1000Context : DbContext
    {
        public Rema1000Context(DbContextOptions<Rema1000Context> options): base(options)
        {
             
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public  DbSet<ContactPerson> ContactPersons { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
