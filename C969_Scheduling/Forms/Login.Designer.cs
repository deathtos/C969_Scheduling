using C969_Scheduling.Helpers;
using Microsoft.Extensions.Configuration;

namespace C969_Scheduling
{
    partial class Login
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
            lblWelcome = new Label();
            btnSignIn = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblLocation = new Label();
            llblLanguage = new LinkLabel();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(180, 33);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(90, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = Properties.Resources.lblWelcome;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(158, 259);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(112, 34);
            btnSignIn.TabIndex = 1;
            btnSignIn.Text = Properties.Resources.btnLogin;
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(243, 137);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(243, 196);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(55, 140);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 4;
            lblUsername.Text = Properties.Resources.lblUsername;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(55, 199);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 5;
            lblPassword.Text = Properties.Resources.lblPassword;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(125, 66);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(79, 25);
            lblLocation.TabIndex = 6;
            lblLocation.Text = Properties.Resources.lblLocation;
            // 
            // llblLanguage
            // 
            llblLanguage.AutoSize = true;
            llblLanguage.Location = new Point(368, 286);
            llblLanguage.Name = "llblLanguage";
            llblLanguage.Size = new Size(74, 25);
            llblLanguage.TabIndex = 7;
            llblLanguage.TabStop = true;
            llblLanguage.Text = Properties.Resources.lblLanguage;
            llblLanguage.LinkClicked += llblLanguage_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 320);
            Controls.Add(llblLanguage);
            Controls.Add(lblLocation);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnSignIn);
            Controls.Add(lblWelcome);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private Label lblWelcome;
        private Button btnSignIn;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblLocation;
        private LinkLabel llblLanguage;
    }
}