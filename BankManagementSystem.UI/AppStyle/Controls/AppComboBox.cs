using BankManagementSystem.UI.AppStyle.Enums;

namespace BankManagementSystem.UI.AppStyle.Controls;

public class AppComboBox : ComboBox
{

    public ComboBoxRole Role { get; set; } = ComboBoxRole.Primary;
}
