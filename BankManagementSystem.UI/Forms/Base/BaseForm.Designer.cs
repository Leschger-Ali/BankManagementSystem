using BankManagementSystem.UI.AppStyle.Controls;

namespace BankManagementSystem.UI;

partial class BaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        pnlSidebar = new AppPanel();
        btnThemeToggle = new AppButton();
        lblCurrentUhr = new AppLabel();
        lblMainDate = new AppLabel();
        pbBankIcon = new AppPictureBox();
        tmrBaseForm = new System.Windows.Forms.Timer(components);
        btnClose = new AppButton();
        btnMinimize = new AppButton();
        pnlSidebar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbBankIcon).BeginInit();
        SuspendLayout();
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = Color.FromArgb(22, 25, 32);
        pnlSidebar.Controls.Add(btnThemeToggle);
        pnlSidebar.Controls.Add(lblCurrentUhr);
        pnlSidebar.Controls.Add(lblMainDate);
        pnlSidebar.Controls.Add(pbBankIcon);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 0);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Role = AppStyle.Enums.PanelRole.Sidebar;
        pnlSidebar.Size = new Size(251, 667);
        pnlSidebar.TabIndex = 42;
        // 
        // btnThemeToggle
        // 
        btnThemeToggle.BackColor = Color.FromArgb(22, 25, 32);
        btnThemeToggle.BackgroundImageLayout = ImageLayout.None;
        btnThemeToggle.FlatStyle = FlatStyle.Flat;
        btnThemeToggle.Image = Properties.Resources.moony_32;
        btnThemeToggle.Location = new Point(12, 12);
        btnThemeToggle.Name = "btnThemeToggle";
        btnThemeToggle.Role = AppStyle.Enums.ButtonRole.Custom;
        btnThemeToggle.Size = new Size(49, 40);
        btnThemeToggle.TabIndex = 43;
        btnThemeToggle.UseVisualStyleBackColor = false;
        btnThemeToggle.Click += btnThemeToggle_Click;
        // 
        // lblCurrentUhr
        // 
        lblCurrentUhr.AutoSize = true;
        lblCurrentUhr.BackColor = Color.FromArgb(22, 25, 32);
        lblCurrentUhr.ForeColor = Color.FromArgb(229, 196, 131);
        lblCurrentUhr.Location = new Point(83, 467);
        lblCurrentUhr.Name = "lblCurrentUhr";
        lblCurrentUhr.Role = AppStyle.Enums.LabelRole.Custom;
        lblCurrentUhr.Size = new Size(90, 20);
        lblCurrentUhr.TabIndex = 44;
        lblCurrentUhr.Text = "appLabel2";
        // 
        // lblMainDate
        // 
        lblMainDate.AutoSize = true;
        lblMainDate.BackColor = Color.FromArgb(22, 25, 32);
        lblMainDate.ForeColor = Color.FromArgb(229, 196, 131);
        lblMainDate.Location = new Point(45, 432);
        lblMainDate.Name = "lblMainDate";
        lblMainDate.Role = AppStyle.Enums.LabelRole.Custom;
        lblMainDate.Size = new Size(171, 20);
        lblMainDate.TabIndex = 43;
        lblMainDate.Text = "Mitwoch, 01.03.2026";
        // 
        // pbBankIcon
        // 
        pbBankIcon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pbBankIcon.BackColor = Color.FromArgb(22, 25, 32);
        pbBankIcon.Image = Properties.Resources.Lumina_Bank;
        pbBankIcon.Location = new Point(38, 178);
        pbBankIcon.Name = "pbBankIcon";
        pbBankIcon.Role = AppStyle.Enums.PictureBoxRole.Custom;
        pbBankIcon.Size = new Size(185, 195);
        pbBankIcon.SizeMode = PictureBoxSizeMode.Zoom;
        pbBankIcon.TabIndex = 0;
        pbBankIcon.TabStop = false;
        pbBankIcon.Click += pbBankIcon_Click;
        // 
        // tmrBaseForm
        // 
        tmrBaseForm.Enabled = true;
        tmrBaseForm.Interval = 1000;
        tmrBaseForm.Tick += tmrBaseForm_Tick;
        // 
        // btnClose
        // 
        btnClose.BackColor = Color.FromArgb(30, 30, 30);
        btnClose.BackgroundImageLayout = ImageLayout.None;
        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.Image = Properties.Resources.close_32_gold;
        btnClose.Location = new Point(1065, 12);
        btnClose.Name = "btnClose";
        btnClose.Role = AppStyle.Enums.ButtonRole.Custom;
        btnClose.Size = new Size(49, 40);
        btnClose.TabIndex = 45;
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Click += btnClose_Click;
        // 
        // btnMinimize
        // 
        btnMinimize.BackColor = Color.FromArgb(30, 30, 30);
        btnMinimize.BackgroundImageLayout = ImageLayout.None;
        btnMinimize.FlatStyle = FlatStyle.Flat;
        btnMinimize.Image = Properties.Resources.minimize_miite;
        btnMinimize.Location = new Point(1001, 12);
        btnMinimize.Name = "btnMinimize";
        btnMinimize.Role = AppStyle.Enums.ButtonRole.Custom;
        btnMinimize.Size = new Size(49, 40);
        btnMinimize.TabIndex = 46;
        btnMinimize.UseVisualStyleBackColor = false;
        btnMinimize.Click += btnMinimize_Click;
        // 
        // BaseForm
        // 
        AutoScaleDimensions = new SizeF(10F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(30, 30, 30);
        ClientSize = new Size(1126, 667);
        Controls.Add(btnMinimize);
        Controls.Add(btnClose);
        Controls.Add(pnlSidebar);
        Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ForeColor = SystemColors.WindowText;
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4, 3, 4, 3);
        Name = "BaseForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Base Form";
        pnlSidebar.ResumeLayout(false);
        pnlSidebar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pbBankIcon).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private System.Windows.Forms.Timer tmrBaseForm;
    protected AppButton btnClose;
    protected AppButton btnMinimize;
    protected AppButton btnThemeToggle;
    protected AppPictureBox pbBankIcon;
    protected AppLabel lblMainDate;
    protected AppLabel lblCurrentUhr;
    protected AppPanel pnlSidebar;
}
    

