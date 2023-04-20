using DependencyMapping.Shared.Models;

namespace DependencyMapping.Client.Models
{
    public class Map
    {
        public readonly List<IEntity> Entities;
        public double Width { get; private set; }
        public double Height { get; private set; }
        public void Resize(double width, double height) => (Width, Height) = (width, height);
        
    }
}
