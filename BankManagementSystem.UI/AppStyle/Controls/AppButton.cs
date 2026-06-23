using BankManagementSystem.AppStyle.Enums;
namespace BankManagementSystem.AppStyle.Controls;

public class AppButton : Button
{
    public ButtonRole Role { get; set; } = ButtonRole.Primary;
}

