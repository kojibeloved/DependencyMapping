using DependencyMapping.Client.Components;

namespace DependencyMapping.Client.Models
{
    public class CustomFunction : IEntity
    {
        
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public List<Guid> DependencyIds { get; set; }
        
        public Dictionary<Guid, Connector> Connectors { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Size { get; set; }
        public void ShowDependencies()
        {
            foreach (var connector in Connectors)
            {
                connector.Value.ShowDependency();
            }
        }

        public void HideDependencies()
        {
            foreach (var connector in Connectors)
            {
                connector.Value.HideDependency();
            }
        }

        public CustomFunction(Guid id, string name, double x, double y, int size)
        {
            Id = id;
            Name = name;
            X = x;
            Y = y;
            Size = size;
            DependencyIds = new();
            Connectors = new ();
        }
    }
}