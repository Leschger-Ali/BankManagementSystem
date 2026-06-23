using BankManagementSystem.UI.AppStyle.Enums;

namespace BankManagementSystem.UI.AppStyle.Controls;

public class AppTextBox : TextBox
{

    public TextBoxRole Role { get; set; } = TextBoxRole.Default;
}
