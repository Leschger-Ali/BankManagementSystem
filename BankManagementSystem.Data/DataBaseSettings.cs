namespace BankManagementSystem.Data;

public class DataBaseSettings
{
    public static string ConnectionString { get; set; } =
        "Server=Leschger\\SQLEXPRESS;" +
        "Database=BankManagementSystemDB;" +
        "Trusted_Connection=True;" +
        "TrustServerCertificate=True;";
}

