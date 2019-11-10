using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPerfin.AuthenticationProcess
{
    public partial class LoginForm : Form
    {
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

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string a = "haslo";
            Console.WriteLine(a.GetHashCode());
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("C");
        }
    }
    
}
