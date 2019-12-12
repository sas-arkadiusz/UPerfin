namespace UPerfin.Dashboard
{
    partial class IncomeForm : MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EntirePeriodRadioButton = new System.Windows.Forms.RadioButton();
            this.LastWeekRadioButton = new System.Windows.Forms.RadioButton();
            this.Last12MonthsRadioButton = new System.Windows.Forms.RadioButton();
            this.Last3MonthsRadioButton = new System.Windows.Forms.RadioButton();
            this.LastMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.FiltersLabel = new System.Windows.Forms.Label();
            this.ShowTransactionsLabel = new System.Windows.Forms.Label();
            this.IncomesDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IncomeAmountTextBox = new System.Windows.Forms.TextBox();
            this.IncomeNameTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.uperfinDbDataSet = new UPerfin.uperfinDbDataSet();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomeTableAdapter = new UPerfin.uperfinDbDataSetTableAdapters.IncomeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IncomesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uperfinDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardButton
            // 
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            // 
            // TransactionButton
            // 
            this.TransactionButton.FlatAppearance.BorderSize = 0;
            // 
            // SavingPlanButton
            // 
            this.SavingPlanButton.FlatAppearance.BorderSize = 0;
            this.SavingPlanButton.ForeColor = System.Drawing.Color.Black;
            // 
            // ReportButton
            // 
            this.ReportButton.FlatAppearance.BorderSize = 0;
            // 
            // VehicleOperationButton
            // 
            this.VehicleOperationButton.FlatAppearance.BorderSize = 0;
            // 
            // DepositGainButton
            // 
            this.DepositGainButton.FlatAppearance.BorderSize = 0;
            // 
            // SignOutButton
            // 
            this.SignOutButton.FlatAppearance.BorderSize = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            // 
            // EntirePeriodRadioButton
            // 
            this.EntirePeriodRadioButton.AutoSize = true;
            this.EntirePeriodRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EntirePeriodRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EntirePeriodRadioButton.ForeColor = System.Drawing.Color.Black;
            this.EntirePeriodRadioButton.Location = new System.Drawing.Point(690, 151);
            this.EntirePeriodRadioButton.Name = "EntirePeriodRadioButton";
            this.EntirePeriodRadioButton.Size = new System.Drawing.Size(212, 17);
            this.EntirePeriodRadioButton.TabIndex = 60;
            this.EntirePeriodRadioButton.TabStop = true;
            this.EntirePeriodRadioButton.Text = "Show Transactions for the entire period";
            this.EntirePeriodRadioButton.UseVisualStyleBackColor = false;
            this.EntirePeriodRadioButton.Click += new System.EventHandler(this.ShowEntirePeriod_Click);
            // 
            // LastWeekRadioButton
            // 
            this.LastWeekRadioButton.AutoSize = true;
            this.LastWeekRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LastWeekRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastWeekRadioButton.ForeColor = System.Drawing.Color.Black;
            this.LastWeekRadioButton.Location = new System.Drawing.Point(690, 58);
            this.LastWeekRadioButton.Name = "LastWeekRadioButton";
            this.LastWeekRadioButton.Size = new System.Drawing.Size(230, 17);
            this.LastWeekRadioButton.TabIndex = 59;
            this.LastWeekRadioButton.TabStop = true;
            this.LastWeekRadioButton.Text = "Hide Transactions that are older than week";
            this.LastWeekRadioButton.UseVisualStyleBackColor = false;
            this.LastWeekRadioButton.Click += new System.EventHandler(this.OlderThanWeek_Click);
            // 
            // Last12MonthsRadioButton
            // 
            this.Last12MonthsRadioButton.AutoSize = true;
            this.Last12MonthsRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Last12MonthsRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Last12MonthsRadioButton.ForeColor = System.Drawing.Color.Black;
            this.Last12MonthsRadioButton.Location = new System.Drawing.Point(690, 127);
            this.Last12MonthsRadioButton.Name = "Last12MonthsRadioButton";
            this.Last12MonthsRadioButton.Size = new System.Drawing.Size(254, 17);
            this.Last12MonthsRadioButton.TabIndex = 58;
            this.Last12MonthsRadioButton.TabStop = true;
            this.Last12MonthsRadioButton.Text = "Hide Transactions that are older than 12 months";
            this.Last12MonthsRadioButton.UseVisualStyleBackColor = false;
            this.Last12MonthsRadioButton.Click += new System.EventHandler(this.OlderThan12Months_Click);
            // 
            // Last3MonthsRadioButton
            // 
            this.Last3MonthsRadioButton.AutoSize = true;
            this.Last3MonthsRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Last3MonthsRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Last3MonthsRadioButton.ForeColor = System.Drawing.Color.Black;
            this.Last3MonthsRadioButton.Location = new System.Drawing.Point(690, 104);
            this.Last3MonthsRadioButton.Name = "Last3MonthsRadioButton";
            this.Last3MonthsRadioButton.Size = new System.Drawing.Size(243, 17);
            this.Last3MonthsRadioButton.TabIndex = 57;
            this.Last3MonthsRadioButton.TabStop = true;
            this.Last3MonthsRadioButton.Text = "Hide Transactions that are older than 3 month";
            this.Last3MonthsRadioButton.UseVisualStyleBackColor = false;
            this.Last3MonthsRadioButton.Click += new System.EventHandler(this.OlderThan3Months_Click);
            // 
            // LastMonthRadioButton
            // 
            this.LastMonthRadioButton.AutoSize = true;
            this.LastMonthRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LastMonthRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastMonthRadioButton.ForeColor = System.Drawing.Color.Black;
            this.LastMonthRadioButton.Location = new System.Drawing.Point(690, 81);
            this.LastMonthRadioButton.Name = "LastMonthRadioButton";
            this.LastMonthRadioButton.Size = new System.Drawing.Size(235, 17);
            this.LastMonthRadioButton.TabIndex = 56;
            this.LastMonthRadioButton.TabStop = true;
            this.LastMonthRadioButton.Text = "Hide Transactions that are older than month";
            this.LastMonthRadioButton.UseVisualStyleBackColor = false;
            this.LastMonthRadioButton.Click += new System.EventHandler(this.OlderThanMonth_Click);
            // 
            // FiltersLabel
            // 
            this.FiltersLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.FiltersLabel.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FiltersLabel.ForeColor = System.Drawing.Color.White;
            this.FiltersLabel.Location = new System.Drawing.Point(687, 28);
            this.FiltersLabel.Name = "FiltersLabel";
            this.FiltersLabel.Size = new System.Drawing.Size(261, 23);
            this.FiltersLabel.TabIndex = 55;
            this.FiltersLabel.Text = "Filters";
            this.FiltersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowTransactionsLabel
            // 
            this.ShowTransactionsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.ShowTransactionsLabel.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowTransactionsLabel.ForeColor = System.Drawing.Color.White;
            this.ShowTransactionsLabel.Location = new System.Drawing.Point(216, 28);
            this.ShowTransactionsLabel.Name = "ShowTransactionsLabel";
            this.ShowTransactionsLabel.Size = new System.Drawing.Size(447, 23);
            this.ShowTransactionsLabel.TabIndex = 62;
            this.ShowTransactionsLabel.Text = "Transactions";
            this.ShowTransactionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IncomesDataGridView
            // 
            this.IncomesDataGridView.AutoGenerateColumns = false;
            this.IncomesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.incomeNameDataGridViewTextBoxColumn,
            this.incomeAmountDataGridViewTextBoxColumn,
            this.incomeDateDataGridViewTextBoxColumn});
            this.IncomesDataGridView.DataSource = this.incomeBindingSource;
            this.IncomesDataGridView.Location = new System.Drawing.Point(216, 54);
            this.IncomesDataGridView.Name = "IncomesDataGridView";
            this.IncomesDataGridView.Size = new System.Drawing.Size(447, 261);
            this.IncomesDataGridView.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(216, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 70;
            this.label4.Text = "Income Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(216, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Income Name";
            // 
            // IncomeAmountTextBox
            // 
            this.IncomeAmountTextBox.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncomeAmountTextBox.ForeColor = System.Drawing.Color.Black;
            this.IncomeAmountTextBox.Location = new System.Drawing.Point(353, 357);
            this.IncomeAmountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IncomeAmountTextBox.Name = "IncomeAmountTextBox";
            this.IncomeAmountTextBox.Size = new System.Drawing.Size(188, 25);
            this.IncomeAmountTextBox.TabIndex = 68;
            this.IncomeAmountTextBox.Text = "Income Amount...";
            // 
            // IncomeNameTextBox
            // 
            this.IncomeNameTextBox.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncomeNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.IncomeNameTextBox.Location = new System.Drawing.Point(353, 322);
            this.IncomeNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IncomeNameTextBox.Name = "IncomeNameTextBox";
            this.IncomeNameTextBox.Size = new System.Drawing.Size(188, 25);
            this.IncomeNameTextBox.TabIndex = 67;
            this.IncomeNameTextBox.Text = "Income Name...";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button5.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(760, 512);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 54);
            this.button5.TabIndex = 66;
            this.button5.Text = "Delete Selected Transaction";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.DeleteTransaction_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button4.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(216, 512);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 28);
            this.button4.TabIndex = 65;
            this.button4.Text = "Clear Inputs";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button3.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(763, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 35);
            this.button3.TabIndex = 64;
            this.button3.Text = "Save Changes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button1.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(216, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 35);
            this.button1.TabIndex = 63;
            this.button1.Text = "Add Transaction";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddTransaction_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ErrorLabel.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(424, 470);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(239, 35);
            this.ErrorLabel.TabIndex = 71;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uperfinDbDataSet
            // 
            this.uperfinDbDataSet.DataSetName = "uperfinDbDataSet";
            this.uperfinDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataMember = "Income";
            this.incomeBindingSource.DataSource = this.uperfinDbDataSet;
            // 
            // incomeTableAdapter
            // 
            this.incomeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // incomeNameDataGridViewTextBoxColumn
            // 
            this.incomeNameDataGridViewTextBoxColumn.DataPropertyName = "IncomeName";
            this.incomeNameDataGridViewTextBoxColumn.HeaderText = "IncomeName";
            this.incomeNameDataGridViewTextBoxColumn.Name = "incomeNameDataGridViewTextBoxColumn";
            // 
            // incomeAmountDataGridViewTextBoxColumn
            // 
            this.incomeAmountDataGridViewTextBoxColumn.DataPropertyName = "IncomeAmount";
            this.incomeAmountDataGridViewTextBoxColumn.HeaderText = "IncomeAmount";
            this.incomeAmountDataGridViewTextBoxColumn.Name = "incomeAmountDataGridViewTextBoxColumn";
            // 
            // incomeDateDataGridViewTextBoxColumn
            // 
            this.incomeDateDataGridViewTextBoxColumn.DataPropertyName = "IncomeDate";
            this.incomeDateDataGridViewTextBoxColumn.HeaderText = "IncomeDate";
            this.incomeDateDataGridViewTextBoxColumn.Name = "incomeDateDataGridViewTextBoxColumn";
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 578);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IncomeAmountTextBox);
            this.Controls.Add(this.IncomeNameTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowTransactionsLabel);
            this.Controls.Add(this.IncomesDataGridView);
            this.Controls.Add(this.EntirePeriodRadioButton);
            this.Controls.Add(this.LastWeekRadioButton);
            this.Controls.Add(this.Last12MonthsRadioButton);
            this.Controls.Add(this.Last3MonthsRadioButton);
            this.Controls.Add(this.LastMonthRadioButton);
            this.Controls.Add(this.FiltersLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(978, 623);
            this.MinimumSize = new System.Drawing.Size(978, 605);
            this.Name = "IncomeForm";
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.DashboardButton, 0);
            this.Controls.SetChildIndex(this.HeaderLabel, 0);
            this.Controls.SetChildIndex(this.TransactionButton, 0);
            this.Controls.SetChildIndex(this.SavingPlanButton, 0);
            this.Controls.SetChildIndex(this.ReportButton, 0);
            this.Controls.SetChildIndex(this.VehicleOperationButton, 0);
            this.Controls.SetChildIndex(this.CalculatorLabel, 0);
            this.Controls.SetChildIndex(this.DepositGainButton, 0);
            this.Controls.SetChildIndex(this.SignOutButton, 0);
            this.Controls.SetChildIndex(this.SettingsButton, 0);
            this.Controls.SetChildIndex(this.NavigationLabel, 0);
            this.Controls.SetChildIndex(this.FiltersLabel, 0);
            this.Controls.SetChildIndex(this.LastMonthRadioButton, 0);
            this.Controls.SetChildIndex(this.Last3MonthsRadioButton, 0);
            this.Controls.SetChildIndex(this.Last12MonthsRadioButton, 0);
            this.Controls.SetChildIndex(this.LastWeekRadioButton, 0);
            this.Controls.SetChildIndex(this.EntirePeriodRadioButton, 0);
            this.Controls.SetChildIndex(this.IncomesDataGridView, 0);
            this.Controls.SetChildIndex(this.ShowTransactionsLabel, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.IncomeNameTextBox, 0);
            this.Controls.SetChildIndex(this.IncomeAmountTextBox, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.ErrorLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.IncomesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uperfinDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.RadioButton EntirePeriodRadioButton;
        private System.Windows.Forms.RadioButton LastWeekRadioButton;
        private System.Windows.Forms.RadioButton Last12MonthsRadioButton;
        private System.Windows.Forms.RadioButton Last3MonthsRadioButton;
        private System.Windows.Forms.RadioButton LastMonthRadioButton;
        private System.Windows.Forms.Label FiltersLabel;
        private System.Windows.Forms.Label ShowTransactionsLabel;
        private System.Windows.Forms.DataGridView IncomesDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IncomeAmountTextBox;
        private System.Windows.Forms.TextBox IncomeNameTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ErrorLabel;
        private uperfinDbDataSet uperfinDbDataSet;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private uperfinDbDataSetTableAdapters.IncomeTableAdapter incomeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDateDataGridViewTextBoxColumn;
    }
}