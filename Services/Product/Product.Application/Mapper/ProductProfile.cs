using AutoMapper;
using Product.Core.Entities;
using Product.Grpc.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Mapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Medicine, MedicineModel>().ReverseMap();
        }
    }
}
