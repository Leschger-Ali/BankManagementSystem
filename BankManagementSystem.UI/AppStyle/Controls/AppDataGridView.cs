using BankManagementSystem.UI.AppStyle.Enums;

namespace BankManagementSystem.UI.AppStyle.Controls;

public class AppDataGridView : DataGridView
{
    public DataGridViewRole Role { get; set; } = DataGridViewRole.Primary;
}