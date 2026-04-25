using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Infrastructure.Persistence;
using TaskManagemnt.Application.DTOs;
using TaskManagemnt.Application.Queries;
using Microsoft.EntityFrameworkCore;

namespace TaskManagemnt.Application.Handlers
{
    public class GetProductBySeachHandler:IRequestHandler<GetProductBySearch, IEnumerable<ProductDTO>>
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public GetProductBySeachHandler(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> Handle(GetProductBySearch request, CancellationToken cancellationToken)
        {
            var query = _context.Products.AsQueryable();
            if(!string.IsNullOrEmpty(request.Search))
            {
                query = query.Where(p => p.Name.Contains(request.Search));
            }

            var products = await query
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }
    }
}