namespace UPerfin.AuthenticationProcess
{
    partial class RegisterForm : LoginForm
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
        private new void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.emailPicture = new System.Windows.Forms.PictureBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailUnderline = new System.Windows.Forms.Label();
            this.pinPicture = new System.Windows.Forms.PictureBox();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.pinUnderline = new System.Windows.Forms.Label();
            this.backPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uperfinPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Click += new System.EventHandler(this.UsernameTextBox_Click);
            // 
            // passwordPicture
            // 
            this.passwordPicture.Location = new System.Drawing.Point(440, 370);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(488, 378);
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            // 
            // signInButton
            // 
            this.signInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signInButton.FlatAppearance.BorderSize = 0;
            this.signInButton.Location = new System.Drawing.Point(440, 505);
            this.signInButton.Text = "Register";
            this.signInButton.Click += new System.EventHandler(this.RegisterButton_Click);
            this.signInButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignInButton_KeyPressed);
            // 
            // registerButton
            // 
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.Location = new System.Drawing.Point(797, 130);
            this.registerButton.Size = new System.Drawing.Size(32, 36);
            this.registerButton.Visible = false;
            // 
            // anotherSignInOptionButton
            // 
            this.anotherSignInOptionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.anotherSignInOptionButton.FlatAppearance.BorderSize = 0;
            this.anotherSignInOptionButton.Location = new System.Drawing.Point(797, 88);
            this.anotherSignInOptionButton.Size = new System.Drawing.Size(32, 36);
            this.anotherSignInOptionButton.Visible = false;
            // 
            // infoLabel
            // 
            this.infoLabel.Location = new System.Drawing.Point(440, 480);
            // 
            // emailPicture
            // 
            this.emailPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailPicture.BackgroundImage = global::UPerfin.Properties.Resources.MailPicture_32x32;
            this.emailPicture.Location = new System.Drawing.Point(440, 308);
            this.emailPicture.Name = "emailPicture";
            this.emailPicture.Size = new System.Drawing.Size(32, 32);
            this.emailPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.emailPicture.TabIndex = 13;
            this.emailPicture.TabStop = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTextBox.Location = new System.Drawing.Point(491, 317);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(296, 24);
            this.emailTextBox.TabIndex = 14;
            this.emailTextBox.Text = "Email";
            this.emailTextBox.Click += new System.EventHandler(this.EmailTextBox_Click);
            // 
            // emailUnderline
            // 
            this.emailUnderline.BackColor = System.Drawing.Color.Black;
            this.emailUnderline.Location = new System.Drawing.Point(440, 412);
            this.emailUnderline.Name = "emailUnderline";
            this.emailUnderline.Size = new System.Drawing.Size(347, 1);
            this.emailUnderline.TabIndex = 15;
            this.emailUnderline.Text = "label1";
            // 
            // pinPicture
            // 
            this.pinPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pinPicture.BackgroundImage = global::UPerfin.Properties.Resources.PinPicture_32x32;
            this.pinPicture.Location = new System.Drawing.Point(440, 431);
            this.pinPicture.Name = "pinPicture";
            this.pinPicture.Size = new System.Drawing.Size(32, 32);
            this.pinPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pinPicture.TabIndex = 16;
            this.pinPicture.TabStop = false;
            // 
            // pinTextBox
            // 
            this.pinTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pinTextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pinTextBox.Location = new System.Drawing.Point(491, 439);
            this.pinTextBox.MaxLength = 4;
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(293, 24);
            this.pinTextBox.TabIndex = 17;
            this.pinTextBox.Text = "PIN";
            this.pinTextBox.Click += new System.EventHandler(this.PinTextBox_Click);
            this.pinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pin_KeyPressed);
            // 
            // pinUnderline
            // 
            this.pinUnderline.BackColor = System.Drawing.Color.Black;
            this.pinUnderline.Location = new System.Drawing.Point(440, 472);
            this.pinUnderline.Name = "pinUnderline";
            this.pinUnderline.Size = new System.Drawing.Size(347, 1);
            this.pinUnderline.TabIndex = 18;
            this.pinUnderline.Text = "label2";
            // 
            // backPicture
            // 
            this.backPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backPicture.BackgroundImage = global::UPerfin.Properties.Resources.BackArrow_32x32;
            this.backPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.backPicture.Location = new System.Drawing.Point(440, 88);
            this.backPicture.Name = "backPicture";
            this.backPicture.Size = new System.Drawing.Size(32, 32);
            this.backPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.backPicture.TabIndex = 19;
            this.backPicture.TabStop = false;
            this.backPicture.Click += new System.EventHandler(this.BackPicture_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.backPicture);
            this.Controls.Add(this.pinUnderline);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.pinPicture);
            this.Controls.Add(this.emailUnderline);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailPicture);
            this.Name = "RegisterForm";
            this.Controls.SetChildIndex(this.loginBox, 0);
            this.Controls.SetChildIndex(this.uperfinPicture, 0);
            this.Controls.SetChildIndex(this.usernamePicture, 0);
            this.Controls.SetChildIndex(this.usernameTextBox, 0);
            this.Controls.SetChildIndex(this.usernameUnderline, 0);
            this.Controls.SetChildIndex(this.passwordPicture, 0);
            this.Controls.SetChildIndex(this.passwordTextBox, 0);
            this.Controls.SetChildIndex(this.passwordUnderline, 0);
            this.Controls.SetChildIndex(this.signInButton, 0);
            this.Controls.SetChildIndex(this.registerButton, 0);
            this.Controls.SetChildIndex(this.anotherSignInOptionButton, 0);
            this.Controls.SetChildIndex(this.infoLabel, 0);
            this.Controls.SetChildIndex(this.emailPicture, 0);
            this.Controls.SetChildIndex(this.emailTextBox, 0);
            this.Controls.SetChildIndex(this.emailUnderline, 0);
            this.Controls.SetChildIndex(this.pinPicture, 0);
            this.Controls.SetChildIndex(this.pinTextBox, 0);
            this.Controls.SetChildIndex(this.pinUnderline, 0);
            this.Controls.SetChildIndex(this.backPicture, 0);
            ((System.ComponentModel.ISupportInitialize)(this.loginBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uperfinPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox emailPicture;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailUnderline;
        private System.Windows.Forms.PictureBox pinPicture;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.Label pinUnderline;
        private System.Windows.Forms.PictureBox backPicture;
    }
}