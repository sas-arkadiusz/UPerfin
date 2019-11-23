namespace UPerfin.Dashboard
{
    partial class DashboardForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helloLabel = new System.Windows.Forms.Label();
            this.avatarPicture = new UPerfin.Resources.RoundedPictureBox();
            this.signOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 720);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(256, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1024, 627);
            this.label2.TabIndex = 1;
            // 
            // helloLabel
            // 
            this.helloLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.helloLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helloLabel.ForeColor = System.Drawing.Color.White;
            this.helloLabel.Location = new System.Drawing.Point(899, 29);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(256, 25);
            this.helloLabel.TabIndex = 2;
            this.helloLabel.Text = "Hello, Username!";
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatarPicture
            // 
            this.avatarPicture.BackgroundImage = global::UPerfin.Properties.Resources.Avocado_64x64;
            this.avatarPicture.Location = new System.Drawing.Point(1174, 9);
            this.avatarPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(64, 64);
            this.avatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.avatarPicture.TabIndex = 4;
            this.avatarPicture.TabStop = false;
            // 
            // signOutButton
            // 
            this.signOutButton.Font = new System.Drawing.Font("Lato", 11F);
            this.signOutButton.Location = new System.Drawing.Point(0, 501);
            this.signOutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(256, 43);
            this.signOutButton.TabIndex = 5;
            this.signOutButton.Text = "Sign out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.SignOut_Clicked);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.avatarPicture);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPerfin";
            this.Load += new System.EventHandler(this.Dashboard_OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label helloLabel;
        protected Resources.RoundedPictureBox avatarPicture;
        protected System.Windows.Forms.Button signOutButton;
    }
}