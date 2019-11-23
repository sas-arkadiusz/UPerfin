using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPerfin.AuthenticationProcess;
using UPerfin.Constants;
using UPerfin.Models;
using UPerfin.Services;

namespace UPerfin.Dashboard
{
    public partial class DashboardForm2 : Form
    {
        protected int userId;
        protected User user;

        public DashboardForm2(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            UserService userService = new UserService();
            user = userService.GetElementById(userId);

            Image avatar = UserAvatar.GetAvatar(user.Avatar);
            this.avatarPicture.BackgroundImage = avatar;
        }

        private void Dashboard_OnLoad(object sender, EventArgs e)
        {
            this.helloLabel.Text = "Hello, " + user.Username + "!";
        }

        private void SignOut_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new PasswordLoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
