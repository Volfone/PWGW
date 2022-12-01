using Microsoft.AspNetCore.Routing;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Numerics;

namespace BlazorControlWork.Data
{
    public class Project
    {
        public Project(string name, string type, User developer, User designer)
        {
            Name = name;
            Type = type;
            Developer = developer;
            Designer = designer;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        public string Name { get; set; }

        public string Type { get; set; }

        public User Developer { get; set; }

        public User Designer { get; set; }


        [BsonIgnoreIfNull]
        public List<DeveloperDocument> Documents = new List<DeveloperDocument>();

        [BsonIgnoreIfNull]
        public List<DesignerDocument> Documentss = new List<DesignerDocument>();
    }
}