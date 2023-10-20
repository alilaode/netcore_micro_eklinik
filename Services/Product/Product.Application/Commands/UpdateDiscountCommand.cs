using MediatR;
using Product.Grpc.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Commands
{
    public class UpdateDiscountCommand : IRequest<MedicineModel>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
