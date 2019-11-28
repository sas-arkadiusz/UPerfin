using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPerfin.Models;

namespace UPerfin.Dashboard
{
    public partial class TransactionForm : MainForm
    {
        private readonly uperfindbEntities _context = new uperfindbEntities();
        private bool _HideFixedOutgoings = false;
        private bool _HideCategoryFood = false;
        private bool _HideCategoryHealthAndMedical = false;
        private bool _HideCategoryShopping = false;
        private bool _HideCategoryTransport = false;
        private bool _HideCategoryBills = false;
        private bool _HideCategoryHome = false;
        private bool _HideCategoryEntertainment = false;
        private bool _HideCategoryHolidays = false;
        private bool _HideCategoryEducation = false;
        private bool _HideCategoryOther = false;
        private bool _ShowEntirePeriod = true;
        private bool _HideTransactionsOlderThanWeek = false;
        private bool _HideTransactionsOlderThanMonth = false;
        private bool _HideTransactionsOlderThan3Months = false;
        private bool _HideTransactionsOlderThan12Months = false;

        public TransactionForm()
        {
            InitializeComponent();
        }

        public TransactionForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
            EntirePeriodRadioButton.Checked = true;
        }

        private void UpdateDataGridView()
        {
            var result = _context.Transaction.Where(transaction => transaction.UserId == userId);
            if (_HideFixedOutgoings) result = result.Where(transaction => transaction.IsFixedOutgoing == false);
            if (_HideCategoryFood) result = result.Where(transaction => !(transaction.TransactionCategory.Equals(Category.Food.ToString())));
            if (_HideCategoryHealthAndMedical) result = result.Where(transaction => !(transaction.TransactionCategory.Equals(Category.HealthAndMedical.ToString())));
            if (_HideCategoryShopping) result = result.Where(transaction => !(transaction.TransactionCategory.Equals(Category.Shopping.ToString())));
            if (_HideCategoryTransport) result = result.Where(transaction => !(transaction.TransactionCategory.Equals(Category.Transport.ToString())));
            if (_HideCategoryBills) result = result.Where(transaction => !(transaction.TransactionCategory.Equals(Category.Bills.ToString())));
            if (_HideCategoryHome) result = result.Where(transaction => !(transaction.TransactionCategory.Equals(Category.Home.ToString())));
            if (_HideCategoryEntertainment) result = result.Where(transaction => !(transaction.TransactionCategory.Equals(Category.Entertainment.ToString())));
            if (_HideCategoryHolidays) result = result.Where(transaction => !(transaction.TransactionCategory.Equals(Category.Holidays.ToString())));
            if (_HideCategoryEducation) result = result.Where(transaction => !(transaction.TransactionCategory.Equals(Category.Education.ToString())));
            if (_HideCategoryOther) result = result.Where(transaction => !(transaction.TransactionCategory.Equals(Category.Other.ToString())));
            if (_HideTransactionsOlderThanWeek) result = result.Where(transaction => (SqlFunctions.DatePart("dayofyear", DateTime.Now) - SqlFunctions.DatePart("dayofyear", transaction.TransactionDate)) <= 7);
            if (_HideTransactionsOlderThanMonth) result = result.Where(transaction => (SqlFunctions.DatePart("dayofyear", DateTime.Now) - SqlFunctions.DatePart("dayofyear", transaction.TransactionDate)) <= 31);
            if (_HideTransactionsOlderThan3Months) result = result.Where(transaction => (SqlFunctions.DatePart("dayofyear", DateTime.Now) - SqlFunctions.DatePart("dayofyear", transaction.TransactionDate)) <= 93);
            if (_HideTransactionsOlderThan12Months) result = result.Where(transaction => (SqlFunctions.DatePart("dayofyear", DateTime.Now) - SqlFunctions.DatePart("dayofyear", transaction.TransactionDate)) <= 366);
            if (_ShowEntirePeriod) result = result.Where(transaction => (SqlFunctions.DatePart("dayofyear", DateTime.Now) - SqlFunctions.DatePart("dayofyear", transaction.TransactionDate)) >= 0);
            TransactionsDataGridView.DataSource = result.ToList();
        }

        private void UpdateTimeFilters()
        {
            _ShowEntirePeriod = EntirePeriodRadioButton.Checked;
            _HideTransactionsOlderThanWeek = LastWeekRadioButton.Checked;
            _HideTransactionsOlderThanMonth = LastMonthRadioButton.Checked;
            _HideTransactionsOlderThan3Months = Last3MonthsRadioButton.Checked;
            _HideTransactionsOlderThan12Months = Last12MonthsRadioButton.Checked;
        }

        private void HideFixedOutgoingsCheckBox_Click(object sender, EventArgs e)
        {
            if(HideFixedOutgoinsCheckBox.Checked) _HideFixedOutgoings = true;
            else _HideFixedOutgoings = false;
            UpdateDataGridView();
        }

        private void HideCategoryFoodCheckBox_Click(object sender, EventArgs e)
        {
            if (FoodCheckBox.Checked) _HideCategoryFood = true;
            else _HideCategoryFood = false;
            UpdateDataGridView();
        }

        private void HideCategoryHealthAndMedicalCheckBox_Click(object sender, EventArgs e)
        {
            if (HealthAndMedicalCheckBox.Checked) _HideCategoryHealthAndMedical = true;
            else _HideCategoryHealthAndMedical = false;
            UpdateDataGridView();
        }

        private void HideCategoryShoppingCheckBox_Click(object sender, EventArgs e)
        {
            if (ShoppingCheckBox.Checked) _HideCategoryShopping = true;
            else _HideCategoryShopping = false;
            UpdateDataGridView();
        }

        private void HideCategoryTransportCheckBox_Click(object sender, EventArgs e)
        {
            if (TransportCheckBox.Checked) _HideCategoryTransport = true;
            else _HideCategoryTransport = false;
            UpdateDataGridView();
        }

        private void HideCategoryBillsCheckBox_Click(object sender, EventArgs e)
        {
            if (BillsCheckBox.Checked) _HideCategoryBills = true;
            else _HideCategoryBills = false;
            UpdateDataGridView();
        }

        private void HideCategoryHomeCheckBox_Click(object sender, EventArgs e)
        {
            if (HomeCheckBox.Checked) _HideCategoryHome = true;
            else _HideCategoryHome = false;
            UpdateDataGridView();
        }

        private void HideCategoryEntertainmentCheckBox_Click(object sender, EventArgs e)
        {
            if (EntertainmentCheckBox.Checked) _HideCategoryEntertainment = true;
            else _HideCategoryEntertainment = false;
            UpdateDataGridView();
        }

        private void HideCategoryHolidaysCheckBox_Click(object sender, EventArgs e)
        {
            if (HolidaysCheckBox.Checked) _HideCategoryHolidays = true;
            else _HideCategoryHolidays = false;
            UpdateDataGridView();
        }

        private void HideCategoryEducationCheckBox_Click(object sender, EventArgs e)
        {
            if (EducationCheckBox.Checked) _HideCategoryEducation = true;
            else _HideCategoryEducation = false;
            UpdateDataGridView();
        }

        private void HideCategoryOtherCheckBox_Click(object sender, EventArgs e)
        {
            if (OtherCheckBox.Checked) _HideCategoryOther = true;
            else _HideCategoryOther = false;
            UpdateDataGridView();
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
    }
}
