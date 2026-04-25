using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagemnt.Application.Commands
{
    public class DeleteProductCommand:IRequest<bool>
    {
        public Guid Id { get; set; }
        public DeleteProductCommand(Guid id)
        {
            Id = id;
        }
    }
}
