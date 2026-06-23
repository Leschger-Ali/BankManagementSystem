using BankManagementSystem.AppStyle.Enums;

namespace BankManagementSystem.AppStyle.Controls;

public class AppPictureBox : PictureBox
{

    public PictureBoxRole Role { get; set; } = PictureBoxRole.Primary;
}