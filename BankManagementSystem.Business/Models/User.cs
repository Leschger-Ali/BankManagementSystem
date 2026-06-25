namespace BankManagementSystem.Business.Models;

public class User
{
    public int UserID { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public int RoleID { get; set; }
    public int? CustomerID { get; set; }
    public int? EmployeeID { get; set; }

    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }



}