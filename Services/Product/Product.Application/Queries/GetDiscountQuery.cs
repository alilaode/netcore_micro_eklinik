using MediatR;
using Product.Grpc.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Queries
{
    public class GetProductQuery : IRequest<MedicineModel>
    {
        public string Name { get; set; }

        public GetProductQuery(string name)
        {
            Name = name;
        }
    }
}
