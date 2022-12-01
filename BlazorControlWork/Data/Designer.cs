using MongoDB.Bson.Serialization.Attributes;
using System.Reflection.Metadata;

namespace BlazorControlWork.Data
{
    public class Designer : User
    {
        [BsonIgnoreIfNull]
        public string Administrant { get; set; }
        [BsonIgnoreIfNull]
        public string MSRN { get; set; }
        [BsonIgnoreIfNull]
        public string TIN { get; set; }
        [BsonIgnoreIfNull]
        public string COR { get; set; }
        [BsonIgnoreIfNull]
        public string Address { get; set; }
        [BsonIgnoreIfNull]
        public string Director { get; set; }
        [BsonIgnoreIfNull]
        public string MainEngineer { get; set; }

        [BsonIgnoreIfNull]
        public List<Project> Projects = new List<Project>();

        public Designer(string telephone, string email, string password, string login) :
            base(telephone, email, password, login)
        {

        }
    }
}
