using DependencyMapping.Client.Components;
using DependencyMapping.Client.Models;
using DependencyMapping.Shared.Models;

namespace DependencyMapping.Client.Helpers
{
    public static class ComponentHelper
    {
        //make a archimedean spiral
        public static double PlaceX(double k)
        {
            return double.Sqrt(k) * double.Cos(double.Sqrt(k));
        }

        public static double PlaceY(double k)
        {
            return double.Sqrt(k) * double.Sin(double.Sqrt(k));
        }
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        public static Guid FindEntityOnId(List<Guid> checkList, List<Guid> lookUp)
        {
            Guid matchingKey = checkList.FirstOrDefault(lookUp.Contains);

            return matchingKey;
        }
    }
}
