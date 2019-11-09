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
    public partial class PasswordLoginForm : LoginForm
    {
        public PasswordLoginForm()
        {
            InitializeComponent();
        }

        private void AnotherSignInOptionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm pinLoginForm = new PinLoginForm();
            pinLoginForm.Closed += (s, args) => this.Close();
            pinLoginForm.Show();
        }
    }
}
