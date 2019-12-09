namespace UPerfin.Dashboard
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TransactionButton = new System.Windows.Forms.Button();
            this.SavingPlanButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.VehicleOperationButton = new System.Windows.Forms.Button();
            this.CalculatorLabel = new System.Windows.Forms.Label();
            this.DepositGainButton = new System.Windows.Forms.Button();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.NavigationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 720);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(256, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1024, 720);
            this.label2.TabIndex = 2;
            // 
            // DashboardButton
            // 
            this.DashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.Location = new System.Drawing.Point(0, 118);
            this.DashboardButton.Margin = new System.Windows.Forms.Padding(4);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(256, 43);
            this.DashboardButton.TabIndex = 3;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = false;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.HeaderLabel.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(0, 23);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(256, 36);
            this.HeaderLabel.TabIndex = 4;
            this.HeaderLabel.Text = "UPerfin 0.1";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransactionButton
            // 
            this.TransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.TransactionButton.FlatAppearance.BorderSize = 0;
            this.TransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionButton.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TransactionButton.ForeColor = System.Drawing.Color.White;
            this.TransactionButton.Location = new System.Drawing.Point(0, 169);
            this.TransactionButton.Margin = new System.Windows.Forms.Padding(4);
            this.TransactionButton.Name = "TransactionButton";
            this.TransactionButton.Size = new System.Drawing.Size(256, 43);
            this.TransactionButton.TabIndex = 5;
            this.TransactionButton.Text = "Transactions";
            this.TransactionButton.UseVisualStyleBackColor = false;
            this.TransactionButton.Click += new System.EventHandler(this.TransactionsButton_Click);
            // 
            // SavingPlanButton
            // 
            this.SavingPlanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.SavingPlanButton.FlatAppearance.BorderSize = 0;
            this.SavingPlanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavingPlanButton.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SavingPlanButton.ForeColor = System.Drawing.Color.White;
            this.SavingPlanButton.Location = new System.Drawing.Point(0, 220);
            this.SavingPlanButton.Margin = new System.Windows.Forms.Padding(4);
            this.SavingPlanButton.Name = "SavingPlanButton";
            this.SavingPlanButton.Size = new System.Drawing.Size(256, 43);
            this.SavingPlanButton.TabIndex = 7;
            this.SavingPlanButton.Text = "Incomes";
            this.SavingPlanButton.UseVisualStyleBackColor = false;
            this.SavingPlanButton.Click += new System.EventHandler(this.SavingPlansButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.ReportButton.FlatAppearance.BorderSize = 0;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.Location = new System.Drawing.Point(0, 271);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(256, 43);
            this.ReportButton.TabIndex = 8;
            this.ReportButton.Text = "Reports";
            this.ReportButton.UseVisualStyleBackColor = false;
            this.ReportButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // VehicleOperationButton
            // 
            this.VehicleOperationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.VehicleOperationButton.FlatAppearance.BorderSize = 0;
            this.VehicleOperationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehicleOperationButton.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VehicleOperationButton.ForeColor = System.Drawing.Color.White;
            this.VehicleOperationButton.Location = new System.Drawing.Point(0, 376);
            this.VehicleOperationButton.Margin = new System.Windows.Forms.Padding(4);
            this.VehicleOperationButton.Name = "VehicleOperationButton";
            this.VehicleOperationButton.Size = new System.Drawing.Size(256, 43);
            this.VehicleOperationButton.TabIndex = 9;
            this.VehicleOperationButton.Text = "Vehicle Operation";
            this.VehicleOperationButton.UseVisualStyleBackColor = false;
            this.VehicleOperationButton.Click += new System.EventHandler(this.VehicleOperationButton_Click);
            // 
            // CalculatorLabel
            // 
            this.CalculatorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.CalculatorLabel.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalculatorLabel.ForeColor = System.Drawing.Color.White;
            this.CalculatorLabel.Location = new System.Drawing.Point(0, 329);
            this.CalculatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CalculatorLabel.Name = "CalculatorLabel";
            this.CalculatorLabel.Size = new System.Drawing.Size(256, 43);
            this.CalculatorLabel.TabIndex = 10;
            this.CalculatorLabel.Text = "Calculators";
            this.CalculatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepositGainButton
            // 
            this.DepositGainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.DepositGainButton.FlatAppearance.BorderSize = 0;
            this.DepositGainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepositGainButton.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DepositGainButton.ForeColor = System.Drawing.Color.White;
            this.DepositGainButton.Location = new System.Drawing.Point(0, 427);
            this.DepositGainButton.Margin = new System.Windows.Forms.Padding(4);
            this.DepositGainButton.Name = "DepositGainButton";
            this.DepositGainButton.Size = new System.Drawing.Size(256, 43);
            this.DepositGainButton.TabIndex = 11;
            this.DepositGainButton.Text = "Deposit Gains";
            this.DepositGainButton.UseVisualStyleBackColor = false;
            this.DepositGainButton.Click += new System.EventHandler(this.DepositGainsButton_Click);
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.SignOutButton.FlatAppearance.BorderSize = 0;
            this.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutButton.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignOutButton.ForeColor = System.Drawing.Color.White;
            this.SignOutButton.Location = new System.Drawing.Point(0, 662);
            this.SignOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(256, 43);
            this.SignOutButton.TabIndex = 13;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Location = new System.Drawing.Point(0, 612);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(256, 43);
            this.SettingsButton.TabIndex = 14;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // NavigationLabel
            // 
            this.NavigationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.NavigationLabel.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NavigationLabel.ForeColor = System.Drawing.Color.White;
            this.NavigationLabel.Location = new System.Drawing.Point(0, 71);
            this.NavigationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NavigationLabel.Name = "NavigationLabel";
            this.NavigationLabel.Size = new System.Drawing.Size(256, 43);
            this.NavigationLabel.TabIndex = 15;
            this.NavigationLabel.Text = "Navigation";
            this.NavigationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.NavigationLabel);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.DepositGainButton);
            this.Controls.Add(this.CalculatorLabel);
            this.Controls.Add(this.VehicleOperationButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.SavingPlanButton);
            this.Controls.Add(this.TransactionButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.DashboardButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPerfin";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button DashboardButton;
        protected System.Windows.Forms.Label HeaderLabel;
        protected System.Windows.Forms.Button TransactionButton;
        protected System.Windows.Forms.Button SavingPlanButton;
        protected System.Windows.Forms.Button ReportButton;
        protected System.Windows.Forms.Button VehicleOperationButton;
        protected System.Windows.Forms.Label CalculatorLabel;
        protected System.Windows.Forms.Button DepositGainButton;
        protected System.Windows.Forms.Button SignOutButton;
        protected System.Windows.Forms.Button SettingsButton;
        protected System.Windows.Forms.Label NavigationLabel;
    }
}