﻿
namespace MailServer
{
    partial class fQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuenMatKhau));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.btnContinueStep2 = new System.Windows.Forms.Button();
            this.txtReEnter = new MaterialSkin.Controls.MaterialTextBox();
            this.btnReadPw1 = new System.Windows.Forms.Button();
            this.btnReadPw2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.btnContinueStep1 = new System.Windows.Forms.Button();
            this.txtPin = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnBackStep1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnBackStep2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 320);
            this.panel1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(404, 290);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Step 2: New password";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(398, 108);
            this.panel5.TabIndex = 4;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fQuenMatKhau_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(32, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 52);
            this.label4.TabIndex = 0;
            this.label4.Text = "New Password";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fQuenMatKhau_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(74, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Please create a new password\r\nthat you don\'t use on any site";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fQuenMatKhau_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnBackStep2);
            this.panel4.Controls.Add(this.btnReadPw2);
            this.panel4.Controls.Add(this.btnReadPw1);
            this.panel4.Controls.Add(this.txtReEnter);
            this.panel4.Controls.Add(this.btnContinueStep2);
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 176);
            this.panel4.TabIndex = 5;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fQuenMatKhau_MouseDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "Password:";
            this.txtPassword.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtPassword.LeadingIcon")));
            this.txtPassword.Location = new System.Drawing.Point(3, 6);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(333, 50);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // btnContinueStep2
            // 
            this.btnContinueStep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnContinueStep2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueStep2.Enabled = false;
            this.btnContinueStep2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueStep2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContinueStep2.Location = new System.Drawing.Point(3, 118);
            this.btnContinueStep2.Name = "btnContinueStep2";
            this.btnContinueStep2.Size = new System.Drawing.Size(298, 40);
            this.btnContinueStep2.TabIndex = 9;
            this.btnContinueStep2.Text = "Continue";
            this.btnContinueStep2.UseVisualStyleBackColor = false;
            // 
            // txtReEnter
            // 
            this.txtReEnter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReEnter.Depth = 0;
            this.txtReEnter.Enabled = false;
            this.txtReEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReEnter.Hint = "Re-Enter password:";
            this.txtReEnter.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtReEnter.LeadingIcon")));
            this.txtReEnter.Location = new System.Drawing.Point(3, 62);
            this.txtReEnter.MaxLength = 50;
            this.txtReEnter.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReEnter.Multiline = false;
            this.txtReEnter.Name = "txtReEnter";
            this.txtReEnter.Password = true;
            this.txtReEnter.Size = new System.Drawing.Size(333, 50);
            this.txtReEnter.TabIndex = 7;
            this.txtReEnter.Text = "";
            this.txtReEnter.TrailingIcon = null;
            // 
            // btnReadPw1
            // 
            this.btnReadPw1.BackColor = System.Drawing.SystemColors.Window;
            this.btnReadPw1.Enabled = false;
            this.btnReadPw1.Image = ((System.Drawing.Image)(resources.GetObject("btnReadPw1.Image")));
            this.btnReadPw1.Location = new System.Drawing.Point(342, 6);
            this.btnReadPw1.Name = "btnReadPw1";
            this.btnReadPw1.Size = new System.Drawing.Size(53, 50);
            this.btnReadPw1.TabIndex = 6;
            this.btnReadPw1.UseVisualStyleBackColor = false;
            // 
            // btnReadPw2
            // 
            this.btnReadPw2.BackColor = System.Drawing.SystemColors.Window;
            this.btnReadPw2.Enabled = false;
            this.btnReadPw2.Image = ((System.Drawing.Image)(resources.GetObject("btnReadPw2.Image")));
            this.btnReadPw2.Location = new System.Drawing.Point(342, 62);
            this.btnReadPw2.Name = "btnReadPw2";
            this.btnReadPw2.Size = new System.Drawing.Size(53, 50);
            this.btnReadPw2.TabIndex = 8;
            this.btnReadPw2.UseVisualStyleBackColor = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(404, 290);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Step 1: Enter your email address";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 108);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fQuenMatKhau_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot Password";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fQuenMatKhau_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(69, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your email address";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fQuenMatKhau_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnBackStep1);
            this.panel3.Controls.Add(this.btnAccept);
            this.panel3.Controls.Add(this.txtPin);
            this.panel3.Controls.Add(this.btnContinueStep1);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(398, 176);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fQuenMatKhau_MouseDown);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email:";
            this.txtEmail.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtEmail.LeadingIcon")));
            this.txtEmail.Location = new System.Drawing.Point(3, 6);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(392, 50);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // btnContinueStep1
            // 
            this.btnContinueStep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnContinueStep1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueStep1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueStep1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContinueStep1.Location = new System.Drawing.Point(3, 62);
            this.btnContinueStep1.Name = "btnContinueStep1";
            this.btnContinueStep1.Size = new System.Drawing.Size(298, 40);
            this.btnContinueStep1.TabIndex = 1;
            this.btnContinueStep1.Text = "Continue";
            this.btnContinueStep1.UseVisualStyleBackColor = false;
            // 
            // txtPin
            // 
            this.txtPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPin.Depth = 0;
            this.txtPin.Enabled = false;
            this.txtPin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPin.Hint = "Pin:";
            this.txtPin.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtPin.LeadingIcon")));
            this.txtPin.Location = new System.Drawing.Point(3, 108);
            this.txtPin.MaxLength = 50;
            this.txtPin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPin.Multiline = false;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(336, 50);
            this.txtPin.TabIndex = 3;
            this.txtPin.Text = "";
            this.txtPin.TrailingIcon = null;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Enabled = false;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.Location = new System.Drawing.Point(345, 108);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(50, 50);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.UseVisualStyleBackColor = false;
            // 
            // btnBackStep1
            // 
            this.btnBackStep1.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackStep1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackStep1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnBackStep1.Location = new System.Drawing.Point(307, 62);
            this.btnBackStep1.Name = "btnBackStep1";
            this.btnBackStep1.Size = new System.Drawing.Size(88, 40);
            this.btnBackStep1.TabIndex = 2;
            this.btnBackStep1.Text = "Back";
            this.btnBackStep1.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 320);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fQuenMatKhau_MouseDown);
            // 
            // btnBackStep2
            // 
            this.btnBackStep2.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackStep2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackStep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnBackStep2.Location = new System.Drawing.Point(307, 118);
            this.btnBackStep2.Name = "btnBackStep2";
            this.btnBackStep2.Size = new System.Drawing.Size(88, 40);
            this.btnBackStep2.TabIndex = 10;
            this.btnBackStep2.Text = "Back";
            this.btnBackStep2.UseVisualStyleBackColor = false;
            // 
            // fQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(436, 344);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fQuenMatKhau";
            this.Load += new System.EventHandler(this.fQuenMatKhau_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fQuenMatKhau_MouseDown);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBackStep1;
        private System.Windows.Forms.Button btnAccept;
        private MaterialSkin.Controls.MaterialTextBox txtPin;
        private System.Windows.Forms.Button btnContinueStep1;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBackStep2;
        private System.Windows.Forms.Button btnReadPw2;
        private System.Windows.Forms.Button btnReadPw1;
        private MaterialSkin.Controls.MaterialTextBox txtReEnter;
        private System.Windows.Forms.Button btnContinueStep2;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}