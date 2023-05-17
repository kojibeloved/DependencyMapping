using MongoDB.Bson;
using MongoDB.Driver;

namespace DependencyMapping.Shared.Models
{
    //public class DependencyDBContext
    //{
    //    private readonly IMongoDatabase _mongoDatabase;
    //    public DependencyDBContext()
    //    {
    //        string connectionString = "mongodb://K071:vuduu@tenantmockup.1b87ayr.mongodb.net/?retryWrites=true&w=majority";
    //        var settings = MongoClientSettings.FromConnectionString(connectionString);
    //        settings.ServerApi = new ServerApi(ServerApiVersion.V1);
    //        var client = new MongoClient(settings);
    //        _mongoDatabase = client.GetDatabase("TenantData");
    //    }
    //    public IMongoCollection<Template> Templates => _mongoDatabase.GetCollection<Template>("Templates");

    //    public IMongoCollection<CustomFunction> CustomFunctions => _mongoDatabase.GetCollection<CustomFunction>("CustomFunctions");
    //}

}