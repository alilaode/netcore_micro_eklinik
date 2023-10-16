using Product.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Entities
{
    public class Medicine : EntityBase
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        
    }
}
