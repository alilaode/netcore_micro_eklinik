using MediatR;
using Product.Grpc.Protos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Product.Application.Commands
{
    public class CreateProductCommand : IRequest<MedicineModel>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}