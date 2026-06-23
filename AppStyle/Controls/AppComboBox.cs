using BankManagementSystem.AppStyle.Enums;

namespace BankManagementSystem.AppStyle.Controls;

public class AppComboBox : ComboBox
{

    public ComboBoxRole Role { get; set; } = ComboBoxRole.Primary;
}
