using BankManagementSystem.AppStyle.Styling;
using BankManagementSystem.AppStyle.Theme;

namespace BankManagementSystem.Forms.Base
{
    public partial class BaseUserControl : UserControl
    {
        public BaseUserControl()
        {
            InitializeComponent();
            Font = new Font("Georgia", 10.5f);

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ApplyBaseUserControlSettings();
            RefreshTheme();
        }
        protected virtual void ApplyBaseUserControlSettings()
        {
            BackColor = ThemeManager.CurrentPalette.UserControlBackground;
            ForeColor = ThemeManager.CurrentPalette.PrimaryText;
        }

        public void RefreshTheme()
        {
            ThemeStyler.ApplyTheme(this);
        }
        private void BaseUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
