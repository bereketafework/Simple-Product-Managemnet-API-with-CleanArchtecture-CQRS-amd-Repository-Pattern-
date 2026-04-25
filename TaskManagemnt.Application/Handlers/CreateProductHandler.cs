using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Domain;
using TaskManagement.Infrastructure.Repository;
using TaskManagemnt.Application.Commands;
using TaskManagemnt.Application.DTOs;

namespace TaskManagemnt.Application.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, ProductDTO>
    {
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;
        public CreateProductHandler(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async  Task<ProductDTO> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = command.Name,
                Price = command.Price,
                Stock = command.Stock,
            };

            await _repo.AddAsync(product);
            return _mapper.Map<ProductDTO>(product);

        }
    }
}
