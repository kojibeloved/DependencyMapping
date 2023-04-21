using Blazor.Extensions.Canvas.Canvas2D;
using DependencyMapping.Shared.Models;

namespace DependencyMapping.Client.Models
{
    public class Map
    {
        public readonly List<IEntity> Entities;
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double DistanceBetweenClusters = 50;
        public List<Cluster> Clusters = new ();
        public async Task Resize(double width, double height, Canvas2DContext context)
        {
            (Width, Height) = (width, height);
            await ReDraw(width, height, context);
        }

        public Map(List<IEntity> entities)
        {
            Entities = entities;
        }

        public async Task ReDraw(double width, double height, Canvas2DContext context)
        {
            foreach (var cluster in Clusters)
            {
                await cluster.DrawCluster(width, height, context);
            }
        }

        public void MapCoordinatesOfEntities()
        {

        }
        
    }
}
