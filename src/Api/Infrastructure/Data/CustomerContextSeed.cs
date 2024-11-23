using Api.Domain.Entities;
using MongoDB.Driver;
using System.Text.Json;

namespace Api.Infrastructure.Data
{
    public static class CustomerContextSeed
    {
        public static void SeedData(IMongoCollection<Customer> customerCollection)
        {
            bool checkCustomers = customerCollection.Find(_ => true).Any();
            var path = Path.Combine("Data", "Seeds", "customers.json");
            if (!checkCustomers)
            {
                var customersData = File.ReadAllText(path);
                var customers = JsonSerializer.Deserialize<List<Customer>>(customersData);
                if (customers != null)
                {
                    foreach (var item in customers)
                    {
                        customerCollection.InsertOneAsync(item);
                    }
                }
            }
        }
    }
}
