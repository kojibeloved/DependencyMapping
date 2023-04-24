
using DependencyMapping.Shared.Models;

namespace DependencyMapping.Client.Components
{
    public class Map
    {
        public readonly List<IEntity> Entities;
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double DistanceBetweenClusters = 50;
        public List<Cluster> Clusters = new();
    }
}
