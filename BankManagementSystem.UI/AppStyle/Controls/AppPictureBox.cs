using BankManagementSystem.UI.AppStyle.Enums;

namespace BankManagementSystem.UI.AppStyle.Controls;

public class AppPictureBox : PictureBox
{

    public PictureBoxRole Role { get; set; } = PictureBoxRole.Primary;
}