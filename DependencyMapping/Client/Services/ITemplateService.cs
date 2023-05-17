using DependencyMapping.Shared.Models;
using Template = DependencyMapping.Client.Models.Template;

namespace DependencyMapping.Client.Services
{
    public interface ITemplateService
    {
        List<Template> Templates { get; }

        Task GetTemplates();

    }
}
