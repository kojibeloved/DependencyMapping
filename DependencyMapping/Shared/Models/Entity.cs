using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyMapping.Shared.Models
{
    public class Entity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }

        [Required]
        public string? FileName { get; }

        public bool ShowConnections { get; set; } = false;

        public List<Guid> Connections { get; set; }

        public double X { get; set; }
        public double Y { get; set; }
        public double Size { get; set; }

        public Entity(double x, double y, int size)
        {
            X = x;
            Y = y;
            Size = size;
            Connections = new();
        }
    }
}
