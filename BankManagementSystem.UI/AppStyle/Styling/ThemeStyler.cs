using BankManagementSystem.UI.AppStyle.Controls;
using BankManagementSystem.UI.AppStyle.Enums;
using BankManagementSystem.UI.AppStyle.Theme;

namespace BankManagementSystem.UI.AppStyle.Styling;

public static class ThemeStyler
{
    public static void ApplyTheme(Form form)
    {
        ThemePalette palette = ThemeManager.CurrentPalette;

        form.BackColor = palette.FormBackground;
        form.ForeColor = palette.PrimaryText;

        ApplyThemeToControls(form);
    }

    public static void ApplyTheme(Control parent)
    {
        ApplyThemeToControls(parent);
    }

    private static void ApplyThemeToControls(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            StyleControl(control);

            if (control.HasChildren)
                ApplyThemeToControls(control);
        }
    }

    private static void StyleControl(Control control)
    {
        switch (control)
        {
            case AppButton button:
                StyleAppButton(button);
                break;

            case AppLabel label:
                StyleAppLabel(label);
                break;

            case AppPanel panel:
                StyleAppPanel(panel);
                break;

            case AppTextBox textBox:
                StyleAppTextBox(textBox);
                break;

            case AppComboBox comboBox:
                StyleAppComboBox(comboBox);
                break;

            case AppCheckBox checkBox:
                StyleAppCheckBox(checkBox);
                break;

            case AppRadioButton radioButton:
                StyleAppRadioButton(radioButton);
                break;

            case AppDataGridView dataGridView:
                StyleAppDataGridView(dataGridView);
                break;

            case AppPictureBox pictureBox:
                StyleAppPictureBox(pictureBox);
                break;

            case AppProgressBar progressBar:
                StyleAppProgressBar(progressBar);
                break;

            case UserControl userControl:
                StyleUserControl(userControl);
                break;
        }
    }

    private static void StyleUserControl(UserControl userControl)
    {
        ThemePalette palette = ThemeManager.CurrentPalette;

        userControl.BackColor = palette.UserControlBackground;
        userControl.ForeColor = palette.PrimaryText;
    }

    private static void StyleAppButton(AppButton button)
    {
        ThemePalette palette = ThemeManager.CurrentPalette;

        if (button.Role == ButtonRole.Custom)
            return;

        button.UseVisualStyleBackColor = false;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 1;
        button.ForeColor = palette.ButtonText;

        Color backColor = button.Role switch
        {
            ButtonRole.Primary => palette.PrimaryButton,
            ButtonRole.Secondary => palette.SecondaryButton,
            ButtonRole.Success => palette.SuccessButton,
            ButtonRole.Danger => palette.DangerButton,
            ButtonRole.Warning => palette.WarningButton,
            _ => palette.PrimaryButton
        };

        button.BackColor = backColor;
        button.FlatAppearance.BorderColor = backColor;
        button.FlatAppearance.MouseOverBackColor = palette.HoverBorder;
        button.FlatAppearance.MouseDownBackColor = palette.PrimaryButton;
    }

    private static void StyleAppLabel(AppLabel label)
    {
        ThemePalette palette = ThemeManager.CurrentPalette;

        if (label.Role == LabelRole.Custom)
            return;

        label.BackColor = Color.Transparent;

        label.ForeColor = label.Role switch
        {
            LabelRole.Primary => palette.PrimaryText,
            LabelRole.Secondary => palette.SecondaryText,
            LabelRole.Muted => palette.DisabledText,
            LabelRole.Header => palette.PrimaryText,
            LabelRole.SubHeader => palette.SecondaryText,
            LabelRole.Body => palette.PrimaryText,
            _ => palette.PrimaryText
        };

        label.Font = label.Role switch
        {
            LabelRole.Header => new Font(label.Font.FontFamily, 18f, FontStyle.Bold),
            LabelRole.SubHeader => new Font(label.Font.FontFamily, 13f, FontStyle.Bold),
            LabelRole.Body => new Font(label.Font.FontFamily, 10.5f, FontStyle.Regular),
            _ => label.Font
        };
    }

    private static void StyleAppPanel(AppPanel panel)
    {
        ThemePalette palette = ThemeManager.CurrentPalette;

        if (panel.Role == PanelRole.Custom)
            return;

        panel.BackColor = panel.Role switch
        {
            PanelRole.Background => palette.PanelBackground,
            PanelRole.Sidebar => palette.SidebarBackground,
            PanelRole.Card => palette.CardBackground,
            PanelRole.Surface => palette.PanelBackground,
            _ => palette.PanelBackground
        };

        panel.ForeColor = palette.PrimaryText;
    }

    private static void StyleAppTextBox(AppTextBox textBox)
    {
        ThemePalette palette = ThemeManager.CurrentPalette;

        if (textBox.Role == TextBoxRole.Custom)
            return;

        textBox.BackColor = palette.TextBoxBackground;
        textBox.ForeColor = palette.PrimaryText;
        textBox.BorderStyle = BorderStyle.FixedSingle;
    }

    // CheckBox styling is a bit more complex because we want to make it look like a button, but with toggle behavior.

    private static void StyleAppCheckBox(AppCheckBox checkBox)
    {
        ThemePalette palette = ThemeManager.CurrentPalette;

        if (checkBox.Role == CheckBoxRole.Custom)
            return;

        checkBox.Appearance = Appearance.Button;
        checkBox.FlatStyle = FlatStyle.Flat;
        checkBox.TextAlign = ContentAlignment.MiddleCenter;

        checkBox.BackColor = palette.PanelBackground;
        checkBox.ForeColor = palette.PrimaryText;

        checkBox.FlatAppearance.BorderSize = 1;
        checkBox.FlatAppearance.BorderColor = palette.Border;
        checkBox.FlatAppearance.MouseOverBackColor = palette.CardBackground;
        checkBox.FlatAppearance.CheckedBackColor = palette.PrimaryButton;

        UpdateCheckBoxText(checkBox);

        checkBox.CheckedChanged -= CheckBox_CheckedChanged;
        checkBox.CheckedChanged += CheckBox_CheckedChanged;
    }

    private static void CheckBox_CheckedChanged(object? sender, EventArgs e)
    {
        if (sender is AppCheckBox checkBox)
            UpdateCheckBoxText(checkBox);
    }

    private static void UpdateCheckBoxText(AppCheckBox checkBox)
    {
        string cleanText = checkBox.Text
            .Replace("✓ ", "")
            .Replace("☐ ", "")
            .Trim();

        checkBox.Text = checkBox.Checked
            ? "✓ " + cleanText
            : "☐ " + cleanText;
    }

    // RadioButton styling is similar to CheckBox, but with its own role and appearance settings.
    private static void StyleAppRadioButton(AppRadioButton radioButton)
    {
        ThemePalette palette = ThemeManager.CurrentPalette;

        if (radioButton.Role == RadioButtonRole.Custom)
            return;

        radioButton.Appearance = Appearance.Button;
        radioButton.FlatStyle = FlatStyle.Flat;
        radioButton.TextAlign = ContentAlignment.MiddleCenter;

        radioButton.BackColor = palette.PanelBackground;
        radioButton.ForeColor = palette.PrimaryText;

        radioButton.FlatAppearance.BorderSize = 1;
        radioButton.FlatAppearance.BorderColor = palette.Border;
        radioButton.FlatAppearance.MouseOverBackColor = palette.CardBackground;
        radioButton.FlatAppearance.CheckedBackColor = palette.PrimaryButton;

        UpdateRadioButtonText(radioButton);

        radioButton.CheckedChanged -= RadioButton_CheckedChanged;
        radioButton.CheckedChanged += RadioButton_CheckedChanged;
    }

    private static void RadioButton_CheckedChanged(object? sender, EventArgs e)
    {
        if (sender is AppRadioButton radioButton)
        {
            UpdateRadioButtonText(radioButton);

            if (radioButton.Parent == null)
                return;

            foreach (Control sibling in radioButton.Parent.Controls)
            {
                if (sibling is AppRadioButton otherRadioButton && otherRadioButton != radioButton)
                    UpdateRadioButtonText(otherRadioButton);
            }
        }
    }

    private static void UpdateRadioButtonText(AppRadioButton radioButton)
    {
        string cleanText = radioButton.Text
            .Replace("● ", "")
            .Replace("○ ", "")
            .Trim();

        radioButton.Text = radioButton.Checked
            ? "● " + cleanText
            : "○ " + cleanText;
    }

    // DataGridView styling is more complex due to the need to style headers, rows, and selection states.
    private static void StyleAppDataGridView(AppDataGridView dgv)
    {
        ThemePalette palette = ThemeManager.CurrentPalette;

        if (dgv.Role == DataGridViewRole.Custom)
            return;

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.AllowUserToAddRows = false;
        //dgv.RowHeadersVisible = false;

        dgv.BackgroundColor = palette.GridBackground;
        dgv.ForeColor = palette.PrimaryText;
        dgv.BorderStyle = BorderStyle.FixedSingle;

        dgv.EnableHeadersVisualStyles = false;

        dgv.ColumnHeadersDefaultCellStyle.BackColor = palette.GridHeaderBackground;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = palette.GridHeaderText;
        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = palette.GridHeaderBackground;
        dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = palette.GridHeaderText;

        dgv.RowHeadersDefaultCellStyle.BackColor = palette.GridHeaderBackground;
        dgv.RowHeadersDefaultCellStyle.ForeColor = palette.GridHeaderText;
        dgv.RowHeadersDefaultCellStyle.SelectionBackColor = palette.GridSelection;
        dgv.RowHeadersDefaultCellStyle.SelectionForeColor = palette.ButtonText;

        dgv.DefaultCellStyle.BackColor = palette.TextBoxBackground;
        dgv.DefaultCellStyle.ForeColor = palette.PrimaryText;
        dgv.DefaultCellStyle.SelectionBackColor = palette.GridSelection;
        dgv.DefaultCellStyle.SelectionForeColor = palette.ButtonText;

        dgv.GridColor = palette.Border;

        dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;


    }

    private static void StyleAppPictureBox(AppPictureBox pictureBox)
    {
        ThemePalette palette = ThemeManager.CurrentPalette;

        if (pictureBox.Role == PictureBoxRole.Custom)
            return;

        pictureBox.BackColor = palette.PictureBoxBackground;
        pictureBox.BorderStyle = BorderStyle.None;
    }


    private static void StyleAppProgressBar(AppProgressBar progressBar)
    {
        ThemePalette palette = ThemeManager.CurrentPalette;

        if (progressBar.Role == ProgressBarRole.Custom)
            return;

        progressBar.ForeColor = palette.ProgressBar;
        progressBar.BackColor = palette.PanelBackground;
    }

    // ComboBox styling is a bit more complex due to the need for custom drawing to achieve a consistent look across themes.
    private static void StyleAppComboBox(AppComboBox comboBox)
    {
        ThemePalette palette = ThemeManager.CurrentPalette;

        if (comboBox.Role == ComboBoxRole.Custom)
            return;

        comboBox.BackColor = palette.ComboBoxBackground;
        comboBox.ForeColor = palette.PrimaryText;

        comboBox.FlatStyle = FlatStyle.Flat;
        comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox.DrawMode = DrawMode.OwnerDrawFixed;

        comboBox.DrawItem -= ComboBox_DrawItem;
        comboBox.DrawItem += ComboBox_DrawItem;

        comboBox.SelectionChangeCommitted -= ComboBox_SelectionChangeCommitted;
        comboBox.SelectionChangeCommitted += ComboBox_SelectionChangeCommitted;
    }


    private static void ComboBox_DrawItem(object? sender, DrawItemEventArgs e)
    {
        if (sender is not ComboBox comboBox)
            return;

        if (e.Index < 0)
            return;

        ThemePalette palette = ThemeManager.CurrentPalette;

        bool isDropDownItem = comboBox.DroppedDown;
        bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

        Color backgroundColor = palette.ComboBoxBackground;
        Color textColor = palette.PrimaryText;

        if (isDropDownItem && isSelected)
        {
            backgroundColor = palette.PrimaryButton;
            textColor = palette.ButtonText;
        }

        using Brush backgroundBrush = new SolidBrush(backgroundColor);
        using Brush textBrush = new SolidBrush(textColor);

        e.Graphics.FillRectangle(backgroundBrush, e.Bounds);

        string text = comboBox.Items[e.Index]?.ToString() ?? string.Empty;

        e.Graphics.DrawString(
            text,
            comboBox.Font,
            textBrush,
            e.Bounds
        );

        e.DrawFocusRectangle();
    }

    private static void ComboBox_SelectionChangeCommitted(object? sender, EventArgs e)
    {
        if (sender is ComboBox comboBox)
        {
            comboBox.Parent?.Focus();
            comboBox.Invalidate();
        }
    }





}