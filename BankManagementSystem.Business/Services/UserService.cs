namespace BankManagementSystem.Business.Services;

public class UserService
{
    public static bool IsValidUser(string username, string password)
    {
        return Data.User.IsValidUser(username, password);
    }

}