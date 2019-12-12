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

        public static void RunSavingForm(MainForm form, int userId)
        {
            form.Hide();
            IncomeForm savingForm = new IncomeForm(userId);
            savingForm.Closed += (s, args) => form.Close();
            savingForm.Show();
        }

        public static void RunReportForm(MainForm form, int userId)
        {
            form.Hide();
            ReportForm reportForm = new ReportForm(userId);
            reportForm.Closed += (s, args) => form.Close();
            reportForm.Show();
        }

        public static void RunVehicleOperationForm(MainForm form, int userId)
        {
            form.Hide();
            VehicleOperationForm vehicleOperationForm = new VehicleOperationForm(userId);
            vehicleOperationForm.Closed += (s, args) => form.Close();
            vehicleOperationForm.Show();
        }

        public static void RunDepositGainsForm(MainForm form, int userId)
        {
            form.Hide();
            DepositGainsForm depositGainsForm = new DepositGainsForm(userId);
            depositGainsForm.Closed += (s, args) => form.Close();
            depositGainsForm.Show();
        }

        public static void RunSettingsForm(MainForm form, int userId)
        {
            form.Hide();
            SettingsForm settingsForm = new SettingsForm(userId);
            settingsForm.Closed += (s, args) => form.Close();
            settingsForm.Show();
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
