﻿namespace Consumer_Survey_System
{
    partial class frmRegister
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
            System.Windows.Forms.LinkLabel linklblLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pbxViewPassword = new System.Windows.Forms.PictureBox();
            this.pbxHidePassword = new System.Windows.Forms.PictureBox();
            linklblLogin = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxViewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHidePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // linklblLogin
            // 
            linklblLogin.AutoSize = true;
            linklblLogin.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linklblLogin.Location = new System.Drawing.Point(205, 416);
            linklblLogin.Name = "linklblLogin";
            linklblLogin.Size = new System.Drawing.Size(34, 13);
            linklblLogin.TabIndex = 50;
            linklblLogin.TabStop = true;
            linklblLogin.Text = "Login";
            linklblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogin_LinkClicked);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(38, 131);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(107, 18);
            this.lblPhoneNumber.TabIndex = 34;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(41, 152);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(243, 26);
            this.txtPhoneNumber.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "REGISTER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(38, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(105, 18);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(41, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 26);
            this.txtEmail.TabIndex = 33;
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatPassword.Location = new System.Drawing.Point(38, 266);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(124, 18);
            this.lblRepeatPassword.TabIndex = 46;
            this.lblRepeatPassword.Text = "Repeat Password";
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeatPassword.Location = new System.Drawing.Point(41, 287);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.PasswordChar = '•';
            this.txtRepeatPassword.Size = new System.Drawing.Size(243, 26);
            this.txtRepeatPassword.TabIndex = 47;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(68, 416);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(133, 13);
            this.lblLogin.TabIndex = 49;
            this.lblLogin.Text = "Already have an account?";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(41, 365);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(243, 27);
            this.btnRegister.TabIndex = 48;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(38, 198);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 18);
            this.lblPassword.TabIndex = 44;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(41, 219);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(243, 26);
            this.txtPassword.TabIndex = 45;
            // 
            // pbxViewPassword
            // 
            this.pbxViewPassword.Image = global::Consumer_Survey_System.Properties.Resources.icons8_show_password_24;
            this.pbxViewPassword.Location = new System.Drawing.Point(41, 319);
            this.pbxViewPassword.Name = "pbxViewPassword";
            this.pbxViewPassword.Size = new System.Drawing.Size(25, 24);
            this.pbxViewPassword.TabIndex = 51;
            this.pbxViewPassword.TabStop = false;
            this.pbxViewPassword.Click += new System.EventHandler(this.pbxViewPassword_Click);
            // 
            // pbxHidePassword
            // 
            this.pbxHidePassword.Image = global::Consumer_Survey_System.Properties.Resources.icons8_show_password_24;
            this.pbxHidePassword.Location = new System.Drawing.Point(41, 319);
            this.pbxHidePassword.Name = "pbxHidePassword";
            this.pbxHidePassword.Size = new System.Drawing.Size(25, 24);
            this.pbxHidePassword.TabIndex = 52;
            this.pbxHidePassword.TabStop = false;
            this.pbxHidePassword.Visible = false;
            this.pbxHidePassword.Click += new System.EventHandler(this.pbxHidePassword_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 461);
            this.Controls.Add(this.pbxViewPassword);
            this.Controls.Add(this.pbxHidePassword);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRepeatPassword);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(linklblLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumer Survey System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegister_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxViewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHidePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxHidePassword;
        private System.Windows.Forms.PictureBox pbxViewPassword;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}