using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskManagemnt.Application.Commands;
using TaskManagemnt.Application.DTOs;
using TaskManagemnt.Application.Queries;

namespace TaskManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllProductQuery());
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommand command)
        {

            var result = await _mediator.Send(command);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetProductByIdQuery(id));
            if (result == null)
            {
                return NotFound($"Product with ID {id}  not found");
            }

            return Ok(result);
        }
        [HttpPut("/Update/{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateProductCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("ID in the URL does not match ID in the request body.");
            }
            var result = await _mediator.Send(command);
            if (result == null)
            {
                return NotFound($"Product with ID {id} not found");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _mediator.Send(new DeleteProductCommand(id));
            if (!result)
            {
                return NotFound($"Product with ID {id} not found");
            }
            return Ok($"Product with ID {id} deleted successfully");
        }
    }
}