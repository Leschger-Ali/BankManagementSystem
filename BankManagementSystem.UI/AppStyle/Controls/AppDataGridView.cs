using BankManagementSystem.AppStyle.Enums;

namespace BankManagementSystem.AppStyle.Controls;

public class AppDataGridView : DataGridView
{
    public DataGridViewRole Role { get; set; } = DataGridViewRole.Primary;
}