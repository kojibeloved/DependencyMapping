using DependencyMapping.Shared.Models;
using CustomFunction = DependencyMapping.Client.Models.CustomFunction;

namespace DependencyMapping.Client.Services
{
    public interface IFunctionService
    {
        List<CustomFunction> Functions { get; }

        Task <List<CustomFunction>> GetFunctions();

    }
}
