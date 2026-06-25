namespace BankManagementSystem.UI.Forms
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            groupBox1 = new GroupBox();
            lblPassword = new BankManagementSystem.UI.AppStyle.Controls.AppLabel();
            lblUsernameError = new BankManagementSystem.UI.AppStyle.Controls.AppLabel();
            btnTogglePassword = new BankManagementSystem.UI.AppStyle.Controls.AppButton();
            chkRememberMe = new BankManagementSystem.UI.AppStyle.Controls.AppCheckBox();
            appLabel5 = new BankManagementSystem.UI.AppStyle.Controls.AppLabel();
            appLabel4 = new BankManagementSystem.UI.AppStyle.Controls.AppLabel();
            btnLogin = new BankManagementSystem.UI.AppStyle.Controls.AppButton();
            txtPassword = new BankManagementSystem.UI.AppStyle.Controls.AppTextBox();
            txtUserName = new BankManagementSystem.UI.AppStyle.Controls.AppTextBox();
            appLabel2 = new BankManagementSystem.UI.AppStyle.Controls.AppLabel();
            appLabel1 = new BankManagementSystem.UI.AppStyle.Controls.AppLabel();
            appLabel3 = new BankManagementSystem.UI.AppStyle.Controls.AppLabel();
            lblTimes = new BankManagementSystem.UI.AppStyle.Controls.AppLabel();
            ((System.ComponentModel.ISupportInitialize)pbBankIcon).BeginInit();
            pnlSidebar.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 28, 28);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);
            btnClose.ForeColor = Color.FromArgb(255, 90, 70);
            btnClose.Location = new Point(731, 12);
            btnClose.Role = AppStyle.Enums.ButtonRole.Icon;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 63, 70);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 52);
            btnMinimize.ForeColor = Color.FromArgb(255, 180, 80);
            btnMinimize.Location = new Point(665, 12);
            btnMinimize.Role = AppStyle.Enums.ButtonRole.Icon;
            // 
            // btnThemeToggle
            // 
            btnThemeToggle.FlatAppearance.BorderSize = 0;
            btnThemeToggle.Image = (Image)resources.GetObject("btnThemeToggle.Image");
            // 
            // pbBankIcon
            // 
            pbBankIcon.Location = new Point(12, 184);
            pbBankIcon.Size = new Size(226, 220);
            // 
            // lblMainDate
            // 
            lblMainDate.Location = new Point(12, 432);
            lblMainDate.Size = new Size(204, 21);
            lblMainDate.Text = "Donnerstag, 25.06.2026";
            // 
            // lblCurrentUhr
            // 
            lblCurrentUhr.Location = new Point(69, 467);
            lblCurrentUhr.Size = new Size(75, 21);
            lblCurrentUhr.Text = "10:12:11";
            // 
            // pnlSidebar
            // 
            pnlSidebar.ForeColor = Color.FromArgb(240, 240, 240);
            pnlSidebar.Size = new Size(257, 634);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(lblUsernameError);
            groupBox1.Controls.Add(btnTogglePassword);
            groupBox1.Controls.Add(chkRememberMe);
            groupBox1.Controls.Add(appLabel5);
            groupBox1.Controls.Add(appLabel4);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(appLabel2);
            groupBox1.Controls.Add(appLabel1);
            groupBox1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(229, 196, 131);
            groupBox1.Location = new Point(293, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 420);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Log in to your Account";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Georgia", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Red;
            lblPassword.Location = new Point(51, 252);
            lblPassword.Name = "lblPassword";
            lblPassword.Role = AppStyle.Enums.LabelRole.Custom;
            lblPassword.Size = new Size(22, 16);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "⚠ ";
            lblPassword.Visible = false;
            // 
            // lblUsernameError
            // 
            lblUsernameError.AutoSize = true;
            lblUsernameError.Font = new Font("Georgia", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsernameError.ForeColor = Color.Red;
            lblUsernameError.Location = new Point(51, 143);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Role = AppStyle.Enums.LabelRole.Custom;
            lblUsernameError.Size = new Size(22, 16);
            lblUsernameError.TabIndex = 9;
            lblUsernameError.Text = "⚠ ";
            lblUsernameError.Visible = false;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.Image = Properties.Resources.visibility_off;
            btnTogglePassword.Location = new Point(314, 176);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Role = AppStyle.Enums.ButtonRole.Icon;
            btnTogglePassword.Size = new Size(40, 27);
            btnTogglePassword.TabIndex = 8;
            btnTogglePassword.UseVisualStyleBackColor = true;
            btnTogglePassword.Click += btnTogglePassword_Click;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Location = new Point(51, 288);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Role = AppStyle.Enums.CheckBoxRole.ButtonType;
            chkRememberMe.Size = new Size(165, 28);
            chkRememberMe.TabIndex = 7;
            chkRememberMe.Text = "Remember Me";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // appLabel5
            // 
            appLabel5.AutoSize = true;
            appLabel5.ForeColor = Color.Red;
            appLabel5.Location = new Point(152, 177);
            appLabel5.Name = "appLabel5";
            appLabel5.Role = AppStyle.Enums.LabelRole.Custom;
            appLabel5.Size = new Size(19, 24);
            appLabel5.TabIndex = 6;
            appLabel5.Text = "*";
            // 
            // appLabel4
            // 
            appLabel4.AutoSize = true;
            appLabel4.ForeColor = Color.Red;
            appLabel4.Location = new Point(167, 59);
            appLabel4.Name = "appLabel4";
            appLabel4.Role = AppStyle.Enums.LabelRole.Custom;
            appLabel4.Size = new Size(19, 24);
            appLabel4.TabIndex = 5;
            appLabel4.Text = "*";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(51, 337);
            btnLogin.Name = "btnLogin";
            btnLogin.Role = AppStyle.Enums.ButtonRole.Primary;
            btnLogin.Size = new Size(106, 37);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ButtonFace;
            txtPassword.Location = new Point(51, 209);
            txtPassword.MaxLength = 25;
            txtPassword.Name = "txtPassword";
            txtPassword.Role = AppStyle.Enums.TextBoxRole.Default;
            txtPassword.Size = new Size(303, 30);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.ButtonFace;
            txtUserName.Location = new Point(51, 97);
            txtUserName.Name = "txtUserName";
            txtUserName.Role = AppStyle.Enums.TextBoxRole.Default;
            txtUserName.Size = new Size(303, 30);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += txtUserName_TextChanged;
            txtUserName.Leave += txtUserName_Leave;
            // 
            // appLabel2
            // 
            appLabel2.AutoSize = true;
            appLabel2.Location = new Point(51, 177);
            appLabel2.Name = "appLabel2";
            appLabel2.Role = AppStyle.Enums.LabelRole.Primary;
            appLabel2.Size = new Size(95, 24);
            appLabel2.TabIndex = 1;
            appLabel2.Text = "Password";
            // 
            // appLabel1
            // 
            appLabel1.AutoSize = true;
            appLabel1.Location = new Point(51, 59);
            appLabel1.Name = "appLabel1";
            appLabel1.Role = AppStyle.Enums.LabelRole.Primary;
            appLabel1.Size = new Size(110, 24);
            appLabel1.TabIndex = 0;
            appLabel1.Text = "User Name";
            // 
            // appLabel3
            // 
            appLabel3.AutoSize = true;
            appLabel3.Font = new Font("Georgia", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            appLabel3.ForeColor = Color.IndianRed;
            appLabel3.Location = new Point(344, 45);
            appLabel3.Name = "appLabel3";
            appLabel3.Role = AppStyle.Enums.LabelRole.Custom;
            appLabel3.Size = new Size(258, 35);
            appLabel3.TabIndex = 4;
            appLabel3.Text = "LUMINA BANK";
            // 
            // lblTimes
            // 
            lblTimes.AutoSize = true;
            lblTimes.ForeColor = Color.Red;
            lblTimes.Location = new Point(293, 552);
            lblTimes.Name = "lblTimes";
            lblTimes.Role = AppStyle.Enums.LabelRole.Custom;
            lblTimes.Size = new Size(59, 21);
            lblTimes.TabIndex = 48;
            lblTimes.Text = "Times";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 634);
            Controls.Add(lblTimes);
            Controls.Add(appLabel3);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 10.5F);
            ForeColor = Color.FromArgb(240, 240, 240);
            MaximizeBox = false;
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            Controls.SetChildIndex(pnlSidebar, 0);
            Controls.SetChildIndex(btnClose, 0);
            Controls.SetChildIndex(btnMinimize, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(appLabel3, 0);
            Controls.SetChildIndex(lblTimes, 0);
            ((System.ComponentModel.ISupportInitialize)pbBankIcon).EndInit();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private AppStyle.Controls.AppLabel appLabel2;
        private AppStyle.Controls.AppLabel appLabel1;
        private AppStyle.Controls.AppTextBox txtUserName;
        private AppStyle.Controls.AppTextBox txtPassword;
        private AppStyle.Controls.AppLabel appLabel3;
        private AppStyle.Controls.AppButton btnLogin;
        private AppStyle.Controls.AppLabel appLabel4;
        private AppStyle.Controls.AppLabel appLabel5;
        private AppStyle.Controls.AppCheckBox chkRememberMe;
        private AppStyle.Controls.AppLabel lblTimes;
        private AppStyle.Controls.AppButton btnTogglePassword;
        private AppStyle.Controls.AppLabel lblUsernameError;
        private AppStyle.Controls.AppLabel lblPassword;
    }
}