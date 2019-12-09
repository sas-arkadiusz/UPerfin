namespace UPerfin.Dashboard
{
    partial class TransactionForm : MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.TransactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFixedOutgoingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionDataSet = new UPerfin.transactionDataSet();
            this.transactionTableAdapter = new UPerfin.transactionDataSetTableAdapters.TransactionTableAdapter();
            this.ShowTransactionsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.FiltersLabel = new System.Windows.Forms.Label();
            this.LastMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.Last3MonthsRadioButton = new System.Windows.Forms.RadioButton();
            this.Last12MonthsRadioButton = new System.Windows.Forms.RadioButton();
            this.CategoriesLabel = new System.Windows.Forms.Label();
            this.HideFixedOutgoinsCheckBox = new System.Windows.Forms.CheckBox();
            this.FoodCheckBox = new System.Windows.Forms.CheckBox();
            this.HealthAndMedicalCheckBox = new System.Windows.Forms.CheckBox();
            this.TransportCheckBox = new System.Windows.Forms.CheckBox();
            this.ShoppingCheckBox = new System.Windows.Forms.CheckBox();
            this.BillsCheckBox = new System.Windows.Forms.CheckBox();
            this.HomeCheckBox = new System.Windows.Forms.CheckBox();
            this.EntertainmentCheckBox = new System.Windows.Forms.CheckBox();
            this.HolidaysCheckBox = new System.Windows.Forms.CheckBox();
            this.EducationCheckBox = new System.Windows.Forms.CheckBox();
            this.OtherCheckBox = new System.Windows.Forms.CheckBox();
            this.LastWeekRadioButton = new System.Windows.Forms.RadioButton();
            this.EntirePeriodRadioButton = new System.Windows.Forms.RadioButton();
            this.TransactionNameTextBox = new System.Windows.Forms.TextBox();
            this.TransactionAmountTextBox = new System.Windows.Forms.TextBox();
            this.TransactionCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.FixedOutgoingsCheckBox = new System.Windows.Forms.CheckBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardButton
            // 
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            // 
            // TransactionButton
            // 
            this.TransactionButton.Enabled = false;
            this.TransactionButton.FlatAppearance.BorderSize = 0;
            // 
            // SavingPlanButton
            // 
            this.SavingPlanButton.FlatAppearance.BorderSize = 0;
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
            // TransactionsDataGridView
            // 
            this.TransactionsDataGridView.AutoGenerateColumns = false;
            this.TransactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.transactionNameDataGridViewTextBoxColumn,
            this.transactionAmountDataGridViewTextBoxColumn,
            this.transactionCategoryDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn,
            this.isFixedOutgoingDataGridViewCheckBoxColumn});
            this.TransactionsDataGridView.DataSource = this.transactionBindingSource;
            this.TransactionsDataGridView.Location = new System.Drawing.Point(288, 66);
            this.TransactionsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.TransactionsDataGridView.Name = "TransactionsDataGridView";
            this.TransactionsDataGridView.Size = new System.Drawing.Size(596, 321);
            this.TransactionsDataGridView.TabIndex = 16;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // transactionNameDataGridViewTextBoxColumn
            // 
            this.transactionNameDataGridViewTextBoxColumn.DataPropertyName = "TransactionName";
            this.transactionNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.transactionNameDataGridViewTextBoxColumn.Name = "transactionNameDataGridViewTextBoxColumn";
            // 
            // transactionAmountDataGridViewTextBoxColumn
            // 
            this.transactionAmountDataGridViewTextBoxColumn.DataPropertyName = "TransactionAmount";
            this.transactionAmountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.transactionAmountDataGridViewTextBoxColumn.Name = "transactionAmountDataGridViewTextBoxColumn";
            // 
            // transactionCategoryDataGridViewTextBoxColumn
            // 
            this.transactionCategoryDataGridViewTextBoxColumn.DataPropertyName = "TransactionCategory";
            this.transactionCategoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.transactionCategoryDataGridViewTextBoxColumn.Name = "transactionCategoryDataGridViewTextBoxColumn";
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            // 
            // isFixedOutgoingDataGridViewCheckBoxColumn
            // 
            this.isFixedOutgoingDataGridViewCheckBoxColumn.DataPropertyName = "IsFixedOutgoing";
            this.isFixedOutgoingDataGridViewCheckBoxColumn.HeaderText = "Fixed Outgoings";
            this.isFixedOutgoingDataGridViewCheckBoxColumn.Name = "isFixedOutgoingDataGridViewCheckBoxColumn";
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.transactionDataSet;
            // 
            // transactionDataSet
            // 
            this.transactionDataSet.DataSetName = "transactionDataSet";
            this.transactionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // ShowTransactionsLabel
            // 
            this.ShowTransactionsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.ShowTransactionsLabel.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowTransactionsLabel.ForeColor = System.Drawing.Color.White;
            this.ShowTransactionsLabel.Location = new System.Drawing.Point(288, 34);
            this.ShowTransactionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShowTransactionsLabel.Name = "ShowTransactionsLabel";
            this.ShowTransactionsLabel.Size = new System.Drawing.Size(596, 28);
            this.ShowTransactionsLabel.TabIndex = 17;
            this.ShowTransactionsLabel.Text = "Transactions";
            this.ShowTransactionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button1.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(288, 579);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add Transaction";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddTransaction_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button3.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1017, 579);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 43);
            this.button3.TabIndex = 22;
            this.button3.Text = "Save Changes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button4.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(288, 630);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 35);
            this.button4.TabIndex = 23;
            this.button4.Text = "Clear Inputs";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button5.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1014, 630);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 67);
            this.button5.TabIndex = 24;
            this.button5.Text = "Delete Selected Transaction";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.DeleteTransaction_Click);
            // 
            // FiltersLabel
            // 
            this.FiltersLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.FiltersLabel.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FiltersLabel.ForeColor = System.Drawing.Color.White;
            this.FiltersLabel.Location = new System.Drawing.Point(916, 34);
            this.FiltersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FiltersLabel.Name = "FiltersLabel";
            this.FiltersLabel.Size = new System.Drawing.Size(348, 28);
            this.FiltersLabel.TabIndex = 26;
            this.FiltersLabel.Text = "Filters";
            this.FiltersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastMonthRadioButton
            // 
            this.LastMonthRadioButton.AutoSize = true;
            this.LastMonthRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LastMonthRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastMonthRadioButton.ForeColor = System.Drawing.Color.Black;
            this.LastMonthRadioButton.Location = new System.Drawing.Point(920, 124);
            this.LastMonthRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.LastMonthRadioButton.Name = "LastMonthRadioButton";
            this.LastMonthRadioButton.Size = new System.Drawing.Size(303, 21);
            this.LastMonthRadioButton.TabIndex = 28;
            this.LastMonthRadioButton.TabStop = true;
            this.LastMonthRadioButton.Text = "Hide Transactions that are older than month";
            this.LastMonthRadioButton.UseVisualStyleBackColor = false;
            this.LastMonthRadioButton.Click += new System.EventHandler(this.OlderThanMonth_Click);
            // 
            // Last3MonthsRadioButton
            // 
            this.Last3MonthsRadioButton.AutoSize = true;
            this.Last3MonthsRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Last3MonthsRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Last3MonthsRadioButton.ForeColor = System.Drawing.Color.Black;
            this.Last3MonthsRadioButton.Location = new System.Drawing.Point(920, 153);
            this.Last3MonthsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.Last3MonthsRadioButton.Name = "Last3MonthsRadioButton";
            this.Last3MonthsRadioButton.Size = new System.Drawing.Size(314, 21);
            this.Last3MonthsRadioButton.TabIndex = 29;
            this.Last3MonthsRadioButton.TabStop = true;
            this.Last3MonthsRadioButton.Text = "Hide Transactions that are older than 3 month";
            this.Last3MonthsRadioButton.UseVisualStyleBackColor = false;
            this.Last3MonthsRadioButton.Click += new System.EventHandler(this.OlderThan3Months_Click);
            // 
            // Last12MonthsRadioButton
            // 
            this.Last12MonthsRadioButton.AutoSize = true;
            this.Last12MonthsRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Last12MonthsRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Last12MonthsRadioButton.ForeColor = System.Drawing.Color.Black;
            this.Last12MonthsRadioButton.Location = new System.Drawing.Point(920, 181);
            this.Last12MonthsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.Last12MonthsRadioButton.Name = "Last12MonthsRadioButton";
            this.Last12MonthsRadioButton.Size = new System.Drawing.Size(328, 21);
            this.Last12MonthsRadioButton.TabIndex = 30;
            this.Last12MonthsRadioButton.TabStop = true;
            this.Last12MonthsRadioButton.Text = "Hide Transactions that are older than 12 months";
            this.Last12MonthsRadioButton.UseVisualStyleBackColor = false;
            this.Last12MonthsRadioButton.Click += new System.EventHandler(this.OlderThan12Months_Click);
            // 
            // CategoriesLabel
            // 
            this.CategoriesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.CategoriesLabel.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CategoriesLabel.ForeColor = System.Drawing.Color.White;
            this.CategoriesLabel.Location = new System.Drawing.Point(916, 253);
            this.CategoriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriesLabel.Name = "CategoriesLabel";
            this.CategoriesLabel.Size = new System.Drawing.Size(348, 28);
            this.CategoriesLabel.TabIndex = 31;
            this.CategoriesLabel.Text = "Hide Categories";
            this.CategoriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HideFixedOutgoinsCheckBox
            // 
            this.HideFixedOutgoinsCheckBox.AutoSize = true;
            this.HideFixedOutgoinsCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HideFixedOutgoinsCheckBox.ForeColor = System.Drawing.Color.Black;
            this.HideFixedOutgoinsCheckBox.Location = new System.Drawing.Point(920, 71);
            this.HideFixedOutgoinsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.HideFixedOutgoinsCheckBox.Name = "HideFixedOutgoinsCheckBox";
            this.HideFixedOutgoinsCheckBox.Size = new System.Drawing.Size(165, 21);
            this.HideFixedOutgoinsCheckBox.TabIndex = 42;
            this.HideFixedOutgoinsCheckBox.Text = "Hide Fixed Outgoings";
            this.HideFixedOutgoinsCheckBox.UseVisualStyleBackColor = false;
            this.HideFixedOutgoinsCheckBox.Click += new System.EventHandler(this.HideFixedOutgoingsCheckBox_Click);
            // 
            // FoodCheckBox
            // 
            this.FoodCheckBox.AutoSize = true;
            this.FoodCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FoodCheckBox.ForeColor = System.Drawing.Color.Black;
            this.FoodCheckBox.Location = new System.Drawing.Point(920, 302);
            this.FoodCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.FoodCheckBox.Name = "FoodCheckBox";
            this.FoodCheckBox.Size = new System.Drawing.Size(62, 21);
            this.FoodCheckBox.TabIndex = 43;
            this.FoodCheckBox.Text = "Food";
            this.FoodCheckBox.UseVisualStyleBackColor = false;
            this.FoodCheckBox.Click += new System.EventHandler(this.HideCategoryFoodCheckBox_Click);
            // 
            // HealthAndMedicalCheckBox
            // 
            this.HealthAndMedicalCheckBox.AutoSize = true;
            this.HealthAndMedicalCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HealthAndMedicalCheckBox.ForeColor = System.Drawing.Color.Black;
            this.HealthAndMedicalCheckBox.Location = new System.Drawing.Point(920, 329);
            this.HealthAndMedicalCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.HealthAndMedicalCheckBox.Name = "HealthAndMedicalCheckBox";
            this.HealthAndMedicalCheckBox.Size = new System.Drawing.Size(71, 21);
            this.HealthAndMedicalCheckBox.TabIndex = 44;
            this.HealthAndMedicalCheckBox.Text = "Health";
            this.HealthAndMedicalCheckBox.UseVisualStyleBackColor = false;
            this.HealthAndMedicalCheckBox.Click += new System.EventHandler(this.HideCategoryHealthAndMedicalCheckBox_Click);
            // 
            // TransportCheckBox
            // 
            this.TransportCheckBox.AutoSize = true;
            this.TransportCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TransportCheckBox.ForeColor = System.Drawing.Color.Black;
            this.TransportCheckBox.Location = new System.Drawing.Point(920, 385);
            this.TransportCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.TransportCheckBox.Name = "TransportCheckBox";
            this.TransportCheckBox.Size = new System.Drawing.Size(92, 21);
            this.TransportCheckBox.TabIndex = 45;
            this.TransportCheckBox.Text = "Transport";
            this.TransportCheckBox.UseVisualStyleBackColor = false;
            this.TransportCheckBox.Click += new System.EventHandler(this.HideCategoryTransportCheckBox_Click);
            // 
            // ShoppingCheckBox
            // 
            this.ShoppingCheckBox.AutoSize = true;
            this.ShoppingCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShoppingCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ShoppingCheckBox.Location = new System.Drawing.Point(920, 357);
            this.ShoppingCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ShoppingCheckBox.Name = "ShoppingCheckBox";
            this.ShoppingCheckBox.Size = new System.Drawing.Size(90, 21);
            this.ShoppingCheckBox.TabIndex = 46;
            this.ShoppingCheckBox.Text = "Shopping";
            this.ShoppingCheckBox.UseVisualStyleBackColor = false;
            this.ShoppingCheckBox.Click += new System.EventHandler(this.HideCategoryShoppingCheckBox_Click);
            // 
            // BillsCheckBox
            // 
            this.BillsCheckBox.AutoSize = true;
            this.BillsCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BillsCheckBox.ForeColor = System.Drawing.Color.Black;
            this.BillsCheckBox.Location = new System.Drawing.Point(920, 414);
            this.BillsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.BillsCheckBox.Name = "BillsCheckBox";
            this.BillsCheckBox.Size = new System.Drawing.Size(55, 21);
            this.BillsCheckBox.TabIndex = 47;
            this.BillsCheckBox.Text = "Bills";
            this.BillsCheckBox.UseVisualStyleBackColor = false;
            this.BillsCheckBox.Click += new System.EventHandler(this.HideCategoryBillsCheckBox_Click);
            // 
            // HomeCheckBox
            // 
            this.HomeCheckBox.AutoSize = true;
            this.HomeCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HomeCheckBox.ForeColor = System.Drawing.Color.Black;
            this.HomeCheckBox.Location = new System.Drawing.Point(1109, 302);
            this.HomeCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.HomeCheckBox.Name = "HomeCheckBox";
            this.HomeCheckBox.Size = new System.Drawing.Size(67, 21);
            this.HomeCheckBox.TabIndex = 48;
            this.HomeCheckBox.Text = "Home";
            this.HomeCheckBox.UseVisualStyleBackColor = false;
            this.HomeCheckBox.Click += new System.EventHandler(this.HideCategoryHomeCheckBox_Click);
            // 
            // EntertainmentCheckBox
            // 
            this.EntertainmentCheckBox.AutoSize = true;
            this.EntertainmentCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EntertainmentCheckBox.ForeColor = System.Drawing.Color.Black;
            this.EntertainmentCheckBox.Location = new System.Drawing.Point(1109, 329);
            this.EntertainmentCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.EntertainmentCheckBox.Name = "EntertainmentCheckBox";
            this.EntertainmentCheckBox.Size = new System.Drawing.Size(118, 21);
            this.EntertainmentCheckBox.TabIndex = 49;
            this.EntertainmentCheckBox.Text = "Entertainment";
            this.EntertainmentCheckBox.UseVisualStyleBackColor = false;
            this.EntertainmentCheckBox.Click += new System.EventHandler(this.HideCategoryEntertainmentCheckBox_Click);
            // 
            // HolidaysCheckBox
            // 
            this.HolidaysCheckBox.AutoSize = true;
            this.HolidaysCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HolidaysCheckBox.ForeColor = System.Drawing.Color.Black;
            this.HolidaysCheckBox.Location = new System.Drawing.Point(1109, 357);
            this.HolidaysCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.HolidaysCheckBox.Name = "HolidaysCheckBox";
            this.HolidaysCheckBox.Size = new System.Drawing.Size(84, 21);
            this.HolidaysCheckBox.TabIndex = 50;
            this.HolidaysCheckBox.Text = "Holidays";
            this.HolidaysCheckBox.UseVisualStyleBackColor = false;
            this.HolidaysCheckBox.Click += new System.EventHandler(this.HideCategoryHolidaysCheckBox_Click);
            // 
            // EducationCheckBox
            // 
            this.EducationCheckBox.AutoSize = true;
            this.EducationCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EducationCheckBox.ForeColor = System.Drawing.Color.Black;
            this.EducationCheckBox.Location = new System.Drawing.Point(1109, 385);
            this.EducationCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.EducationCheckBox.Name = "EducationCheckBox";
            this.EducationCheckBox.Size = new System.Drawing.Size(93, 21);
            this.EducationCheckBox.TabIndex = 51;
            this.EducationCheckBox.Text = "Education";
            this.EducationCheckBox.UseVisualStyleBackColor = false;
            this.EducationCheckBox.Click += new System.EventHandler(this.HideCategoryEducationCheckBox_Click);
            // 
            // OtherCheckBox
            // 
            this.OtherCheckBox.AutoSize = true;
            this.OtherCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OtherCheckBox.ForeColor = System.Drawing.Color.Black;
            this.OtherCheckBox.Location = new System.Drawing.Point(1109, 414);
            this.OtherCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.OtherCheckBox.Name = "OtherCheckBox";
            this.OtherCheckBox.Size = new System.Drawing.Size(66, 21);
            this.OtherCheckBox.TabIndex = 52;
            this.OtherCheckBox.Text = "Other";
            this.OtherCheckBox.UseVisualStyleBackColor = false;
            this.OtherCheckBox.Click += new System.EventHandler(this.HideCategoryOtherCheckBox_Click);
            // 
            // LastWeekRadioButton
            // 
            this.LastWeekRadioButton.AutoSize = true;
            this.LastWeekRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LastWeekRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastWeekRadioButton.ForeColor = System.Drawing.Color.Black;
            this.LastWeekRadioButton.Location = new System.Drawing.Point(920, 96);
            this.LastWeekRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.LastWeekRadioButton.Name = "LastWeekRadioButton";
            this.LastWeekRadioButton.Size = new System.Drawing.Size(294, 21);
            this.LastWeekRadioButton.TabIndex = 53;
            this.LastWeekRadioButton.TabStop = true;
            this.LastWeekRadioButton.Text = "Hide Transactions that are older than week";
            this.LastWeekRadioButton.UseVisualStyleBackColor = false;
            this.LastWeekRadioButton.Click += new System.EventHandler(this.OlderThanWeek_Click);
            // 
            // EntirePeriodRadioButton
            // 
            this.EntirePeriodRadioButton.AutoSize = true;
            this.EntirePeriodRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EntirePeriodRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EntirePeriodRadioButton.ForeColor = System.Drawing.Color.Black;
            this.EntirePeriodRadioButton.Location = new System.Drawing.Point(920, 210);
            this.EntirePeriodRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.EntirePeriodRadioButton.Name = "EntirePeriodRadioButton";
            this.EntirePeriodRadioButton.Size = new System.Drawing.Size(274, 21);
            this.EntirePeriodRadioButton.TabIndex = 54;
            this.EntirePeriodRadioButton.TabStop = true;
            this.EntirePeriodRadioButton.Text = "Show Transactions for the entire period";
            this.EntirePeriodRadioButton.UseVisualStyleBackColor = false;
            this.EntirePeriodRadioButton.Click += new System.EventHandler(this.ShowEntirePeriod_Click);
            // 
            // TransactionNameTextBox
            // 
            this.TransactionNameTextBox.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TransactionNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.TransactionNameTextBox.Location = new System.Drawing.Point(288, 399);
            this.TransactionNameTextBox.Name = "TransactionNameTextBox";
            this.TransactionNameTextBox.Size = new System.Drawing.Size(250, 29);
            this.TransactionNameTextBox.TabIndex = 55;
            this.TransactionNameTextBox.Text = "Transaction Name...";
            // 
            // TransactionAmountTextBox
            // 
            this.TransactionAmountTextBox.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TransactionAmountTextBox.ForeColor = System.Drawing.Color.Black;
            this.TransactionAmountTextBox.Location = new System.Drawing.Point(288, 442);
            this.TransactionAmountTextBox.Name = "TransactionAmountTextBox";
            this.TransactionAmountTextBox.Size = new System.Drawing.Size(250, 29);
            this.TransactionAmountTextBox.TabIndex = 56;
            this.TransactionAmountTextBox.Text = "Transaction Amount...";
            // 
            // TransactionCategoryComboBox
            // 
            this.TransactionCategoryComboBox.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TransactionCategoryComboBox.ForeColor = System.Drawing.Color.Black;
            this.TransactionCategoryComboBox.FormattingEnabled = true;
            this.TransactionCategoryComboBox.Items.AddRange(new object[] {
            "Food",
            "Health",
            "Shopping",
            "Transport",
            "Bills",
            "Home",
            "Entertainment",
            "Holidays",
            "Education",
            "Other"});
            this.TransactionCategoryComboBox.Location = new System.Drawing.Point(288, 487);
            this.TransactionCategoryComboBox.Name = "TransactionCategoryComboBox";
            this.TransactionCategoryComboBox.Size = new System.Drawing.Size(250, 30);
            this.TransactionCategoryComboBox.TabIndex = 57;
            this.TransactionCategoryComboBox.Text = "Transaction Category";
            // 
            // FixedOutgoingsCheckBox
            // 
            this.FixedOutgoingsCheckBox.AutoSize = true;
            this.FixedOutgoingsCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FixedOutgoingsCheckBox.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FixedOutgoingsCheckBox.ForeColor = System.Drawing.Color.Black;
            this.FixedOutgoingsCheckBox.Location = new System.Drawing.Point(288, 531);
            this.FixedOutgoingsCheckBox.Name = "FixedOutgoingsCheckBox";
            this.FixedOutgoingsCheckBox.Size = new System.Drawing.Size(204, 27);
            this.FixedOutgoingsCheckBox.TabIndex = 58;
            this.FixedOutgoingsCheckBox.Text = "Is it Fixed Outgoing?";
            this.FixedOutgoingsCheckBox.UseVisualStyleBackColor = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ErrorLabel.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(565, 579);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(319, 43);
            this.ErrorLabel.TabIndex = 59;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 711);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.FixedOutgoingsCheckBox);
            this.Controls.Add(this.TransactionCategoryComboBox);
            this.Controls.Add(this.TransactionAmountTextBox);
            this.Controls.Add(this.TransactionNameTextBox);
            this.Controls.Add(this.EntirePeriodRadioButton);
            this.Controls.Add(this.LastWeekRadioButton);
            this.Controls.Add(this.OtherCheckBox);
            this.Controls.Add(this.EducationCheckBox);
            this.Controls.Add(this.HolidaysCheckBox);
            this.Controls.Add(this.EntertainmentCheckBox);
            this.Controls.Add(this.HomeCheckBox);
            this.Controls.Add(this.BillsCheckBox);
            this.Controls.Add(this.ShoppingCheckBox);
            this.Controls.Add(this.TransportCheckBox);
            this.Controls.Add(this.HealthAndMedicalCheckBox);
            this.Controls.Add(this.FoodCheckBox);
            this.Controls.Add(this.HideFixedOutgoinsCheckBox);
            this.Controls.Add(this.CategoriesLabel);
            this.Controls.Add(this.Last12MonthsRadioButton);
            this.Controls.Add(this.Last3MonthsRadioButton);
            this.Controls.Add(this.LastMonthRadioButton);
            this.Controls.Add(this.FiltersLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowTransactionsLabel);
            this.Controls.Add(this.TransactionsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1298, 758);
            this.MinimumSize = new System.Drawing.Size(1298, 758);
            this.Name = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
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
            this.Controls.SetChildIndex(this.TransactionsDataGridView, 0);
            this.Controls.SetChildIndex(this.ShowTransactionsLabel, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.FiltersLabel, 0);
            this.Controls.SetChildIndex(this.LastMonthRadioButton, 0);
            this.Controls.SetChildIndex(this.Last3MonthsRadioButton, 0);
            this.Controls.SetChildIndex(this.Last12MonthsRadioButton, 0);
            this.Controls.SetChildIndex(this.CategoriesLabel, 0);
            this.Controls.SetChildIndex(this.HideFixedOutgoinsCheckBox, 0);
            this.Controls.SetChildIndex(this.FoodCheckBox, 0);
            this.Controls.SetChildIndex(this.HealthAndMedicalCheckBox, 0);
            this.Controls.SetChildIndex(this.TransportCheckBox, 0);
            this.Controls.SetChildIndex(this.ShoppingCheckBox, 0);
            this.Controls.SetChildIndex(this.BillsCheckBox, 0);
            this.Controls.SetChildIndex(this.HomeCheckBox, 0);
            this.Controls.SetChildIndex(this.EntertainmentCheckBox, 0);
            this.Controls.SetChildIndex(this.HolidaysCheckBox, 0);
            this.Controls.SetChildIndex(this.EducationCheckBox, 0);
            this.Controls.SetChildIndex(this.OtherCheckBox, 0);
            this.Controls.SetChildIndex(this.LastWeekRadioButton, 0);
            this.Controls.SetChildIndex(this.EntirePeriodRadioButton, 0);
            this.Controls.SetChildIndex(this.TransactionNameTextBox, 0);
            this.Controls.SetChildIndex(this.TransactionAmountTextBox, 0);
            this.Controls.SetChildIndex(this.TransactionCategoryComboBox, 0);
            this.Controls.SetChildIndex(this.FixedOutgoingsCheckBox, 0);
            this.Controls.SetChildIndex(this.ErrorLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TransactionsDataGridView;
        private transactionDataSet transactionDataSet;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private transactionDataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.Label ShowTransactionsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label FiltersLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFixedOutgoingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.RadioButton LastMonthRadioButton;
        private System.Windows.Forms.RadioButton Last3MonthsRadioButton;
        private System.Windows.Forms.RadioButton Last12MonthsRadioButton;
        private System.Windows.Forms.Label CategoriesLabel;
        private System.Windows.Forms.CheckBox HideFixedOutgoinsCheckBox;
        private System.Windows.Forms.CheckBox FoodCheckBox;
        private System.Windows.Forms.CheckBox HealthAndMedicalCheckBox;
        private System.Windows.Forms.CheckBox TransportCheckBox;
        private System.Windows.Forms.CheckBox ShoppingCheckBox;
        private System.Windows.Forms.CheckBox BillsCheckBox;
        private System.Windows.Forms.CheckBox HomeCheckBox;
        private System.Windows.Forms.CheckBox EntertainmentCheckBox;
        private System.Windows.Forms.CheckBox HolidaysCheckBox;
        private System.Windows.Forms.CheckBox EducationCheckBox;
        private System.Windows.Forms.CheckBox OtherCheckBox;
        private System.Windows.Forms.RadioButton LastWeekRadioButton;
        private System.Windows.Forms.RadioButton EntirePeriodRadioButton;
        private System.Windows.Forms.TextBox TransactionNameTextBox;
        private System.Windows.Forms.TextBox TransactionAmountTextBox;
        private System.Windows.Forms.ComboBox TransactionCategoryComboBox;
        private System.Windows.Forms.CheckBox FixedOutgoingsCheckBox;
        private System.Windows.Forms.Label ErrorLabel;
    }
}