using BankManagementSystem.UI.AppStyle.Enums;

namespace BankManagementSystem.UI.AppStyle.Controls;

public class AppProgressBar : ProgressBar
{

    public ProgressBarRole Role { get; set; } = ProgressBarRole.Primary;
}