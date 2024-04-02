using Newtonsoft.Json;
using week8.Pages;

public class UserRepository
{
    static List<User> UserList = new List<User>();
    public static void AddUser(User user)
    {
        UserList.Add(user);
    }
    public static List<User> GetUsers()
    {
        return UserList;
    }
}