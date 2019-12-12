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
    public partial class DashboardForm : MainForm
    {
        private readonly uperfindbEntities _context = new uperfindbEntities();
        private UserService userService = new UserService();
        private TransactionService transactionService = new TransactionService();
        private IncomeService incomeService = new IncomeService();
        private User user = null;

        public DashboardForm()
        {
            InitializeComponent();
        }

        public DashboardForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void ValidateCategoriesChartData()
        {
            Dictionary<string, decimal> outcomeCategoriesData = transactionService.GetOutcomesByCategory(userId);

            decimal food = outcomeCategoriesData["Food"];
            decimal health = outcomeCategoriesData["Health"];
            decimal shopping = outcomeCategoriesData["Shopping"];
            decimal transport = outcomeCategoriesData["Transport"];
            decimal bills = outcomeCategoriesData["Bills"];
            decimal home = outcomeCategoriesData["Home"];
            decimal entertainment = outcomeCategoriesData["Entertainment"];
            decimal holidays = outcomeCategoriesData["Holidays"];
            decimal education = outcomeCategoriesData["Education"];
            decimal other = outcomeCategoriesData["Other"];

            if (food > 0) OutcomeCategoriesChart.Series["Categories"].Points.AddXY("Food", food);
            if (health > 0) OutcomeCategoriesChart.Series["Categories"].Points.AddXY("Health", health);
            if (shopping > 0) OutcomeCategoriesChart.Series["Categories"].Points.AddXY("Shopping", shopping);
            if (transport > 0) OutcomeCategoriesChart.Series["Categories"].Points.AddXY("Transport", transport);
            if (bills > 0) OutcomeCategoriesChart.Series["Categories"].Points.AddXY("Bills", bills);
            if (home > 0) OutcomeCategoriesChart.Series["Categories"].Points.AddXY("Home", home);
            if (entertainment > 0) OutcomeCategoriesChart.Series["Categories"].Points.AddXY("Entertainment", entertainment);
            if (holidays > 0) OutcomeCategoriesChart.Series["Categories"].Points.AddXY("Holidays", holidays);
            if (education > 0) OutcomeCategoriesChart.Series["Categories"].Points.AddXY("Education", education);
            if (other > 0) OutcomeCategoriesChart.Series["Categories"].Points.AddXY("Other", other);
        }

        private void ValidateOutcomesMonthChartData()
        {
            Dictionary<string, decimal> outcomeMonthsData = transactionService.GetOutcomesByMonth(userId);
            OutcomesMonthChart.Series["Months"].Points.AddXY(1, outcomeMonthsData["January"]);
            OutcomesMonthChart.Series["Months"].Points.AddXY(2, outcomeMonthsData["February"]);
            OutcomesMonthChart.Series["Months"].Points.AddXY(3, outcomeMonthsData["March"]);
            OutcomesMonthChart.Series["Months"].Points.AddXY(4, outcomeMonthsData["April"]);
            OutcomesMonthChart.Series["Months"].Points.AddXY(5, outcomeMonthsData["May"]);
            OutcomesMonthChart.Series["Months"].Points.AddXY(6, outcomeMonthsData["June"]);
            OutcomesMonthChart.Series["Months"].Points.AddXY(7, outcomeMonthsData["July"]);
            OutcomesMonthChart.Series["Months"].Points.AddXY(8, outcomeMonthsData["August"]);
            OutcomesMonthChart.Series["Months"].Points.AddXY(9, outcomeMonthsData["September"]);
            OutcomesMonthChart.Series["Months"].Points.AddXY(10, outcomeMonthsData["October"]);
            OutcomesMonthChart.Series["Months"].Points.AddXY(11, outcomeMonthsData["November"]);
            OutcomesMonthChart.Series["Months"].Points.AddXY(12, outcomeMonthsData["December"]);
        }

        private void ValidateIncomesMonthChartData()
        {
            Dictionary<string, decimal> incomeMonthsData = incomeService.GetIncomesByMonth(userId);
            IncomesMonthChart.Series["Months"].Points.AddXY(1, incomeMonthsData["January"]);
            IncomesMonthChart.Series["Months"].Points.AddXY(2, incomeMonthsData["February"]);
            IncomesMonthChart.Series["Months"].Points.AddXY(3, incomeMonthsData["March"]);
            IncomesMonthChart.Series["Months"].Points.AddXY(4, incomeMonthsData["April"]);
            IncomesMonthChart.Series["Months"].Points.AddXY(5, incomeMonthsData["May"]);
            IncomesMonthChart.Series["Months"].Points.AddXY(6, incomeMonthsData["June"]);
            IncomesMonthChart.Series["Months"].Points.AddXY(7, incomeMonthsData["July"]);
            IncomesMonthChart.Series["Months"].Points.AddXY(8, incomeMonthsData["August"]);
            IncomesMonthChart.Series["Months"].Points.AddXY(9, incomeMonthsData["September"]);
            IncomesMonthChart.Series["Months"].Points.AddXY(10, incomeMonthsData["October"]);
            IncomesMonthChart.Series["Months"].Points.AddXY(11, incomeMonthsData["November"]);
            IncomesMonthChart.Series["Months"].Points.AddXY(12, incomeMonthsData["December"]);
        }

        private void ValidateBalanceMonthChartData()
        {
            Dictionary<string, decimal> incomeMonthsData = incomeService.GetIncomesByMonth(userId);
            Dictionary<string, decimal> outcomeMonthsData = transactionService.GetOutcomesByMonth(userId);
            BalanceMonthsChart.Series["Months"].Points.AddXY(1, incomeMonthsData["January"] - outcomeMonthsData["January"]);
            BalanceMonthsChart.Series["Months"].Points.AddXY(2, incomeMonthsData["February"] - outcomeMonthsData["February"]);
            BalanceMonthsChart.Series["Months"].Points.AddXY(3, incomeMonthsData["March"] - outcomeMonthsData["March"]);
            BalanceMonthsChart.Series["Months"].Points.AddXY(4, incomeMonthsData["April"] - outcomeMonthsData["April"]);
            BalanceMonthsChart.Series["Months"].Points.AddXY(5, incomeMonthsData["May"] - outcomeMonthsData["May"]);
            BalanceMonthsChart.Series["Months"].Points.AddXY(6, incomeMonthsData["June"] - outcomeMonthsData["June"]);
            BalanceMonthsChart.Series["Months"].Points.AddXY(7, incomeMonthsData["July"] - outcomeMonthsData["July"]);
            BalanceMonthsChart.Series["Months"].Points.AddXY(8, incomeMonthsData["August"] - outcomeMonthsData["August"]);
            BalanceMonthsChart.Series["Months"].Points.AddXY(9, incomeMonthsData["September"] - outcomeMonthsData["September"]);
            BalanceMonthsChart.Series["Months"].Points.AddXY(10, incomeMonthsData["October"] - outcomeMonthsData["October"]);
            BalanceMonthsChart.Series["Months"].Points.AddXY(11, incomeMonthsData["November"] - outcomeMonthsData["November"]);
            BalanceMonthsChart.Series["Months"].Points.AddXY(12, incomeMonthsData["December"] - outcomeMonthsData["December"]);
        }

        private void Dashboard_OnLoad(object sender, EventArgs e)
        {
            user = userService.GetElementById(userId);

            // Load User's Avatar
            Image avatar = UserAvatar.GetAvatar(user.Avatar);
            this.avatarPicture.BackgroundImage = avatar;

            // Load User's Name
            this.helloLabel.Text = "Hello, " + user.Username + "!";

            // Load Outcomes by Month
            ValidateOutcomesMonthChartData();

            // Load Incomes by Month
            ValidateIncomesMonthChartData();

            // Load Outcomes by Category
            ValidateCategoriesChartData();

            // Load Balance by Month
            ValidateBalanceMonthChartData();
        }
    }
}
