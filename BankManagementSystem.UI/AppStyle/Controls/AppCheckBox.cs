using BankManagementSystem.AppStyle.Enums;

namespace BankManagementSystem.AppStyle.Controls;

public class AppCheckBox : CheckBox
{
    public CheckBoxRole Role { get; set; } = CheckBoxRole.ButtonType;
}