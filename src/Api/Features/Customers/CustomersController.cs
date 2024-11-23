using Api.Features.Customers.Commands;
using Api.Features.Customers.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.Customer
{
    [Route("customers")]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        //[Route("CreateBasket")]
        //[ProducesResponseType(typeof(ShoppingCartResponse), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<CustomerResponse>> CreateProduct([FromBody] CreateCustomerCommand createCustomerCommand)
        {
            var result = await _mediator.Send(createCustomerCommand);
            return Ok(result);
        }
    }
}
