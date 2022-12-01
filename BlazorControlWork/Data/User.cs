using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Numerics;

namespace BlazorControlWork.Data
{
    [BsonKnownTypes(typeof(Customer), typeof(Developer), typeof(Designer))]
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }

        public User(string telephone, string email, string password, string login)
        {
            Telephone = telephone;
            Email = email;
            Password = password;
            Login = login;
        }
    }
}
