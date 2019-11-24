using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public TransactionForm()
        {
            InitializeComponent();
        }

        public TransactionForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            Console.WriteLine(this.userId);
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transactionDataSet.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.transactionDataSet.Transaction);

        }

        private void UpdateDataGridView()
        {
            var result = _context.Transaction.Where(transaction => transaction.TransactionAmount >= 0);
            if (_HideFixedOutgoings) result = result.Where(transaction => transaction.IsFixedOutgoing == true);
            TransactionsDataGridView.DataSource = result.ToList();
        }

        private void HideFixedOutgoingsCheckBox_Click(object sender, EventArgs e)
        {
            if(HideFixedOutgoinsCheckBox.Checked) _HideFixedOutgoings = true;
            else _HideFixedOutgoings = false;
            UpdateDataGridView();
        }
    }
}
