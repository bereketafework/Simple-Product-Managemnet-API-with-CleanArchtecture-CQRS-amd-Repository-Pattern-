using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Infrastructure.Repository;
using TaskManagemnt.Application.Commands;

namespace TaskManagemnt.Application.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, bool>
    {
                private readonly IProductRepository _repository;

        public DeleteProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var existingProduct = await _repository.GetByIdAsync(request.Id);

            if (existingProduct == null)
            {
                return false; // Or throw an exception
            }

            await _repository.DeleteAsync(existingProduct);
            return true;
        }
    }
}