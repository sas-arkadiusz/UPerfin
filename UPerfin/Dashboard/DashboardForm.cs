using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPerfin.Constants;
using UPerfin.Models;
using UPerfin.Services;

namespace UPerfin.Dashboard
{
    public partial class DashboardForm : Form
    {
        protected int userId;
        protected User user;

        public DashboardForm(int userId)
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
    }
}
