using BankManagementSystem.UI.AppStyle.Enums;

namespace BankManagementSystem.UI.AppStyle.Controls;

public class AppCheckBox : CheckBox
{
    public CheckBoxRole Role { get; set; } = CheckBoxRole.ButtonType;
}