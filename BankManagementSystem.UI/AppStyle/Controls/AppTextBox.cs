using BankManagementSystem.AppStyle.Enums;

namespace BankManagementSystem.AppStyle.Controls;

public class AppTextBox : TextBox
{

    public TextBoxRole Role { get; set; } = TextBoxRole.Default;
}
