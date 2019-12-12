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

namespace UPerfin.Dashboard
{
    public partial class SettingsForm : MainForm
    {
        private readonly uperfindbEntities _context = new uperfindbEntities();

        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void AvatarSelectedValueChange(object sender, EventArgs e)
        {
            Image avatar = UserAvatar.GetAvatar(AvatarComboBox.Text.ToLower());
            this.AvatarRoundedPictureBox.BackgroundImage = avatar;
        }

        private void AvatarChange_Submit(object sender, EventArgs e)
        {
            var result = _context.User.Single(u => u.Id == userId);
            if (result != null)
            {
                result.Avatar = AvatarComboBox.Text.ToLower();
                _context.SaveChanges();
            }
            SubmitResultLabel.Text = "Avatar has been successfully changed!";
        }
    }
}
