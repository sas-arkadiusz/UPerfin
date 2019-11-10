using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPerfin.Models;
using UPerfin.Dashboard;

namespace UPerfin.AuthenticationProcess
{
    public partial class LoginForm : Form
    {
        UserAuthenticator _userAuthenticator = new UserAuthenticator();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void UsernameTextBox_Clicked(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals("Username"))
            {
                usernameTextBox.Text = "";
            }
            usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            usernamePicture.BackgroundImage = Properties.Resources.UserPicture_32x32_Blue;
            usernameUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            passwordPicture.BackgroundImage = Properties.Resources.PasswordPicture_32x32;
            passwordUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            UsernameTextBox_Clicked(sender, e);
        }

        private void UsernameTextBox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SignInButton_Click(sender, e);
            }
        }

        private void PasswordTextBox_Clicked(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Equals("Password"))
            {
                passwordTextBox.Text = "";
            }
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            passwordPicture.BackgroundImage = Properties.Resources.PasswordPicture_32x32_Blue;
            passwordUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            usernamePicture.BackgroundImage = Properties.Resources.UserPicture_32x32;
            usernameUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

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
            if(_userAuthenticator.AuthenticateUser(usernameTextBox.Text, passwordTextBox.Text) != 0)
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("C");
        }
    }
    
}
