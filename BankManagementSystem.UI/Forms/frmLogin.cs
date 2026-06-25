namespace BankManagementSystem.UI.Forms;

public partial class frmLogin : BaseForm
{
    public frmLogin()
    {
        InitializeComponent();
    }

    private void frmLogin_Load(object sender, EventArgs e)
    {

    }

    private void btnTogglePassword_Click(object sender, EventArgs e)
    {
        if (txtPassword.UseSystemPasswordChar)
        {
            txtPassword.UseSystemPasswordChar = false;


            btnTogglePassword.Image = Properties.Resources.visibility_28;
        }
        else
        {
            txtPassword.UseSystemPasswordChar = true;


            btnTogglePassword.Image = Properties.Resources.visibility_off;
        }
    }

    // Event handler for the Leave event of the username TextBox
    private void txtUserName_Leave(object sender, EventArgs e)
    {
        ValidateUsername();
    }

    private void txtUserName_TextChanged(object sender, EventArgs e)
    {
        if (IsValidUsername(txtUserName.Text))
            ClearUsernameError();
    }

    private bool ValidateUsername()
    {
        string username = txtUserName.Text.Trim();

        if (string.IsNullOrWhiteSpace(username))
        {
            ShowUsernameError("Username is required.");
            return false;
        }

        if (!IsValidUsername(username))
        {
            ShowUsernameError("Username must be between 2 and 25 characters.");
            return false;
        }

        ClearUsernameError();
        return true;
    }

    private bool IsValidUsername(string username)
    {
        username = username.Trim();

        return username.Length >= 2 && username.Length <= 25;
    }

    private void ShowUsernameError(string message)
    {
        lblUsernameError.Text = message;
        lblUsernameError.Visible = true;
    }

    private void ClearUsernameError()
    {
        lblUsernameError.Text = string.Empty;
        lblUsernameError.Visible = false;
    }


    // Event handler for the Leave event of the password TextBox

    private bool ValidatePassword()
    {
        string password = txtPassword.Text.Trim();

        if (string.IsNullOrWhiteSpace(password))
        {
            ShowPasswordError("Password is required.");
            return false;
        }

        if (!IsValidPassword(password))
        {
            ShowPasswordError("Password must be between 6 and 20 characters.");
            return false;
        }

        ClearPasswordError();
        return true;
    }
    private bool IsValidPassword(string password)
    {
        password = password.Trim();
        if (string.IsNullOrWhiteSpace(password))
            return false;
        return password.Length >= 6 && password.Length <= 20;
    }
    private void ShowPasswordError(string messege)
    {
        lblPassword.Text = messege;
        lblPassword.Visible = true;

    }
    private void ClearPasswordError()
    {
        lblPassword.Text = string.Empty;
        lblPassword.Visible = false;
    }

    private void txtPassword_TextChanged(object sender, EventArgs e)
    {
        if (IsValidPassword(txtPassword.Text))
            ClearPasswordError();
    }

    private void txtPassword_Leave(object sender, EventArgs e)
    {
        ValidatePassword();
    }





}

