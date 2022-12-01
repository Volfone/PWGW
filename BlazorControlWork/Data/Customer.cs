using MongoDB.Bson.Serialization.Attributes;

namespace BlazorControlWork.Data
{
    public class Customer : User
    {
        [BsonIgnoreIfNull]
        public string Name { get; set; }
        public string Department { get; set; }
        [BsonIgnoreIfNull]
        public string Position { get; set; }

        [BsonIgnoreIfNull]
        public List<Project> ProjectGasification = new List<Project>();

        [BsonIgnoreIfNull]
        public List<Project> ProjectWaterSupply = new List<Project>();

        public Customer(string telephone, string email, string password, string login, string department) :
            base(telephone, email, password, login)
        {
            Department = department;
        }
    }
}
