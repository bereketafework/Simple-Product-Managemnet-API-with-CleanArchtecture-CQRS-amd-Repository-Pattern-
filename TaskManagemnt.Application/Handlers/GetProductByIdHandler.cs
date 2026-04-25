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
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ProductDTO>
    {
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;

        public GetProductByIdHandler(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

        }
        public async Task<ProductDTO> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
        {
            var Product = await _repo.GetByIdAsync(query.Id);
            //if (Product == null)
            //{
            //    return Notfounf("Product not Found");
            //}
                return _mapper.Map<ProductDTO>(Product);
            }

        }
    }
