using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DependencyMapping.Shared.Models
{
    public class CustomFunction
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}