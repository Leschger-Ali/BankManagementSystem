namespace BankManagementSystem.AppStyle.Theme;

public static class AppTheme
{
    public static ThemePalette Dark { get; } = new ThemePalette
    {
        // Backgrounds
        FormBackground = Color.FromArgb(30, 30, 30),
        UserControlBackground = Color.FromArgb(37, 37, 38),
        PanelBackground = Color.FromArgb(45, 45, 48),
        CardBackground = Color.FromArgb(50, 50, 52),

        // Text
        PrimaryText = Color.FromArgb(240, 240, 240),
        SecondaryText = Color.FromArgb(156, 163, 175),
        DisabledText = Color.FromArgb(107, 114, 128),

        // Buttons
        PrimaryButton = Color.FromArgb(0, 122, 204),
        SecondaryButton = Color.FromArgb(71, 85, 105),
        SuccessButton = Color.FromArgb(34, 139, 87),
        DangerButton = Color.FromArgb(220, 38, 38),
        WarningButton = Color.FromArgb(217, 119, 6),
        ButtonText = Color.White,

        // Inputs
        TextBoxBackground = Color.FromArgb(37, 37, 38),
        ComboBoxBackground = Color.FromArgb(37, 37, 38),

        // Borders
        Border = Color.FromArgb(63, 63, 70),
        HoverBorder = Color.FromArgb(28, 151, 234),

        // Sidebar
        //SidebarBackground = Color.FromArgb(15, 23, 42)


        SidebarBackground = Color.FromArgb(22, 25, 32),


        // DataGridView
        GridBackground = Color.FromArgb(45, 45, 48),
        GridHeaderBackground = Color.FromArgb(45, 45, 48),
        GridHeaderText = Color.White,
        GridSelection = Color.FromArgb(0, 122, 204),

        // Misc
        PictureBoxBackground = Color.FromArgb(45, 45, 48),
        ProgressBar = Color.FromArgb(0, 122, 204)
    };

    public static ThemePalette Light { get; } = new ThemePalette
    {
        // Backgrounds
        FormBackground = Color.FromArgb(248, 250, 252),
        UserControlBackground = Color.FromArgb(248, 250, 252),
        PanelBackground = Color.FromArgb(255, 255, 255),
        CardBackground = Color.FromArgb(241, 245, 249),

        // Text
        PrimaryText = Color.FromArgb(15, 23, 42),
        SecondaryText = Color.FromArgb(71, 85, 105),
        DisabledText = Color.FromArgb(148, 163, 184),

        // Buttons
        PrimaryButton = Color.FromArgb(37, 99, 235),
        SecondaryButton = Color.FromArgb(100, 116, 139),
        SuccessButton = Color.FromArgb(22, 163, 74),
        DangerButton = Color.FromArgb(220, 38, 38),
        WarningButton = Color.FromArgb(217, 119, 6),
        ButtonText = Color.White,

        // Inputs
        TextBoxBackground = Color.FromArgb(255, 255, 255),
        ComboBoxBackground = Color.FromArgb(255, 255, 255),

        // Borders
        Border = Color.FromArgb(203, 213, 225),
        HoverBorder = Color.FromArgb(37, 99, 235),

        // Sidebar
        SidebarBackground = Color.FromArgb(15, 23, 42),

        // DataGridView
        GridBackground = Color.FromArgb(255, 255, 255),
        GridHeaderBackground = Color.FromArgb(241, 245, 249),
        GridHeaderText = Color.FromArgb(15, 23, 42),
        GridSelection = Color.FromArgb(37, 99, 235),

        // Misc
        PictureBoxBackground = Color.FromArgb(241, 245, 249),
        ProgressBar = Color.FromArgb(37, 99, 235)
    };

}