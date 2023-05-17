using DependencyMapping.Client.Components;

namespace DependencyMapping.Client.Models
{
    public class Template : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Guid> DependencyIds { get; set; }
        public Dictionary<Guid, Connector> Connectors { get; set; }
        public bool ShowConnections { get; set; } = false;

        public double X { get; set; }
        public double Y { get; set; }
        public double Size { get; set; }
        public void ShowDependencies()
        {
            foreach (var connector in Connectors)
            {
                connector.Value.DisplayState = "display: block;";
            }
        }

        public void HideDependencies()
        {
            foreach (var connector in Connectors)
            {
                connector.Value.DisplayState = "display: none;";
            }
        }
        public Template(Guid id, string name, double x, double y, int size)
        {
            Id = id;
            Name = name;
            X = x;
            Y = y;
            Size = size;
            DependencyIds = new();
            Connectors = new();
        }
    }
}
