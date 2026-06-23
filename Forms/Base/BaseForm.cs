using BankManagementSystem.AppStyle.Enums;
using BankManagementSystem.AppStyle.Styling;
using BankManagementSystem.AppStyle.Theme;
using System.Runtime.InteropServices;

namespace BankManagementSystem;

public partial class BaseForm : Form
{
    public BaseForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        EnableFormDragging(this);
        this.pnlSidebar.Role = PanelRole.Sidebar;
        ApplyBaseFormSettings();
        tmrBaseForm_Tick(null, null);
        ThemeStyler.ApplyTheme(this);

        ThemeToggleButton();
        CloseAndMinimizeButton();
        UpdateThemeToggleIcon();

    }

    protected virtual void ApplyBaseFormSettings()
    {
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        MinimizeBox = true;
        StartPosition = FormStartPosition.CenterScreen;
        Font = new Font("Georgia", 10.5f);
    }

    protected void RefreshTheme()
    {
        ThemeStyler.ApplyTheme(this);
    }



    private void tmrBaseForm_Tick(object sender, EventArgs e)
    {
        this.lblMainDate.Text = DateTime.Now.ToString("dddd, dd.MM.yyyy", new System.Globalization.CultureInfo("de-DE"));

        this.lblCurrentUhr.Text = DateTime.Now.ToString("HH:mm:ss");
    }

    private void ThemeToggleButton()
    {
        btnThemeToggle.FlatStyle = FlatStyle.Flat;
        btnThemeToggle.FlatAppearance.BorderSize = 0;
        btnThemeToggle.BackColor = pnlSidebar.BackColor;
    }

    private void CloseAndMinimizeButton()
    {
        ThemePalette palette = ThemeManager.CurrentPalette;

        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.FlatAppearance.BorderSize = 0;
        btnClose.UseVisualStyleBackColor = false;
        btnClose.BackColor = palette.FormBackground;
        btnClose.ForeColor = ThemeManager.IsDarkMode()
            ? Color.FromArgb(255, 90, 70)
            : Color.FromArgb(220, 38, 38);

        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);
        btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 28, 28);
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);

        btnMinimize.FlatStyle = FlatStyle.Flat;
        btnMinimize.FlatAppearance.BorderSize = 0;
        btnMinimize.UseVisualStyleBackColor = false;
        btnMinimize.BackColor = palette.FormBackground;
        btnMinimize.ForeColor = ThemeManager.IsDarkMode()
            ? Color.FromArgb(255, 180, 80)
            : Color.FromArgb(100, 116, 139);

        btnMinimize.FlatAppearance.MouseOverBackColor = palette.CardBackground;
        btnMinimize.FlatAppearance.MouseDownBackColor = palette.Border;
    }

    private void UpdateThemeToggleIcon()
    {
        btnThemeToggle.Image = ThemeManager.IsDarkMode()
            ? Properties.Resources.moony_32
            : Properties.Resources.sunny_32;
    }

    private void btnThemeToggle_Click(object sender, EventArgs e)
    {
        ThemeManager.ToggleTheme();

        RefreshTheme();

        ThemeToggleButton();
        CloseAndMinimizeButton();
        UpdateThemeToggleIcon();
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnMinimize_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    // to move the form ↓

    [DllImport("user32.dll")]
    private static extern bool ReleaseCapture();

    [DllImport("user32.dll")]
    private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

    private const int WM_NCLBUTTONDOWN = 0xA1;
    private const int HTCAPTION = 0x2;

    protected void EnableFormDragging(Control dragArea)
    {
        dragArea.MouseDown += DragArea_MouseDown;
    }

    private void DragArea_MouseDown(object? sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left)
            return;

        ReleaseCapture();
        SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
    }

    // to move the form ↑

}