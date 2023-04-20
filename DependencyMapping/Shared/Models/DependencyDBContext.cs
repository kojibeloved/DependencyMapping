using MongoDB.Driver;

namespace DependencyMapping.Shared.Models
{
    public class DependencyDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;
        public DependencyDBContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = client.GetDatabase("TenantData");
        }
        public IMongoCollection<Template> Templates => _mongoDatabase.GetCollection<Template>("Templates");

        public IMongoCollection<CustomFunction> CustomFunctions => _mongoDatabase.GetCollection<CustomFunction>("CustomFunctions");
    }

}