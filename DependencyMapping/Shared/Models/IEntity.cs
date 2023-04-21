using MongoDB.Bson;
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

    }
}