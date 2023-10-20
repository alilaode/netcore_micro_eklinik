using Product.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Repositories
{

    public interface IProductRepository
    {
        Task<Medicine> GetMedicine(string name);
        Task<bool> CreateMedicine(Medicine medicine);
        Task<bool> UpdateMedicine(Medicine medicine, string oldname);
        Task<bool> DeleteMedicine(string name);
    }
}
