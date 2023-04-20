using DependencyMapping.Shared.Models;

namespace DependencyMapping.Server.Interfaces
{
    public interface ITenantData
    {
        public List<Template> GetTemplates();
        public List<CustomFunction> GetCustomFunctions();

    }
}