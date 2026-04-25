using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Infrastructure.Repository;
using TaskManagemnt.Application.DTOs;
using TaskManagemnt.Application.Queries;

namespace TaskManagemnt.Application.Handlers
{
    public class GetAllProductHandler : IRequestHandler<GetAllProductQuery, IEnumerable<ProductDTO>> {
    
       private readonly IProductRepository _repo;
        private readonly IMapper _mapper;
        public GetAllProductHandler(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductDTO>> Handle(GetAllProductQuery query, CancellationToken cancellationToken)
        {
            var products = await _repo.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }
    }
}
