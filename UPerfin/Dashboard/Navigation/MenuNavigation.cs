using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPerfin.AuthenticationProcess;

namespace UPerfin.Dashboard.Navigation
{
    public class MenuNavigation
    {
        public static void RunDashboardForm(MainForm form, int userId)
        {
            form.Hide();
            DashboardForm dashboardForm = new DashboardForm(userId);
            dashboardForm.Closed += (s, args) => form.Close();
            dashboardForm.Show();
        }

        public static void RunTransactionForm(MainForm form, int userId)
        {
            form.Hide();
            TransactionForm transactionForm = new TransactionForm(userId);
            transactionForm.Closed += (s, args) => form.Close();
            transactionForm.Show();
        }

        public static void SignOutUser(MainForm form)
        {
            form.Hide();
            PasswordLoginForm passwordLoginForm = new PasswordLoginForm();
            passwordLoginForm.Closed += (s, args) => form.Close();
            passwordLoginForm.Show();
        }
    }
}
