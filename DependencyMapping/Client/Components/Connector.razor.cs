using Microsoft.AspNetCore.Components;
using static DependencyMapping.Client.Components.Connector;

namespace DependencyMapping.Client.Components
{
    public class ConnectorClass
    {
        public Direction Dir1 { get; set; }
        public double X1 { get; set; }
        public double Y1 { get; set; }

        public Direction Dir2 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public ConnectorClass(Direction dir1, double x1, double y1, Direction dir2, double x2, double y2)
        {
            Dir1 = dir1;
            X1 = x1;
            Y1 = y1;
            Dir2 = dir2;
            X2 = x2;
            Y2 = y2;
        }
    }
}
