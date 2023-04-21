namespace DependencyMapping.Client.Components
{
    public class Cluster
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Size { get; set; }

        public string Color = "dark-gray";
        public double SAngle => 0 * Math.PI;
        public double EAngle => 2 * Math.PI;
        
    }
}
