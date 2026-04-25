using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Domain;

namespace TaskManagement.Infrastructure.Repository
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(Guid id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
    }
}
