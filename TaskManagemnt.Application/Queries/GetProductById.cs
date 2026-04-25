using MediatR;
using TaskManagemnt.Application.DTOs;

namespace TaskManagemnt.Application.Queries
{
    public class GetProductByIdQuery:IRequest<ProductDTO>
    {

        public Guid Id { get; set; }
        public GetProductByIdQuery(Guid id )
        {
            Id = id;
        }
    }
}
