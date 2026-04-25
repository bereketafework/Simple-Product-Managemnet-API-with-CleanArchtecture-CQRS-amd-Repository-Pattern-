using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Infrastructure.Repository;
using TaskManagemnt.Application.Commands;
using TaskManagemnt.Application.DTOs;

namespace TaskManagemnt.Application.Handlers
{
    public class UpdateProductCommandHandler:IRequestHandler<UpdateProductCommand, ProductDTO>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        public UpdateProductCommandHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ProductDTO> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var existingProduct = await _repository.GetByIdAsync(request.Id);

            if (existingProduct == null)
            {
                return null; // Or throw an exception
            }
            existingProduct.Name = request.Name;
            existingProduct.Price = request.Price;
            existingProduct.Stock = request.Stock;
            await _repository.UpdateAsync(existingProduct);
            return _mapper.Map<ProductDTO>(existingProduct);
        }
    }
}
