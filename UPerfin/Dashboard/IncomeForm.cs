using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPerfin.Models;

namespace UPerfin.Dashboard
{
    public partial class IncomeForm : MainForm
    {
        private readonly uperfindbEntities _context = new uperfindbEntities();
        private bool _ShowEntirePeriod = true;
        private bool _HideTransactionsOlderThanWeek = false;
        private bool _HideTransactionsOlderThanMonth = false;
        private bool _HideTransactionsOlderThan3Months = false;
        private bool _HideTransactionsOlderThan12Months = false;

        public IncomeForm()
        {
            InitializeComponent();
        }

        public IncomeForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void UpdateDataGridView()
        {
            var result = _context.Income.Where(income => income.UserId == userId);
            if (_HideTransactionsOlderThanWeek) result = result.Where(income => (SqlFunctions.DatePart("dayofyear", DateTime.Now) - SqlFunctions.DatePart("dayofyear", income.IncomeDate)) >= 0);
            if (_HideTransactionsOlderThanMonth) result = result.Where(income => (SqlFunctions.DatePart("dayofyear", DateTime.Now) - SqlFunctions.DatePart("dayofyear", income.IncomeDate)) >= 0);
            if (_HideTransactionsOlderThan3Months) result = result.Where(income => (SqlFunctions.DatePart("dayofyear", DateTime.Now) - SqlFunctions.DatePart("dayofyear", income.IncomeDate)) >= 0);
            if (_HideTransactionsOlderThan12Months) result = result.Where(income => (SqlFunctions.DatePart("dayofyear", DateTime.Now) - SqlFunctions.DatePart("dayofyear", income.IncomeDate)) >= 0);
            if (_ShowEntirePeriod) result = result.Where(income => (SqlFunctions.DatePart("dayofyear", DateTime.Now) - SqlFunctions.DatePart("dayofyear", income.IncomeDate)) >= 0);
            IncomesDataGridView.DataSource = result.ToList();
        }

        private void UpdateTimeFilters()
        {
            _ShowEntirePeriod = EntirePeriodRadioButton.Checked;
            _HideTransactionsOlderThanWeek = LastWeekRadioButton.Checked;
            _HideTransactionsOlderThanMonth = LastMonthRadioButton.Checked;
            _HideTransactionsOlderThan3Months = Last3MonthsRadioButton.Checked;
            _HideTransactionsOlderThan12Months = Last12MonthsRadioButton.Checked;
        }

        private void AddIncomeToDatabase(Income income)
        {
            _context.Income.Add(income);
            _context.SaveChanges();
            UpdateDataGridView();
        }

        private Income ValidateIncomeCreation()
        {
            try
            {
                Income income = new Income
                {
                    UserId = userId,
                    IncomeName = IncomeNameTextBox.Text,
                    IncomeAmount = Decimal.Parse(IncomeAmountTextBox.Text),
                    IncomeDate = DateTime.Now,
                };

                ErrorLabel.Text = "";
                return income;
            }
            catch (FormatException exc)
            {
                ErrorLabel.Text = "Invalid format of provided data!";
                return null;
            }
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            this.incomeTableAdapter.Fill(this.uperfinDbDataSet.Income);
            UpdateDataGridView();
            EntirePeriodRadioButton.Checked = true;
        }

        private void OlderThanWeek_Click(object sender, EventArgs e)
        {
            UpdateTimeFilters();
            UpdateDataGridView();
        }

        private void OlderThanMonth_Click(object sender, EventArgs e)
        {
            UpdateTimeFilters();
            UpdateDataGridView();
        }

        private void OlderThan3Months_Click(object sender, EventArgs e)
        {
            UpdateTimeFilters();
            UpdateDataGridView();
        }

        private void OlderThan12Months_Click(object sender, EventArgs e)
        {
            UpdateTimeFilters();
            UpdateDataGridView();
        }

        private void ShowEntirePeriod_Click(object sender, EventArgs e)
        {
            UpdateTimeFilters();
            UpdateDataGridView();
        }

        private void AddTransaction_Click(object sender, EventArgs e)
        {
            Income income = ValidateIncomeCreation();
            if (income != null) AddIncomeToDatabase(income);
            Refresh_Click(sender, e);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            IncomeNameTextBox.Text = "Income Name...";
            IncomeAmountTextBox.Text = "Income Amount...";
            ErrorLabel.Text = "";
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            Income selectedIncome = (Income)IncomesDataGridView.CurrentRow.DataBoundItem;
            _context.Income.Attach(selectedIncome);
            _context.Income.Remove(selectedIncome);
            _context.SaveChanges();
            AddIncomeToDatabase(selectedIncome);
            _context.SaveChanges();
        }

        private void DeleteTransaction_Click(object sender, EventArgs e)
        {
            Income selectedIncome = (Income)IncomesDataGridView.CurrentRow.DataBoundItem;
            _context.Income.Remove(selectedIncome);
            _context.SaveChanges();
            UpdateDataGridView();
        }
    }
}
