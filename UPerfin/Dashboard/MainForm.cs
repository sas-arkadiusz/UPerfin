using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPerfin.Dashboard.Navigation;

namespace UPerfin.Dashboard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            MenuNavigation.RunDashboardForm(this);
        }

        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            MenuNavigation.RunTransactionForm(this);
        }

        private void FixedOutgoingsButton_Click(object sender, EventArgs e)
        {

        }

        private void BudgetsButton_Click(object sender, EventArgs e)
        {

        }

        private void SavingPlansButton_Click(object sender, EventArgs e)
        {

        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {

        }

        private void VehicleOperationButton_Click(object sender, EventArgs e)
        {

        }

        private void DepositGainsButton_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            MenuNavigation.SignOutUser(this);
        }
    }
}
