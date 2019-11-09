namespace UPerfin.AuthenticationProcess
{
    partial class LoginForm
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
        protected void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginBox = new System.Windows.Forms.PictureBox();
            this.uperfinPicture = new System.Windows.Forms.PictureBox();
            this.usernamePicture = new System.Windows.Forms.PictureBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameUnderline = new System.Windows.Forms.Panel();
            this.passwordPicture = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordUnderline = new System.Windows.Forms.Panel();
            this.signInButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.anotherSignInOptionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uperfinPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginBox.Location = new System.Drawing.Point(400, 60);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(440, 500);
            this.loginBox.TabIndex = 0;
            this.loginBox.TabStop = false;
            // 
            // uperfinPicture
            // 
            this.uperfinPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uperfinPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uperfinPicture.BackgroundImage")));
            this.uperfinPicture.InitialImage = null;
            this.uperfinPicture.Location = new System.Drawing.Point(560, 100);
            this.uperfinPicture.Name = "uperfinPicture";
            this.uperfinPicture.Size = new System.Drawing.Size(100, 100);
            this.uperfinPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.uperfinPicture.TabIndex = 1;
            this.uperfinPicture.TabStop = false;
            // 
            // usernamePicture
            // 
            this.usernamePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernamePicture.BackgroundImage = global::UPerfin.Properties.Resources.UserPicture_32x32;
            this.usernamePicture.Location = new System.Drawing.Point(440, 246);
            this.usernamePicture.Name = "usernamePicture";
            this.usernamePicture.Size = new System.Drawing.Size(32, 32);
            this.usernamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.usernamePicture.TabIndex = 2;
            this.usernamePicture.TabStop = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.usernameTextBox.Location = new System.Drawing.Point(488, 255);
            this.usernameTextBox.MaxLength = 20;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(299, 24);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.Text = "Username";
            this.usernameTextBox.Click += new System.EventHandler(this.UsernameTextBox_Clicked);
            this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // usernameUnderline
            // 
            this.usernameUnderline.BackColor = System.Drawing.Color.Black;
            this.usernameUnderline.Location = new System.Drawing.Point(440, 289);
            this.usernameUnderline.Name = "usernameUnderline";
            this.usernameUnderline.Size = new System.Drawing.Size(347, 1);
            this.usernameUnderline.TabIndex = 4;
            // 
            // passwordPicture
            // 
            this.passwordPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwordPicture.BackgroundImage = global::UPerfin.Properties.Resources.PasswordPicture_32x32;
            this.passwordPicture.Location = new System.Drawing.Point(440, 308);
            this.passwordPicture.Name = "passwordPicture";
            this.passwordPicture.Size = new System.Drawing.Size(32, 32);
            this.passwordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.passwordPicture.TabIndex = 5;
            this.passwordPicture.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(488, 317);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(299, 24);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Clicked);
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // passwordUnderline
            // 
            this.passwordUnderline.BackColor = System.Drawing.Color.Black;
            this.passwordUnderline.Location = new System.Drawing.Point(440, 351);
            this.passwordUnderline.Name = "passwordUnderline";
            this.passwordUnderline.Size = new System.Drawing.Size(347, 1);
            this.passwordUnderline.TabIndex = 7;
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.signInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signInButton.FlatAppearance.BorderSize = 0;
            this.signInButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signInButton.Location = new System.Drawing.Point(440, 375);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(347, 45);
            this.signInButton.TabIndex = 9;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(440, 507);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(347, 36);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // anotherSignInOptionButton
            // 
            this.anotherSignInOptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.anotherSignInOptionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.anotherSignInOptionButton.FlatAppearance.BorderSize = 0;
            this.anotherSignInOptionButton.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.anotherSignInOptionButton.ForeColor = System.Drawing.Color.Black;
            this.anotherSignInOptionButton.Location = new System.Drawing.Point(440, 465);
            this.anotherSignInOptionButton.Name = "anotherSignInOptionButton";
            this.anotherSignInOptionButton.Size = new System.Drawing.Size(347, 36);
            this.anotherSignInOptionButton.TabIndex = 11;
            this.anotherSignInOptionButton.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.anotherSignInOptionButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordUnderline);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordPicture);
            this.Controls.Add(this.usernameUnderline);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernamePicture);
            this.Controls.Add(this.uperfinPicture);
            this.Controls.Add(this.loginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPerfin";
            ((System.ComponentModel.ISupportInitialize)(this.loginBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uperfinPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox loginBox;
        protected System.Windows.Forms.PictureBox uperfinPicture;
        protected System.Windows.Forms.PictureBox usernamePicture;
        protected System.Windows.Forms.TextBox usernameTextBox;
        protected System.Windows.Forms.Panel usernameUnderline;
        protected System.Windows.Forms.PictureBox passwordPicture;
        protected System.Windows.Forms.TextBox passwordTextBox;
        protected System.Windows.Forms.Panel passwordUnderline;
        protected System.Windows.Forms.Button signInButton;
        protected System.Windows.Forms.Button registerButton;
        protected System.Windows.Forms.Button anotherSignInOptionButton;
    }
}