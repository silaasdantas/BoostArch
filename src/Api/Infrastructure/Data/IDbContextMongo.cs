using Api.Domain.Entities;
using MongoDB.Driver;

namespace Api.Infrastructure.Data
{
    public interface IDbContextMongo
    {
        IMongoCollection<Customer> Customers { get; }
    }
}
