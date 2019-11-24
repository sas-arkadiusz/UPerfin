﻿namespace UPerfin.Dashboard
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
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionDataSet = new UPerfin.transactionDataSet();
            this.transactionTableAdapter = new UPerfin.transactionDataSetTableAdapters.TransactionTableAdapter();
            this.ShowTransactionsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.FiltersLabel = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFixedOutgoingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            // FixedOutgoingButton
            // 
            this.FixedOutgoingButton.FlatAppearance.BorderSize = 0;
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
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
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
            this.TransactionsDataGridView.Location = new System.Drawing.Point(216, 54);
            this.TransactionsDataGridView.Name = "TransactionsDataGridView";
            this.TransactionsDataGridView.Size = new System.Drawing.Size(447, 261);
            this.TransactionsDataGridView.TabIndex = 16;
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
            this.ShowTransactionsLabel.Location = new System.Drawing.Point(216, 28);
            this.ShowTransactionsLabel.Name = "ShowTransactionsLabel";
            this.ShowTransactionsLabel.Size = new System.Drawing.Size(447, 23);
            this.ShowTransactionsLabel.TabIndex = 17;
            this.ShowTransactionsLabel.Text = "Transactions";
            this.ShowTransactionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button1.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(216, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add Transaction";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button3.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(375, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 35);
            this.button3.TabIndex = 22;
            this.button3.Text = "Edit Transaction";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button4.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(216, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 35);
            this.button4.TabIndex = 23;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button5.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(375, 490);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 35);
            this.button5.TabIndex = 24;
            this.button5.Text = "Delete Transaction";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // FiltersLabel
            // 
            this.FiltersLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.FiltersLabel.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FiltersLabel.ForeColor = System.Drawing.Color.White;
            this.FiltersLabel.Location = new System.Drawing.Point(687, 28);
            this.FiltersLabel.Name = "FiltersLabel";
            this.FiltersLabel.Size = new System.Drawing.Size(261, 23);
            this.FiltersLabel.TabIndex = 26;
            this.FiltersLabel.Text = "Filters";
            this.FiltersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // LastMonthRadioButton
            // 
            this.LastMonthRadioButton.AutoSize = true;
            this.LastMonthRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LastMonthRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastMonthRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.LastMonthRadioButton.Location = new System.Drawing.Point(690, 101);
            this.LastMonthRadioButton.Name = "LastMonthRadioButton";
            this.LastMonthRadioButton.Size = new System.Drawing.Size(235, 17);
            this.LastMonthRadioButton.TabIndex = 28;
            this.LastMonthRadioButton.TabStop = true;
            this.LastMonthRadioButton.Text = "Hide Transactions that are older than month";
            this.LastMonthRadioButton.UseVisualStyleBackColor = false;
            // 
            // Last3MonthsRadioButton
            // 
            this.Last3MonthsRadioButton.AutoSize = true;
            this.Last3MonthsRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Last3MonthsRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Last3MonthsRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.Last3MonthsRadioButton.Location = new System.Drawing.Point(690, 124);
            this.Last3MonthsRadioButton.Name = "Last3MonthsRadioButton";
            this.Last3MonthsRadioButton.Size = new System.Drawing.Size(243, 17);
            this.Last3MonthsRadioButton.TabIndex = 29;
            this.Last3MonthsRadioButton.TabStop = true;
            this.Last3MonthsRadioButton.Text = "Hide Transactions that are older than 3 month";
            this.Last3MonthsRadioButton.UseVisualStyleBackColor = false;
            // 
            // Last12MonthsRadioButton
            // 
            this.Last12MonthsRadioButton.AutoSize = true;
            this.Last12MonthsRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Last12MonthsRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Last12MonthsRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.Last12MonthsRadioButton.Location = new System.Drawing.Point(690, 147);
            this.Last12MonthsRadioButton.Name = "Last12MonthsRadioButton";
            this.Last12MonthsRadioButton.Size = new System.Drawing.Size(254, 17);
            this.Last12MonthsRadioButton.TabIndex = 30;
            this.Last12MonthsRadioButton.TabStop = true;
            this.Last12MonthsRadioButton.Text = "Hide Transactions that are older than 12 months";
            this.Last12MonthsRadioButton.UseVisualStyleBackColor = false;
            // 
            // CategoriesLabel
            // 
            this.CategoriesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.CategoriesLabel.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CategoriesLabel.ForeColor = System.Drawing.Color.White;
            this.CategoriesLabel.Location = new System.Drawing.Point(687, 167);
            this.CategoriesLabel.Name = "CategoriesLabel";
            this.CategoriesLabel.Size = new System.Drawing.Size(261, 23);
            this.CategoriesLabel.TabIndex = 31;
            this.CategoriesLabel.Text = "Hide Categories";
            this.CategoriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HideFixedOutgoinsCheckBox
            // 
            this.HideFixedOutgoinsCheckBox.AutoSize = true;
            this.HideFixedOutgoinsCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HideFixedOutgoinsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.HideFixedOutgoinsCheckBox.Location = new System.Drawing.Point(690, 58);
            this.HideFixedOutgoinsCheckBox.Name = "HideFixedOutgoinsCheckBox";
            this.HideFixedOutgoinsCheckBox.Size = new System.Drawing.Size(127, 17);
            this.HideFixedOutgoinsCheckBox.TabIndex = 42;
            this.HideFixedOutgoinsCheckBox.Text = "Hide Fixed Outgoings";
            this.HideFixedOutgoinsCheckBox.UseVisualStyleBackColor = false;
            this.HideFixedOutgoinsCheckBox.Click += new System.EventHandler(this.HideFixedOutgoingsCheckBox_Click);
            // 
            // FoodCheckBox
            // 
            this.FoodCheckBox.AutoSize = true;
            this.FoodCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FoodCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.FoodCheckBox.Location = new System.Drawing.Point(690, 207);
            this.FoodCheckBox.Name = "FoodCheckBox";
            this.FoodCheckBox.Size = new System.Drawing.Size(50, 17);
            this.FoodCheckBox.TabIndex = 43;
            this.FoodCheckBox.Text = "Food";
            this.FoodCheckBox.UseVisualStyleBackColor = false;
            // 
            // HealthAndMedicalCheckBox
            // 
            this.HealthAndMedicalCheckBox.AutoSize = true;
            this.HealthAndMedicalCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HealthAndMedicalCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.HealthAndMedicalCheckBox.Location = new System.Drawing.Point(690, 229);
            this.HealthAndMedicalCheckBox.Name = "HealthAndMedicalCheckBox";
            this.HealthAndMedicalCheckBox.Size = new System.Drawing.Size(118, 17);
            this.HealthAndMedicalCheckBox.TabIndex = 44;
            this.HealthAndMedicalCheckBox.Text = "Health and Medical";
            this.HealthAndMedicalCheckBox.UseVisualStyleBackColor = false;
            // 
            // TransportCheckBox
            // 
            this.TransportCheckBox.AutoSize = true;
            this.TransportCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TransportCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.TransportCheckBox.Location = new System.Drawing.Point(690, 275);
            this.TransportCheckBox.Name = "TransportCheckBox";
            this.TransportCheckBox.Size = new System.Drawing.Size(71, 17);
            this.TransportCheckBox.TabIndex = 45;
            this.TransportCheckBox.Text = "Transport";
            this.TransportCheckBox.UseVisualStyleBackColor = false;
            // 
            // ShoppingCheckBox
            // 
            this.ShoppingCheckBox.AutoSize = true;
            this.ShoppingCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShoppingCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.ShoppingCheckBox.Location = new System.Drawing.Point(690, 252);
            this.ShoppingCheckBox.Name = "ShoppingCheckBox";
            this.ShoppingCheckBox.Size = new System.Drawing.Size(71, 17);
            this.ShoppingCheckBox.TabIndex = 46;
            this.ShoppingCheckBox.Text = "Shopping";
            this.ShoppingCheckBox.UseVisualStyleBackColor = false;
            // 
            // BillsCheckBox
            // 
            this.BillsCheckBox.AutoSize = true;
            this.BillsCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BillsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.BillsCheckBox.Location = new System.Drawing.Point(690, 298);
            this.BillsCheckBox.Name = "BillsCheckBox";
            this.BillsCheckBox.Size = new System.Drawing.Size(44, 17);
            this.BillsCheckBox.TabIndex = 47;
            this.BillsCheckBox.Text = "Bills";
            this.BillsCheckBox.UseVisualStyleBackColor = false;
            // 
            // HomeCheckBox
            // 
            this.HomeCheckBox.AutoSize = true;
            this.HomeCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HomeCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.HomeCheckBox.Location = new System.Drawing.Point(832, 207);
            this.HomeCheckBox.Name = "HomeCheckBox";
            this.HomeCheckBox.Size = new System.Drawing.Size(54, 17);
            this.HomeCheckBox.TabIndex = 48;
            this.HomeCheckBox.Text = "Home";
            this.HomeCheckBox.UseVisualStyleBackColor = false;
            // 
            // EntertainmentCheckBox
            // 
            this.EntertainmentCheckBox.AutoSize = true;
            this.EntertainmentCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EntertainmentCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.EntertainmentCheckBox.Location = new System.Drawing.Point(832, 229);
            this.EntertainmentCheckBox.Name = "EntertainmentCheckBox";
            this.EntertainmentCheckBox.Size = new System.Drawing.Size(91, 17);
            this.EntertainmentCheckBox.TabIndex = 49;
            this.EntertainmentCheckBox.Text = "Entertainment";
            this.EntertainmentCheckBox.UseVisualStyleBackColor = false;
            // 
            // HolidaysCheckBox
            // 
            this.HolidaysCheckBox.AutoSize = true;
            this.HolidaysCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HolidaysCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.HolidaysCheckBox.Location = new System.Drawing.Point(832, 252);
            this.HolidaysCheckBox.Name = "HolidaysCheckBox";
            this.HolidaysCheckBox.Size = new System.Drawing.Size(66, 17);
            this.HolidaysCheckBox.TabIndex = 50;
            this.HolidaysCheckBox.Text = "Holidays";
            this.HolidaysCheckBox.UseVisualStyleBackColor = false;
            // 
            // EducationCheckBox
            // 
            this.EducationCheckBox.AutoSize = true;
            this.EducationCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EducationCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.EducationCheckBox.Location = new System.Drawing.Point(832, 275);
            this.EducationCheckBox.Name = "EducationCheckBox";
            this.EducationCheckBox.Size = new System.Drawing.Size(74, 17);
            this.EducationCheckBox.TabIndex = 51;
            this.EducationCheckBox.Text = "Education";
            this.EducationCheckBox.UseVisualStyleBackColor = false;
            // 
            // OtherCheckBox
            // 
            this.OtherCheckBox.AutoSize = true;
            this.OtherCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OtherCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.OtherCheckBox.Location = new System.Drawing.Point(832, 298);
            this.OtherCheckBox.Name = "OtherCheckBox";
            this.OtherCheckBox.Size = new System.Drawing.Size(52, 17);
            this.OtherCheckBox.TabIndex = 52;
            this.OtherCheckBox.Text = "Other";
            this.OtherCheckBox.UseVisualStyleBackColor = false;
            // 
            // LastWeekRadioButton
            // 
            this.LastWeekRadioButton.AutoSize = true;
            this.LastWeekRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LastWeekRadioButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastWeekRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.LastWeekRadioButton.Location = new System.Drawing.Point(690, 78);
            this.LastWeekRadioButton.Name = "LastWeekRadioButton";
            this.LastWeekRadioButton.Size = new System.Drawing.Size(230, 17);
            this.LastWeekRadioButton.TabIndex = 53;
            this.LastWeekRadioButton.TabStop = true;
            this.LastWeekRadioButton.Text = "Hide Transactions that are older than week";
            this.LastWeekRadioButton.UseVisualStyleBackColor = false;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 585);
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
            this.Name = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.DashboardButton, 0);
            this.Controls.SetChildIndex(this.HeaderLabel, 0);
            this.Controls.SetChildIndex(this.TransactionButton, 0);
            this.Controls.SetChildIndex(this.FixedOutgoingButton, 0);
            this.Controls.SetChildIndex(this.SavingPlanButton, 0);
            this.Controls.SetChildIndex(this.ReportButton, 0);
            this.Controls.SetChildIndex(this.VehicleOperationButton, 0);
            this.Controls.SetChildIndex(this.CalculatorLabel, 0);
            this.Controls.SetChildIndex(this.DepositGainButton, 0);
            this.Controls.SetChildIndex(this.button2, 0);
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
    }
}