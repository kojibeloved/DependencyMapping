using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace DependencyMapping.Shared.Models
{
    public class CustomFunction
    {
        
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public List<Guid> DependencyIds { get; set; }

        public double X { get; set; }
        public double Y { get; set; }
        public double Size { get; set; }

        public CustomFunction(Guid id, string name, double x, double y, int size)
        {
            Id = id;
            Name = name;
            X = x;
            Y = y;
            Size = size;
            DependencyIds = new();
        }
    }
}