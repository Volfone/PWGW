using MongoDB.Driver;

namespace BlazorControlWork.Data
{
    public class MongoExamples
    {
        public static void AddToDB(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDataBaseArt");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);

        }
        public static List<User> FindAll()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDataBaseArt");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => true).ToList();
            return list;
        }

        public static User Find(string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDataBaseArt");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Login == login).FirstOrDefault();
            return one;
        }

        public static void Replace(string login, User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDataBaseArt");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x.Login == login, user);
        }

        public static void AddProjectToDB(Project project)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDataBaseArt");
            var collection = database.GetCollection<Project>("Project");
            collection.InsertOne(project);
        }

        public static List<User> FindAllDesigners()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDataBaseArt");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => true).ToList();
            var users = new List<User>();
            foreach (var user in list)
            {
                if (user.GetType().Name == "Designer")
                    users.Add(user);
            }
            return users;
        }

        public static List<User> FindAllDeveloper()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDataBaseArt");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => true).ToList();
            var users = new List<User>();
            foreach (var user in list)
            {
                if (user.GetType().Name == "Developer")
                    users.Add(user);
            }
            return users;
        }

        public static void ReplaceProject(string name, Project project)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDataBaseArt");
            var collection = database.GetCollection<Project>("Project");
            collection.ReplaceOne(z => z.Name == name, project);
        }
        public static Project FindProject(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDataBaseArt");
            var collection = database.GetCollection<Project>("Project");
            var one = collection.Find(x => x.Name == name).FirstOrDefault();
            return one;
        }
    }
}
