using DependencyMapping.Server.Interfaces;
using DependencyMapping.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyMapping.Server.Controllers
{
    [Route("api/[controller]")]
    public class TenantController : Controller
    {
        private readonly ITenantData _tenantData;

        public TenantController(ITenantData tenantData)
        {
            _tenantData = tenantData;
        }

        [HttpGet]
        public IEnumerable<Template> GetTemplates()
        {
            return _tenantData.GetTemplates();
        }

        [HttpGet]
        public IEnumerable<CustomFunction> GetCustomFunctions()
        {
            return _tenantData.GetCustomFunctions();
        }
    }
}