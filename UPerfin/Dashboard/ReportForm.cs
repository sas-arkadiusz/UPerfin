using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPerfin.Reports;
using UPerfin.Services;

namespace UPerfin.Dashboard
{
    public partial class ReportForm : MainForm
    {
        private UserService userService = new UserService();
        private TransactionService transactionService = new TransactionService();
        private IncomeService incomeService = new IncomeService();

        public ReportForm()
        {
            InitializeComponent();
        }

        public ReportForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            ReportTextBox.Visible = true;
            String resultReport = GenerateIncomeReport() + GenerateOutcomeReport() + GenerateCategoryOutcomes() + GenerateBalanceReport();
            ReportTextBox.Text = resultReport;
            SerializeToJSONButton.Visible = true;
            WriteToTextFileButton.Visible = true;
        }

        private String GenerateIncomeReport()
        {
            Dictionary<string, decimal> incomeMonthsData = incomeService.GetIncomesByMonth(userId);

            String resultReport = "Income Report\r\n";
            resultReport += "January: " + incomeMonthsData["January"] + "\r\n";
            resultReport += "February: " + incomeMonthsData["February"] + "\r\n";
            resultReport += "March: " + incomeMonthsData["March"] + "\r\n";
            resultReport += "April: " + incomeMonthsData["April"] + "\r\n";
            resultReport += "May: " + incomeMonthsData["May"] + "\r\n";
            resultReport += "June: " + incomeMonthsData["June"] + "\r\n";
            resultReport += "July: " + incomeMonthsData["July"] + "\r\n";
            resultReport += "August: " + incomeMonthsData["August"] + "\r\n";
            resultReport += "September: " + incomeMonthsData["September"] + "\r\n";
            resultReport += "October: " + incomeMonthsData["October"] + "\r\n";
            resultReport += "November: " + incomeMonthsData["November"] + "\r\n";
            resultReport += "December: " + incomeMonthsData["December"] + "\r\n" + "\r\n";

            return resultReport;
        }

        private String GenerateOutcomeReport()
        {
            Dictionary<string, decimal> outcomeMonthsData = transactionService.GetOutcomesByMonth(userId);

            String resultReport = "Outcome Report\r\n";
            resultReport += "January: " + outcomeMonthsData["January"] + "\r\n";
            resultReport += "February: " + outcomeMonthsData["February"] + "\r\n";
            resultReport += "March: " + outcomeMonthsData["March"] + "\r\n";
            resultReport += "April: " + outcomeMonthsData["April"] + "\r\n";
            resultReport += "May: " + outcomeMonthsData["May"] + "\r\n";
            resultReport += "June: " + outcomeMonthsData["June"] + "\r\n";
            resultReport += "July: " + outcomeMonthsData["July"] + "\r\n";
            resultReport += "August: " + outcomeMonthsData["August"] + "\r\n";
            resultReport += "September: " + outcomeMonthsData["September"] + "\r\n";
            resultReport += "October: " + outcomeMonthsData["October"] + "\r\n";
            resultReport += "November: " + outcomeMonthsData["November"] + "\r\n";
            resultReport += "December: " + outcomeMonthsData["December"] + "\r\n" + "\r\n";

            return resultReport;
        }

        private String GenerateCategoryOutcomes()
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

            String resultReport = "Category Outcome Report\r\n";
            resultReport += "Food: " + outcomeCategoriesData["Food"] + "\r\n";
            resultReport += "Health: " + outcomeCategoriesData["Health"] + "\r\n";
            resultReport += "Shopping: " + outcomeCategoriesData["Shopping"] + "\r\n";
            resultReport += "Transport: " + outcomeCategoriesData["Transport"] + "\r\n";
            resultReport += "Bills: " + outcomeCategoriesData["Bills"] + "\r\n";
            resultReport += "Home: " + outcomeCategoriesData["Home"] + "\r\n";
            resultReport += "Entertainment: " + outcomeCategoriesData["Entertainment"] + "\r\n";
            resultReport += "Holidays: " + outcomeCategoriesData["Holidays"] + "\r\n";
            resultReport += "Education: " + outcomeCategoriesData["Education"] + "\r\n";
            resultReport += "Other: " + outcomeCategoriesData["Other"] + "\r\n" + "\r\n";

            return resultReport;
        }

        private String GenerateBalanceReport()
        {
            Dictionary<string, decimal> incomeMonthsData = incomeService.GetIncomesByMonth(userId);
            Dictionary<string, decimal> outcomeMonthsData = transactionService.GetOutcomesByMonth(userId);

            String resultReport = "Balannce Report\r\n";
            resultReport += "January: " + (incomeMonthsData["January"] - outcomeMonthsData["January"]) + "\r\n";
            resultReport += "February: " + (incomeMonthsData["February"] - outcomeMonthsData["February"]) + "\r\n";
            resultReport += "March: " + (incomeMonthsData["March"] - outcomeMonthsData["March"]) + "\r\n";
            resultReport += "April: " + (incomeMonthsData["April"] - outcomeMonthsData["April"]) + "\r\n";
            resultReport += "May: " + (incomeMonthsData["May"] - outcomeMonthsData["May"]) + "\r\n";
            resultReport += "June: " + (incomeMonthsData["June"] - outcomeMonthsData["June"]) + "\r\n";
            resultReport += "July: " + (incomeMonthsData["July"] - outcomeMonthsData["July"]) + "\r\n";
            resultReport += "August: " + (incomeMonthsData["August"] - outcomeMonthsData["August"]) + "\r\n";
            resultReport += "September: " + (incomeMonthsData["September"] - outcomeMonthsData["September"]) + "\r\n";
            resultReport += "October: " + (incomeMonthsData["October"] - outcomeMonthsData["October"]) + "\r\n";
            resultReport += "November: " + (incomeMonthsData["November"] - outcomeMonthsData["November"]) + "\r\n";
            resultReport += "December: " + (incomeMonthsData["December"] - outcomeMonthsData["December"]) + "\r\n" + "\r\n";

            return resultReport;
        }

        private void SerializeToJSON_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.IncomeReport = GenerateIncomeReport();
            report.OutcomeReport = GenerateOutcomeReport();
            report.CategoryOutcomeReport = GenerateCategoryOutcomes();
            report.BalanceReport = GenerateBalanceReport();

            System.IO.File.WriteAllText(@"..\Report.json", JsonConvert.SerializeObject(report));
            WriteInfoLabel.Visible = true;
            WriteInfoLabel.Text = "Report Generated! Located at: UPerfin\\bin\\Report.json.";
        }

        private void WriteToText_Click(object sender, EventArgs e)
        {
            String resultReport = GenerateIncomeReport() + GenerateOutcomeReport() + GenerateCategoryOutcomes() + GenerateBalanceReport();
            System.IO.File.WriteAllText(@"..\Report.txt", resultReport);
            WriteInfoLabel.Visible = true;
            WriteInfoLabel.Text = "Report Generated! Located at: UPerfin\\bin\\Report.txt.";
        }
    }
}
