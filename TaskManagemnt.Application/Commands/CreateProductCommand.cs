using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagemnt.Application.DTOs;

namespace TaskManagemnt.Application.Commands
{
    public class CreateProductCommand: IRequest<ProductDTO>
    {
        public string? Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
    }
}
