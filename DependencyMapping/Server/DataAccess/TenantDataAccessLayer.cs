using DependencyMapping.Server.Interfaces;
using DependencyMapping.Shared.Models;
using MongoDB.Driver;

namespace DependencyMapping.Server.DataAccess
{
    public class TenantDataAccessLayer : ITenantData
    {
        private readonly DependencyDBContext _db;

        public TenantDataAccessLayer(DependencyDBContext _db)
        {
            this._db = _db;
        }
      
        public List<Template> GetTemplates()
        {
            try
            {
                return _db.Templates.Find(_ => true).ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<CustomFunction> GetCustomFunctions()
        {
            try
            {
                return _db.CustomFunctions.Find(_ => true).ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}