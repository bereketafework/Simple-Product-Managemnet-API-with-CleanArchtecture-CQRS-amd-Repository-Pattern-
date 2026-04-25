using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagemnt.Application.DTOs;

namespace TaskManagemnt.Application.Queries
{
    public class GetAllProductQuery:IRequest<IEnumerable<ProductDTO>>
    {
    }
}
