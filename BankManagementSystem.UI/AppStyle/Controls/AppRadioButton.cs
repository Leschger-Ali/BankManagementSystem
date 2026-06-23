using BankManagementSystem.AppStyle.Enums;

namespace BankManagementSystem.AppStyle.Controls;

public class AppRadioButton : RadioButton
{
    
    public RadioButtonRole Role { get; set; } = RadioButtonRole.ButtonType;
}