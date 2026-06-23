using BankManagementSystem.AppStyle.Enums;

namespace BankManagementSystem.AppStyle.Controls;

public class AppLabel : Label
{

    public LabelRole Role { get; set; } = LabelRole.Primary;
}

