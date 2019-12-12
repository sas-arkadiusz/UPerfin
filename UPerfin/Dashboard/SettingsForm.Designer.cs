namespace UPerfin.Dashboard
{
    partial class SettingsForm : MainForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.AvatarComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SubmitResultLabel = new System.Windows.Forms.Label();
            this.AvatarRoundedPictureBox = new UPerfin.Resources.RoundedPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarRoundedPictureBox)).BeginInit();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Lato", 11F);
            this.label3.Location = new System.Drawing.Point(208, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Choose Avatar:";
            // 
            // AvatarComboBox
            // 
            this.AvatarComboBox.FormattingEnabled = true;
            this.AvatarComboBox.Items.AddRange(new object[] {
            "Avocado",
            "Batman",
            "Santa",
            "Ninja"});
            this.AvatarComboBox.Location = new System.Drawing.Point(323, 35);
            this.AvatarComboBox.Name = "AvatarComboBox";
            this.AvatarComboBox.Size = new System.Drawing.Size(188, 21);
            this.AvatarComboBox.TabIndex = 17;
            this.AvatarComboBox.SelectedValueChanged += new System.EventHandler(this.AvatarSelectedValueChange);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.button1.Font = new System.Drawing.Font("Lato", 11F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(382, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AvatarChange_Submit);
            // 
            // SubmitResultLabel
            // 
            this.SubmitResultLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SubmitResultLabel.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubmitResultLabel.Location = new System.Drawing.Point(211, 104);
            this.SubmitResultLabel.Name = "SubmitResultLabel";
            this.SubmitResultLabel.Size = new System.Drawing.Size(300, 23);
            this.SubmitResultLabel.TabIndex = 20;
            // 
            // AvatarRoundedPictureBox
            // 
            this.AvatarRoundedPictureBox.Location = new System.Drawing.Point(535, 29);
            this.AvatarRoundedPictureBox.Name = "AvatarRoundedPictureBox";
            this.AvatarRoundedPictureBox.Size = new System.Drawing.Size(64, 64);
            this.AvatarRoundedPictureBox.TabIndex = 18;
            this.AvatarRoundedPictureBox.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 578);
            this.Controls.Add(this.SubmitResultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AvatarRoundedPictureBox);
            this.Controls.Add(this.AvatarComboBox);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(978, 617);
            this.MinimumSize = new System.Drawing.Size(978, 617);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
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
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.AvatarComboBox, 0);
            this.Controls.SetChildIndex(this.AvatarRoundedPictureBox, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.SubmitResultLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarRoundedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AvatarComboBox;
        private Resources.RoundedPictureBox AvatarRoundedPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SubmitResultLabel;
    }
}