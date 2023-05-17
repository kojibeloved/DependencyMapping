using DependencyMapping.Shared.Models;
using MongoDB.Driver;

namespace DependencyMapping.Server.Services
{
    public class TenantService
    {
        //private IMongoCollection<CustomFunction> _functions;
        //private IMongoCollection<Template> _templates;
        //public TenantService(IConfiguration configuration)
        //{
        //    var client = new MongoClient(configuration.GetConnectionString("MongoDBAtlas"));
        //    var database = client.GetDatabase("TenantData");
        //    _functions = database.GetCollection<CustomFunction>("CustomFunctions");
        //    _templates = database.GetCollection<Template>("Templates");
        //}

        //public List<Template> GetTemplates() => _templates.Find(_ => true).ToList();
        
        //public List<CustomFunction> GetFunctions() => _functions.Find(_ => true).ToList();
    }
}
