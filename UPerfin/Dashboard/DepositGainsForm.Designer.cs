namespace UPerfin.Dashboard
{
    partial class DepositGainsForm : MainForm
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
            this.transactionTableAdapter1 = new UPerfin.transactionDataSetTableAdapters.TransactionTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.DepositAmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DepositInterestTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DepositTimeInMonthsTextBox = new System.Windows.Forms.TextBox();
            this.IncludeTaxCheckBox = new System.Windows.Forms.CheckBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearInputsButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.DepositGainButton.ForeColor = System.Drawing.Color.Black;
            // 
            // SignOutButton
            // 
            this.SignOutButton.FlatAppearance.BorderSize = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            // 
            // transactionTableAdapter1
            // 
            this.transactionTableAdapter1.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(259, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 720);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ClearInputsButton);
            this.tabPage1.Controls.Add(this.CalculateButton);
            this.tabPage1.Controls.Add(this.ResultLabel);
            this.tabPage1.Controls.Add(this.IncludeTaxCheckBox);
            this.tabPage1.Controls.Add(this.DepositTimeInMonthsTextBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.DepositInterestTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.DepositAmountTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 691);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculate Deposit Gains";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deposit Parameters";
            // 
            // DepositAmountTextBox
            // 
            this.DepositAmountTextBox.ForeColor = System.Drawing.Color.Black;
            this.DepositAmountTextBox.Location = new System.Drawing.Point(231, 48);
            this.DepositAmountTextBox.Name = "DepositAmountTextBox";
            this.DepositAmountTextBox.Size = new System.Drawing.Size(315, 22);
            this.DepositAmountTextBox.TabIndex = 3;
            this.DepositAmountTextBox.Text = "Deposit Amount...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Deposit Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.label5.Location = new System.Drawing.Point(8, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Deposit Interest [%]";
            // 
            // DepositInterestTextBox
            // 
            this.DepositInterestTextBox.ForeColor = System.Drawing.Color.Black;
            this.DepositInterestTextBox.Location = new System.Drawing.Point(231, 88);
            this.DepositInterestTextBox.Name = "DepositInterestTextBox";
            this.DepositInterestTextBox.Size = new System.Drawing.Size(315, 22);
            this.DepositInterestTextBox.TabIndex = 6;
            this.DepositInterestTextBox.Text = "Deposit Interest...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Deposit Time [months]";
            // 
            // DepositTimeInMonthsTextBox
            // 
            this.DepositTimeInMonthsTextBox.ForeColor = System.Drawing.Color.Black;
            this.DepositTimeInMonthsTextBox.Location = new System.Drawing.Point(231, 128);
            this.DepositTimeInMonthsTextBox.Name = "DepositTimeInMonthsTextBox";
            this.DepositTimeInMonthsTextBox.Size = new System.Drawing.Size(315, 22);
            this.DepositTimeInMonthsTextBox.TabIndex = 8;
            this.DepositTimeInMonthsTextBox.Text = "Deposit Time in Months...";
            // 
            // IncludeTaxCheckBox
            // 
            this.IncludeTaxCheckBox.AutoSize = true;
            this.IncludeTaxCheckBox.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncludeTaxCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.IncludeTaxCheckBox.Location = new System.Drawing.Point(231, 173);
            this.IncludeTaxCheckBox.Name = "IncludeTaxCheckBox";
            this.IncludeTaxCheckBox.Size = new System.Drawing.Size(136, 27);
            this.IncludeTaxCheckBox.TabIndex = 10;
            this.IncludeTaxCheckBox.Text = "Include Tax?";
            this.IncludeTaxCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.ResultLabel.Font = new System.Drawing.Font("Lato", 11F);
            this.ResultLabel.ForeColor = System.Drawing.Color.White;
            this.ResultLabel.Location = new System.Drawing.Point(8, 328);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(538, 66);
            this.ResultLabel.TabIndex = 11;
            this.ResultLabel.Visible = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.CalculateButton.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(231, 225);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(315, 43);
            this.CalculateButton.TabIndex = 23;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // ClearInputsButton
            // 
            this.ClearInputsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.ClearInputsButton.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearInputsButton.ForeColor = System.Drawing.Color.White;
            this.ClearInputsButton.Location = new System.Drawing.Point(231, 276);
            this.ClearInputsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearInputsButton.Name = "ClearInputsButton";
            this.ClearInputsButton.Size = new System.Drawing.Size(315, 35);
            this.ClearInputsButton.TabIndex = 25;
            this.ClearInputsButton.Text = "Clear Inputs";
            this.ClearInputsButton.UseVisualStyleBackColor = false;
            this.ClearInputsButton.Click += new System.EventHandler(this.ClearInputs_Click);
            // 
            // DepositGainsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 711);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1298, 758);
            this.MinimumSize = new System.Drawing.Size(1298, 758);
            this.Name = "DepositGainsForm";
            this.Text = "DepositGainsForm";
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
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private transactionDataSetTableAdapters.TransactionTableAdapter transactionTableAdapter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox IncludeTaxCheckBox;
        private System.Windows.Forms.TextBox DepositTimeInMonthsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DepositInterestTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DepositAmountTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearInputsButton;
    }
}