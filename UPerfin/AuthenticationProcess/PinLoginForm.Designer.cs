namespace UPerfin.AuthenticationProcess
{
    partial class PinLoginForm : LoginForm
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
            ((System.ComponentModel.ISupportInitialize)(this.loginBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uperfinPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordPicture
            // 
            this.passwordPicture.BackgroundImage = global::UPerfin.Properties.Resources.PasswordPicture_32x32;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Text = "4-Digit PIN";
            // 
            // signInButton
            // 
            this.signInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signInButton.FlatAppearance.BorderSize = 0;
            // 
            // registerButton
            // 
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.registerButton.FlatAppearance.BorderSize = 0;
            // 
            // anotherSignInOptionButton
            // 
            this.anotherSignInOptionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.anotherSignInOptionButton.FlatAppearance.BorderSize = 0;
            this.anotherSignInOptionButton.Text = "Sign in with a Password";
            this.anotherSignInOptionButton.Click += new System.EventHandler(this.AnotherSignInOptionButton_Click);
            // 
            // PinLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Name = "PinLoginForm";
            this.Text = "PinLoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.loginBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uperfinPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}