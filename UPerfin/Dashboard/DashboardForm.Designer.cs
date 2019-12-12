namespace UPerfin.Dashboard
{
    partial class DashboardForm : MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.avatarPicture = new UPerfin.Resources.RoundedPictureBox();
            this.helloLabel = new System.Windows.Forms.Label();
            this.OutcomeCategoriesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OutcomesMonthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IncomesMonthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BalanceMonthsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutcomeCategoriesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutcomesMonthChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomesMonthChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceMonthsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(192, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label2.Size = new System.Drawing.Size(768, 518);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Enabled = false;
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
            // avatarPicture
            // 
            this.avatarPicture.BackgroundImage = global::UPerfin.Properties.Resources.Avocado_64x64;
            this.avatarPicture.Location = new System.Drawing.Point(877, 3);
            this.avatarPicture.Margin = new System.Windows.Forms.Padding(2);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(64, 64);
            this.avatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.avatarPicture.TabIndex = 17;
            this.avatarPicture.TabStop = false;
            // 
            // helloLabel
            // 
            this.helloLabel.BackColor = System.Drawing.SystemColors.Control;
            this.helloLabel.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.helloLabel.Location = new System.Drawing.Point(197, 21);
            this.helloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(192, 28);
            this.helloLabel.TabIndex = 18;
            this.helloLabel.Text = "Hello, Username!";
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutcomeCategoriesChart
            // 
            this.OutcomeCategoriesChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.OutcomeCategoriesChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.OutcomeCategoriesChart.BorderlineWidth = 4;
            chartArea1.Name = "ChartArea1";
            this.OutcomeCategoriesChart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Lato", 11F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.OutcomeCategoriesChart.Legends.Add(legend1);
            this.OutcomeCategoriesChart.Location = new System.Drawing.Point(201, 328);
            this.OutcomeCategoriesChart.Margin = new System.Windows.Forms.Padding(2);
            this.OutcomeCategoriesChart.Name = "OutcomeCategoriesChart";
            series1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.White;
            series1.Font = new System.Drawing.Font("Lato", 8F);
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderWidth = 0;
            series1.Legend = "Legend1";
            series1.Name = "Categories";
            series1.ShadowColor = System.Drawing.Color.DimGray;
            this.OutcomeCategoriesChart.Series.Add(series1);
            this.OutcomeCategoriesChart.Size = new System.Drawing.Size(383, 245);
            this.OutcomeCategoriesChart.TabIndex = 19;
            title1.Font = new System.Drawing.Font("Lato", 13F);
            title1.Name = "Categories";
            title1.Text = "Categories";
            this.OutcomeCategoriesChart.Titles.Add(title1);
            // 
            // OutcomesMonthChart
            // 
            this.OutcomesMonthChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.OutcomesMonthChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.OutcomesMonthChart.BorderlineWidth = 4;
            chartArea2.Name = "ChartArea1";
            this.OutcomesMonthChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Lato", 8F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.OutcomesMonthChart.Legends.Add(legend2);
            this.OutcomesMonthChart.Location = new System.Drawing.Point(201, 76);
            this.OutcomesMonthChart.Margin = new System.Windows.Forms.Padding(2);
            this.OutcomesMonthChart.Name = "OutcomesMonthChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Months";
            this.OutcomesMonthChart.Series.Add(series2);
            this.OutcomesMonthChart.Size = new System.Drawing.Size(383, 244);
            this.OutcomesMonthChart.TabIndex = 20;
            title2.Font = new System.Drawing.Font("Lato", 13F);
            title2.Name = "Month Overview";
            title2.Text = "Outcomes Month Overview";
            this.OutcomesMonthChart.Titles.Add(title2);
            // 
            // IncomesMonthChart
            // 
            this.IncomesMonthChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.IncomesMonthChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.IncomesMonthChart.BorderlineWidth = 4;
            chartArea3.Name = "ChartArea1";
            this.IncomesMonthChart.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Font = new System.Drawing.Font("Lato", 8F);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.IncomesMonthChart.Legends.Add(legend3);
            this.IncomesMonthChart.Location = new System.Drawing.Point(589, 76);
            this.IncomesMonthChart.Margin = new System.Windows.Forms.Padding(2);
            this.IncomesMonthChart.Name = "IncomesMonthChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Months";
            this.IncomesMonthChart.Series.Add(series3);
            this.IncomesMonthChart.Size = new System.Drawing.Size(362, 244);
            this.IncomesMonthChart.TabIndex = 21;
            title3.Font = new System.Drawing.Font("Lato", 13F);
            title3.Name = "Month Overview";
            title3.Text = "Incomes Month Overview";
            this.IncomesMonthChart.Titles.Add(title3);
            // 
            // BalanceMonthsChart
            // 
            this.BalanceMonthsChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.BalanceMonthsChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.BalanceMonthsChart.BorderlineWidth = 4;
            chartArea4.Name = "ChartArea1";
            this.BalanceMonthsChart.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Font = new System.Drawing.Font("Lato", 8F);
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            legend4.Title = "Balance Month Overview";
            this.BalanceMonthsChart.Legends.Add(legend4);
            this.BalanceMonthsChart.Location = new System.Drawing.Point(589, 328);
            this.BalanceMonthsChart.Margin = new System.Windows.Forms.Padding(2);
            this.BalanceMonthsChart.Name = "BalanceMonthsChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Months";
            this.BalanceMonthsChart.Series.Add(series4);
            this.BalanceMonthsChart.Size = new System.Drawing.Size(362, 244);
            this.BalanceMonthsChart.TabIndex = 22;
            title4.Font = new System.Drawing.Font("Lato", 13F);
            title4.Name = "Month Overview";
            title4.Text = "Balance Month Overview";
            this.BalanceMonthsChart.Titles.Add(title4);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 578);
            this.Controls.Add(this.BalanceMonthsChart);
            this.Controls.Add(this.IncomesMonthChart);
            this.Controls.Add(this.OutcomesMonthChart);
            this.Controls.Add(this.OutcomeCategoriesChart);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.avatarPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(978, 623);
            this.MinimumSize = new System.Drawing.Size(978, 605);
            this.Name = "DashboardForm";
            this.Load += new System.EventHandler(this.Dashboard_OnLoad);
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
            this.Controls.SetChildIndex(this.avatarPicture, 0);
            this.Controls.SetChildIndex(this.helloLabel, 0);
            this.Controls.SetChildIndex(this.OutcomeCategoriesChart, 0);
            this.Controls.SetChildIndex(this.OutcomesMonthChart, 0);
            this.Controls.SetChildIndex(this.IncomesMonthChart, 0);
            this.Controls.SetChildIndex(this.BalanceMonthsChart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutcomeCategoriesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutcomesMonthChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomesMonthChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceMonthsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Resources.RoundedPictureBox avatarPicture;
        protected System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart OutcomeCategoriesChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart OutcomesMonthChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart IncomesMonthChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart BalanceMonthsChart;
    }
}