using BankManagementSystem.UI.AppStyle.Enums;

namespace BankManagementSystem.UI.AppStyle.Controls;

public class AppRadioButton : RadioButton
{
    
    public RadioButtonRole Role { get; set; } = RadioButtonRole.ButtonType;
}