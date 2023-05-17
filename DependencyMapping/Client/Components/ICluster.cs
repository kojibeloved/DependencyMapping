using Microsoft.AspNetCore.Components;

namespace DependencyMapping.Client.Components
{
    public interface ICluster
    {
        public double CenterX { get; set; }
        
        public double CenterY { get; set; }
    }
}
