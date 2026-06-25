using Microsoft.Data.SqlClient;

namespace BankManagementSystem.Data;

public class User
{
    public static bool IsValidUser(string username, string password)
    {
        using SqlConnection connection = new SqlConnection(DataBaseSettings.ConnectionString);

        string query = @"
        SELECT 1
        FROM Users
        WHERE Username = @username
          AND PasswordHash = @password
          AND IsActive = 1";

        using SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@username", username);
        command.Parameters.AddWithValue("@password", password);

        connection.Open();

        object? result = command.ExecuteScalar();

        return result != null;
    }




}