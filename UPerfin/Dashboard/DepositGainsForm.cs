using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPerfin.Deposits;

namespace UPerfin.Dashboard
{
    public partial class DepositGainsForm : MainForm
    {
        public DepositGainsForm()
        {
            InitializeComponent();
        }

        public DepositGainsForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            decimal result;
            if(IncludeTaxCheckBox.Checked)
            {
                result = DepositsCalculator.CalculateDepositGainWithTax(
                    Decimal.Parse(DepositAmountTextBox.Text),
                    Decimal.Parse(DepositInterestTextBox.Text),
                    int.Parse(DepositTimeInMonthsTextBox.Text));
            }
            else
            {
                result = DepositsCalculator.CalculateDepositGain(
                    Decimal.Parse(DepositAmountTextBox.Text),
                    Decimal.Parse(DepositInterestTextBox.Text),
                    int.Parse(DepositTimeInMonthsTextBox.Text));
            }
            ResultLabel.Visible = true;
            ResultLabel.Text = "Deposit Gain for the provided parameteres is " + Decimal.Round(result, 2) + ".";
        }

        private void ClearInputs_Click(object sender, EventArgs e)
        {
            DepositAmountTextBox.Text = "Deposit Amount...";
            DepositInterestTextBox.Text = "Deposit Interest...";
            DepositTimeInMonthsTextBox.Text = "Deposit Time in Months...";
            IncludeTaxCheckBox.Checked = false;
            ResultLabel.Visible = false;
        }
    }
}
