using Newtonsoft.Json;
using week8.Pages;

public class UserRepositoryJSON
{
    public static readonly string JSON = "users.json";
    public static List<User> GetUsers()
    {
        if (File.Exists(JSON))
        {
            string userText = File.ReadAllText(JSON);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(userText)!;
            return users;
        }
        return new List<User>();
    }

    public static void AddUser(User user)
    {
        List<User> users = GetUsers();
        users.Add(user);

        string studentText = JsonConvert.SerializeObject(users);
        File.WriteAllText(JSON, studentText);
    }
}