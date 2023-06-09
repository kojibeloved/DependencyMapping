﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyMapping.Shared.Models
{
    public class Template
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Guid> DependencyIds { get; set; }
        
        public bool ShowConnections { get; set; } = false;

        public double X { get; set; }
        public double Y { get; set; }
        public double Size { get; set; }

        public Template(Guid id, string name, double x, double y, int size)
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
