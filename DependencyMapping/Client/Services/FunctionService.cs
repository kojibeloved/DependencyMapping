using DependencyMapping.Shared.Models;
using MongoDB.Driver;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using CustomFunction = DependencyMapping.Client.Models.CustomFunction;

namespace DependencyMapping.Client.Services
{
    public class FunctionService : IFunctionService
    {
        [Inject] 
        public HttpClient _http { get; set; }
        //private readonly DependencyDBContext _db = new();
        
        public List<CustomFunction> Functions { get; set; }

        public FunctionService(HttpClient http)
        {
            _http = http;
            //foreach (var function in _db.CustomFunctions)
            //{

            //}
            //Functions

        }
        public async Task<List<CustomFunction>> GetFunctions()
        {
            var result = await _http.GetFromJsonAsync<List<CustomFunction>>("api/CustomFunction");
            if (result != null)
                Functions = result;
            return null;
        }
    }
}
