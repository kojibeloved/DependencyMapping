
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


        public Map()
        {
            
        }

        public void MapCoordinatesOfEntities()
        {

        }

        public void Resize(double width, double height) => (Width, Height) = (width, height);

    }
}
