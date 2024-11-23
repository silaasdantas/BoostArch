using Api.Features.Customers.Responses;
using MediatR;

namespace Api.Features.Customers.Commands
{
    public class CreateCustomerCommand : IRequest<CustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public CreateCustomerCommand(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
