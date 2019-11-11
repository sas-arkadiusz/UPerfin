using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPerfin.Models;

namespace UPerfin.AuthenticationProcess
{
    public partial class RegisterForm : LoginForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BackPicture_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm passwordLoginForm = new PasswordLoginForm();
            passwordLoginForm.Closed += (s, args) => this.Close();
            passwordLoginForm.Show();
        }

        private void UsernameTextBox_Click(object sender, EventArgs e)
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
            emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            emailPicture.BackgroundImage = Properties.Resources.MailPicture_32x32;
            emailUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            pinTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            pinPicture.BackgroundImage = Properties.Resources.PinPicture_32x32;
            pinUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void EmailTextBox_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text.Equals("Email"))
            {
                emailTextBox.Text = "";
            }
            emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            emailPicture.BackgroundImage = Properties.Resources.MailPicture_32x32_Blue;
            passwordUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));

            passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            passwordPicture.BackgroundImage = Properties.Resources.PasswordPicture_32x32;
            emailUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            usernamePicture.BackgroundImage = Properties.Resources.UserPicture_32x32;
            usernameUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            pinTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            pinPicture.BackgroundImage = Properties.Resources.PinPicture_32x32;
            pinUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Equals("Password"))
            {
                passwordTextBox.Text = "";
            }
            passwordTextBox.PasswordChar = '*';

            passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            passwordPicture.BackgroundImage = Properties.Resources.PasswordPicture_32x32_Blue;
            emailUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));

            emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            emailPicture.BackgroundImage = Properties.Resources.MailPicture_32x32;
            passwordUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            usernamePicture.BackgroundImage = Properties.Resources.UserPicture_32x32;
            usernameUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            pinTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            pinPicture.BackgroundImage = Properties.Resources.PinPicture_32x32;
            pinUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void PinTextBox_Click(object sender, EventArgs e)
        {
            if (pinTextBox.Text.Equals("PIN"))
            {
                pinTextBox.Text = "";
            }
            pinTextBox.PasswordChar = '*';

            pinTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            pinPicture.BackgroundImage = Properties.Resources.PinPicture_32x32_Blue;
            pinUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));

            emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            emailPicture.BackgroundImage = Properties.Resources.MailPicture_32x32;
            passwordUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            usernamePicture.BackgroundImage = Properties.Resources.UserPicture_32x32;
            usernameUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            passwordPicture.BackgroundImage = Properties.Resources.PasswordPicture_32x32;
            emailUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.RegisterUser(
                usernameTextBox.Text.Trim(), 
                emailTextBox.Text.Trim(), 
                passwordTextBox.Text.Trim(), 
                pinTextBox.Text.Trim());
            BackPicture_Click(sender, e);
        }
    }
}
