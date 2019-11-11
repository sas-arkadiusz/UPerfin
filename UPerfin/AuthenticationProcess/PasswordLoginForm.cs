using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPerfin.Dashboard;

namespace UPerfin.AuthenticationProcess
{
    public partial class PasswordLoginForm : LoginForm
    {
        private UserAuthenticator _userAuthenticator = new UserAuthenticator();

        public PasswordLoginForm()
        {
            InitializeComponent();
        }

        private void UsernameTextBox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SignInButton_Click(sender, e);
            }
        }

        private void PasswordTextBox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SignInButton_Click(sender, e);
            }
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (_userAuthenticator.AuthenticateUser(usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()) != 0)
            {
                this.Hide();
                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Closed += (s, args) => this.Close();
                dashboardForm.Show();
            }
            else
            {
                this.infoLabel.Text = "Wrong username or password!";
            }
        }

        private void SignInButton_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SignInButton_Click(sender, e);
            }
        }

        private void AnotherSignInOptionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm pinLoginForm = new PinLoginForm();
            pinLoginForm.Closed += (s, args) => this.Close();
            pinLoginForm.Show();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            passwordPicture.BackgroundImage = Properties.Resources.PasswordPicture_32x32_Blue;
            passwordUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            usernamePicture.BackgroundImage = Properties.Resources.UserPicture_32x32;
            usernameUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }
    }
}
