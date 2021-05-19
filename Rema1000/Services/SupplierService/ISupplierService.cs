using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rema1000.Models;

namespace Rema1000.Services.SupplierService
{
    public interface ISupplierService
    {

        Task<IEnumerable<Supplier>> GetAllSuppliers();
        Task<Supplier> GetSupplierById(Guid id);
        Task CreateSupplier(Supplier createSupplier);
        Task UpdateSupplier(Supplier updateSupplier);
        Task DeleteSupplier(Guid id);
    }
}
