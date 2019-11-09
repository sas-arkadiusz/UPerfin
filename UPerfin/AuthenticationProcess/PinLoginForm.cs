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
    public partial class PinLoginForm : LoginForm
    {
        public PinLoginForm()
        {
            InitializeComponent();
        }

        private void AnotherSignInOptionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm pinLoginForm = new PasswordLoginForm();
            pinLoginForm.Closed += (s, args) => this.Close();
            pinLoginForm.Show();
        }
    }
}
