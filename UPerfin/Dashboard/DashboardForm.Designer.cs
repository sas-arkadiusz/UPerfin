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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.avatarPicture = new UPerfin.Resources.RoundedPictureBox();
            this.helloLabel = new System.Windows.Forms.Label();
            this.OutcomeCategoriesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OutcomesMonthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutcomeCategoriesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutcomesMonthChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(256, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Size = new System.Drawing.Size(1024, 638);
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
            this.avatarPicture.Location = new System.Drawing.Point(1169, 4);
            this.avatarPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.helloLabel.Location = new System.Drawing.Point(263, 26);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(256, 34);
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
            this.OutcomeCategoriesChart.Location = new System.Drawing.Point(268, 404);
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
            this.OutcomeCategoriesChart.Size = new System.Drawing.Size(511, 301);
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
            legend2.Font = new System.Drawing.Font("Lato", 8F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.OutcomesMonthChart.Legends.Add(legend2);
            this.OutcomesMonthChart.Location = new System.Drawing.Point(268, 94);
            this.OutcomesMonthChart.Name = "OutcomesMonthChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Months";
            this.OutcomesMonthChart.Series.Add(series2);
            this.OutcomesMonthChart.Size = new System.Drawing.Size(511, 300);
            this.OutcomesMonthChart.TabIndex = 20;
            title2.Font = new System.Drawing.Font("Lato", 13F);
            title2.Name = "Month Overview";
            title2.Text = "Outcomes Month Overview";
            this.OutcomesMonthChart.Titles.Add(title2);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 4;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Font = new System.Drawing.Font("Lato", 8F);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(785, 94);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Months";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(483, 300);
            this.chart1.TabIndex = 21;
            title3.Font = new System.Drawing.Font("Lato", 13F);
            title3.Name = "Month Overview";
            title3.Text = "Incomes Month Overview";
            this.chart1.Titles.Add(title3);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 711);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.OutcomesMonthChart);
            this.Controls.Add(this.OutcomeCategoriesChart);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.avatarPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1298, 758);
            this.MinimumSize = new System.Drawing.Size(1298, 758);
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
            this.Controls.SetChildIndex(this.chart1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutcomeCategoriesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutcomesMonthChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Resources.RoundedPictureBox avatarPicture;
        protected System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart OutcomeCategoriesChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart OutcomesMonthChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}