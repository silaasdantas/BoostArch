using Api.Features.Customers.Commands;
using Api.Features.Customers.Responses;
using MediatR;

namespace Api.Features.Assets.UseCases
{
    public class CreateCustomerUseCase : IRequestHandler<CreateCustomerCommand, CustomerResponse>
    {
        public Task<CustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
