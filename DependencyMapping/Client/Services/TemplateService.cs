using DependencyMapping.Shared.Models;
using System.Net.Http.Json;
using Template = DependencyMapping.Client.Models.Template;

namespace DependencyMapping.Client.Services
{
    public class TemplateService : ITemplateService
    {
        private readonly HttpClient _http;
        public List<Template> Templates { get; set; }

        public TemplateService(HttpClient http)
        {
            _http = http;
        }
        public async Task GetTemplates()
        {
            var result = await _http.GetFromJsonAsync<List<Template>>("api/Template");
            if (result != null)
                Templates = result;
        }
    }
    
}
