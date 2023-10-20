using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Commands
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public string Name { get; set; }

        public DeleteProductCommand(string name)
        {
            Name = name;
        }
    }
}
