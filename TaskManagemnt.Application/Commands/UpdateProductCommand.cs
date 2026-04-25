using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagemnt.Application.DTOs;

namespace TaskManagemnt.Application.Commands
{
    public class UpdateProductCommand:IRequest<ProductDTO>
    {
        public Guid Id { get; set; }
        public UpdateProductCommand(Guid id)
        {
            Id = id;
        }

        public required string Name { get; set; }
        public required int Price { get; set; }
        public int Stock { get; set; }
    }
}
