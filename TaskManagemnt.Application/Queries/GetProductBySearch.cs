using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagemnt.Application.DTOs;

namespace TaskManagemnt.Application.Queries
{
    public class GetProductBySearch:IRequest<IEnumerable<ProductDTO>>

    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? Search { get; set; }
    }
}
