using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rema1000.Data;
using Rema1000.Models;

namespace Rema1000.Services.SupplierService
{
    public class SupplierSqlService : ISupplierService
    {
        private readonly Rema1000Context _context;

        public SupplierSqlService(Rema1000Context context)
        {
            _context = context;
        }

       public async Task<IEnumerable<Supplier>> GetAllSuppliers()
        {
            return  await _context.Suppliers.Include(x=>x.SupplierContactPersons).ToListAsync();

        }
        //GetSupplierByTelephone
        public async Task<Supplier> GetSupplierByCvrNumber(string id)
        {
            //   return _products.FirstOrDefault(p => p.ProductId == id);
            return await _context.Suppliers.FirstOrDefaultAsync(s => s.CvrNumber == id);
        }

        
        public async Task CreateSupplier(Supplier supplierToCreate)
        {
            await _context.Suppliers.AddAsync(supplierToCreate);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateSupplier(Supplier supplierToUpdate)
        {
            try
            {
                _context.Suppliers.Update(supplierToUpdate);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong - contact admin");
            }
        }

        public async Task DeleteSupplier(Guid id)
        {
            var deleteSup = await _context.Suppliers.FindAsync(id);
            try
            {
                _context.Suppliers.Remove(deleteSup);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong - contact admin");
            }
        }

    }
}

