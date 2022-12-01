using MongoDB.Bson.Serialization.Attributes;

namespace BlazorControlWork.Data
{
    public class ActiveUser
    {
        [BsonIgnoreIfNull]
        public static Project project { get; set; }
        public static User user { get; set; }
        public static bool IsUserActive { get; set; }
    }
}
