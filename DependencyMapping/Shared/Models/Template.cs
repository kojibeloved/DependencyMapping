using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DependencyMapping.Shared.Models
{
    public class Template : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get;}
        [Required]
        public string FileName { get;}
        public List<ObjectId>? Connections { get; set; }

        public double X { get; set; }
        public double Y { get; set; }
        public double Size { get; set; }
        public string Color { get; set; }

        public Template(string id, string fileName, double x, double y, int size)
        {
            Id = id;
            FileName = fileName;
            X = x;
            Y = y;
            Size = size;
            Color = "Red";
        }
    }
}