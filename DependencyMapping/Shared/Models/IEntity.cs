using MongoDB.Bson;
using Blazor.Extensions;
using Blazor.Extensions.Canvas; 
using Blazor.Extensions.Canvas.Canvas2D;
using SharpCompress.Common;

namespace DependencyMapping.Shared.Models
{
    public interface IEntity
    {
        //coordinates
        public double X { get; set; }
        public double Y { get; set; }
        public double Size { get; set; }
        public string Color { get; set; }
        public double SAngle => 0 * Math.PI;
        public double EAngle => 2 * Math.PI;
        //TODO: Maybe make a list pr entity type, Connections to functions, Data Sources and Connected Services
        public List<ObjectId>? Connections { get; set; }

        public async Task DrawEntity(double x, double y, double size, string color, double sAngle, double eAngle, Canvas2DContext context)
        {
            await context.BeginPathAsync();
            await context.SetFillStyleAsync(color);
            await context.SetStrokeStyleAsync("black");
            await context.SetLineWidthAsync(1);
            await context.ArcAsync(x, y, size, sAngle, eAngle);
            await context.StrokeAsync();
            await context.FillAsync();
            //fill should close path by itself
        }
    }
}