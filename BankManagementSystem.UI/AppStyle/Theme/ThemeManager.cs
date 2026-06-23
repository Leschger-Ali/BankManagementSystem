namespace BankManagementSystem.UI.AppStyle.Theme;

public enum ThemeMode
{
    Light,
    Dark
}

public static class ThemeManager
{
    public static ThemeMode CurrentMode { get; private set; } = ThemeMode.Dark;

    public static ThemePalette CurrentPalette =>
        CurrentMode == ThemeMode.Dark
            ? AppTheme.Dark
            : AppTheme.Light;

    public static void SetTheme(ThemeMode mode)
    {
        CurrentMode = mode;
    }

    public static void SetDarkTheme()
    {
        SetTheme(ThemeMode.Dark);
    }

    public static void SetLightTheme()
    {
        SetTheme(ThemeMode.Light);
    }

    public static void ToggleTheme()
    {
        CurrentMode = CurrentMode == ThemeMode.Dark
            ? ThemeMode.Light
            : ThemeMode.Dark;
    }

    public static bool IsDarkMode()
    {
        return CurrentMode == ThemeMode.Dark;
    }

    public static bool IsLightMode()
    {
        return CurrentMode == ThemeMode.Light;
    }
}