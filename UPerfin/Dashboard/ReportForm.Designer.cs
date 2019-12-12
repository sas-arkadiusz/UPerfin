namespace UPerfin.Dashboard
{
    partial class ReportForm : MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.ReportTextBox = new System.Windows.Forms.TextBox();
            this.SerializeToJSONButton = new System.Windows.Forms.Button();
            this.WriteToTextFileButton = new System.Windows.Forms.Button();
            this.WriteInfoLabel = new System.Windows.Forms.Label();
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
            // 
            // SignOutButton
            // 
            this.SignOutButton.FlatAppearance.BorderSize = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.button1.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(210, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // ReportTextBox
            // 
            this.ReportTextBox.Font = new System.Drawing.Font("Lato", 10F);
            this.ReportTextBox.Location = new System.Drawing.Point(210, 58);
            this.ReportTextBox.Multiline = true;
            this.ReportTextBox.Name = "ReportTextBox";
            this.ReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReportTextBox.Size = new System.Drawing.Size(470, 220);
            this.ReportTextBox.TabIndex = 17;
            this.ReportTextBox.Visible = false;
            // 
            // SerializeToJSONButton
            // 
            this.SerializeToJSONButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.SerializeToJSONButton.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SerializeToJSONButton.ForeColor = System.Drawing.Color.White;
            this.SerializeToJSONButton.Location = new System.Drawing.Point(538, 284);
            this.SerializeToJSONButton.Name = "SerializeToJSONButton";
            this.SerializeToJSONButton.Size = new System.Drawing.Size(142, 29);
            this.SerializeToJSONButton.TabIndex = 18;
            this.SerializeToJSONButton.Text = "Serialize to JSON";
            this.SerializeToJSONButton.UseVisualStyleBackColor = false;
            this.SerializeToJSONButton.Visible = false;
            this.SerializeToJSONButton.Click += new System.EventHandler(this.SerializeToJSON_Click);
            // 
            // WriteToTextFileButton
            // 
            this.WriteToTextFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.WriteToTextFileButton.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WriteToTextFileButton.ForeColor = System.Drawing.Color.White;
            this.WriteToTextFileButton.Location = new System.Drawing.Point(390, 284);
            this.WriteToTextFileButton.Name = "WriteToTextFileButton";
            this.WriteToTextFileButton.Size = new System.Drawing.Size(142, 29);
            this.WriteToTextFileButton.TabIndex = 19;
            this.WriteToTextFileButton.Text = "Write to Text File";
            this.WriteToTextFileButton.UseVisualStyleBackColor = false;
            this.WriteToTextFileButton.Visible = false;
            this.WriteToTextFileButton.Click += new System.EventHandler(this.WriteToText_Click);
            // 
            // WriteInfoLabel
            // 
            this.WriteInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.WriteInfoLabel.Font = new System.Drawing.Font("Lato", 10F);
            this.WriteInfoLabel.Location = new System.Drawing.Point(210, 318);
            this.WriteInfoLabel.Name = "WriteInfoLabel";
            this.WriteInfoLabel.Size = new System.Drawing.Size(470, 23);
            this.WriteInfoLabel.TabIndex = 20;
            this.WriteInfoLabel.Visible = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 578);
            this.Controls.Add(this.WriteInfoLabel);
            this.Controls.Add(this.WriteToTextFileButton);
            this.Controls.Add(this.SerializeToJSONButton);
            this.Controls.Add(this.ReportTextBox);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(978, 617);
            this.MinimumSize = new System.Drawing.Size(978, 617);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
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
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.ReportTextBox, 0);
            this.Controls.SetChildIndex(this.SerializeToJSONButton, 0);
            this.Controls.SetChildIndex(this.WriteToTextFileButton, 0);
            this.Controls.SetChildIndex(this.WriteInfoLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ReportTextBox;
        private System.Windows.Forms.Button SerializeToJSONButton;
        private System.Windows.Forms.Button WriteToTextFileButton;
        private System.Windows.Forms.Label WriteInfoLabel;
    }
}