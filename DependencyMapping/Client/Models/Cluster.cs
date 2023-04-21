using System.Drawing;
using Blazor.Extensions.Canvas.Canvas2D;

namespace DependencyMapping.Client.Models
{
    public class Cluster
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Size { get; set; }

        public string Color = "dark-gray";
        public double SAngle => 0 * Math.PI;
        public double EAngle => 2 * Math.PI;
        

        public async Task DrawCluster(double x, double y, Canvas2DContext context)
        {
            await context.BeginPathAsync();
            await context.SetStrokeStyleAsync(Color);
            await context.ArcAsync(X, Y, Size, SAngle, EAngle);
            await context.StrokeAsync();
            await context.ClosePathAsync();
        }
    }
}
