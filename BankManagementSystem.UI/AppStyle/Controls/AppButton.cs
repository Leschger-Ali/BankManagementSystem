using BankManagementSystem.UI.AppStyle.Enums;

namespace BankManagementSystem.UI.AppStyle.Controls;

public class AppButton : Button
{
    public ButtonRole Role { get; set; } = ButtonRole.Primary;
}

