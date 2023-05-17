using DependencyMapping.Client.Components;

namespace DependencyMapping.Client.Models
{
    public interface IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<Guid> DependencyIds { get; set; }
        public Dictionary<Guid, Connector> Connectors { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Size { get; set; }

        public void ShowDependencies();
        public void HideDependencies();
    }
}
