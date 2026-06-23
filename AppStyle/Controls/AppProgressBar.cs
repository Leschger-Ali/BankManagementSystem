using BankManagementSystem.AppStyle.Enums;

namespace BankManagementSystem.AppStyle.Controls;

public class AppProgressBar : ProgressBar
{

    public ProgressBarRole Role { get; set; } = ProgressBarRole.Primary;
}