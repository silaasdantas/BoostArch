using Api.Domain.Entities;
using MongoDB.Driver;

namespace Api.Infrastructure.Data
{
    public class DbContextMongo : IDbContextMongo
    {
        public IMongoCollection<Customer> Customers { get; }

        public DbContextMongo(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Customers = database.GetCollection<Customer>(configuration.GetValue<string>("DatabaseSettings:CustomersCollection"));

            CustomerContextSeed.SeedData(Customers);
        }
    }
}
