
namespace MailServer
{
    partial class fGuiMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGuiMail));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởEmailNhápToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gửiThưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chữDậmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chữNghiênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chữGạchChânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaNộiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rTxtContent = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtPathAttach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.messageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởEmailNhápToolStripMenuItem,
            this.lưuToolStripMenuItem,
            this.gửiThưToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // mởEmailNhápToolStripMenuItem
            // 
            this.mởEmailNhápToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mởEmailNhápToolStripMenuItem.Image")));
            this.mởEmailNhápToolStripMenuItem.Name = "mởEmailNhápToolStripMenuItem";
            this.mởEmailNhápToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.mởEmailNhápToolStripMenuItem.Text = "Mở thư nháp";
            this.mởEmailNhápToolStripMenuItem.Click += new System.EventHandler(this.mởEmailNhápToolStripMenuItem_Click);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lưuToolStripMenuItem.Image")));
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.lưuToolStripMenuItem.Text = "Lưu thư";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // gửiThưToolStripMenuItem
            // 
            this.gửiThưToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gửiThưToolStripMenuItem.Image")));
            this.gửiThưToolStripMenuItem.Name = "gửiThưToolStripMenuItem";
            this.gửiThưToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.gửiThưToolStripMenuItem.Text = "Gửi thư";
            this.gửiThưToolStripMenuItem.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chữDậmToolStripMenuItem,
            this.chữNghiênToolStripMenuItem,
            this.chữGạchChânToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // chữDậmToolStripMenuItem
            // 
            this.chữDậmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chữDậmToolStripMenuItem.Image")));
            this.chữDậmToolStripMenuItem.Name = "chữDậmToolStripMenuItem";
            this.chữDậmToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.chữDậmToolStripMenuItem.Text = "Chữ dậm";
            this.chữDậmToolStripMenuItem.Click += new System.EventHandler(this.chữDậmToolStripMenuItem_Click);
            // 
            // chữNghiênToolStripMenuItem
            // 
            this.chữNghiênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chữNghiênToolStripMenuItem.Image")));
            this.chữNghiênToolStripMenuItem.Name = "chữNghiênToolStripMenuItem";
            this.chữNghiênToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.chữNghiênToolStripMenuItem.Text = "Chữ nghiêng";
            this.chữNghiênToolStripMenuItem.Click += new System.EventHandler(this.chữNghiênToolStripMenuItem_Click);
            // 
            // chữGạchChânToolStripMenuItem
            // 
            this.chữGạchChânToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chữGạchChânToolStripMenuItem.Image")));
            this.chữGạchChânToolStripMenuItem.Name = "chữGạchChânToolStripMenuItem";
            this.chữGạchChânToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.chữGạchChânToolStripMenuItem.Text = "Chữ gạch chân";
            this.chữGạchChânToolStripMenuItem.Click += new System.EventHandler(this.chữGạchChânToolStripMenuItem_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaNộiDungToolStripMenuItem,
            this.trangMớiToolStripMenuItem});
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.messageToolStripMenuItem.Text = "Message";
            // 
            // xóaNộiDungToolStripMenuItem
            // 
            this.xóaNộiDungToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xóaNộiDungToolStripMenuItem.Image")));
            this.xóaNộiDungToolStripMenuItem.Name = "xóaNộiDungToolStripMenuItem";
            this.xóaNộiDungToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.xóaNộiDungToolStripMenuItem.Text = "Xóa nội dung";
            this.xóaNộiDungToolStripMenuItem.Click += new System.EventHandler(this.xóaNộiDungToolStripMenuItem_Click);
            // 
            // trangMớiToolStripMenuItem
            // 
            this.trangMớiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trangMớiToolStripMenuItem.Image")));
            this.trangMớiToolStripMenuItem.Name = "trangMớiToolStripMenuItem";
            this.trangMớiToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.trangMớiToolStripMenuItem.Text = "Trang mới";
            this.trangMớiToolStripMenuItem.Click += new System.EventHandler(this.trangMớiToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel6.Controls.Add(this.txtFrom);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(89, 3);
            this.panel6.Name = "panel6";
            this.panel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel6.Size = new System.Drawing.Size(768, 26);
            this.panel6.TabIndex = 1;
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFrom.Enabled = false;
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(63, 4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(702, 15);
            this.txtFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "From:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.txtTo);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(89, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(768, 26);
            this.panel5.TabIndex = 1;
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(63, 4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(692, 15);
            this.txtTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "To:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.txtSubject);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(89, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(768, 26);
            this.panel4.TabIndex = 1;
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(63, 4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(702, 15);
            this.txtSubject.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject:";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(3, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(83, 90);
            this.btnSend.TabIndex = 0;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.rTxtContent);
            this.panel2.Location = new System.Drawing.Point(12, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 358);
            this.panel2.TabIndex = 5;
            // 
            // rTxtContent
            // 
            this.rTxtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtContent.Location = new System.Drawing.Point(3, 3);
            this.rTxtContent.Name = "rTxtContent";
            this.rTxtContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rTxtContent.Size = new System.Drawing.Size(854, 355);
            this.rTxtContent.TabIndex = 4;
            this.rTxtContent.Text = "Nội dung Email!";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtIdentification);
            this.panel3.Controls.Add(this.btnBrowser);
            this.panel3.Controls.Add(this.txtPathAttach);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 500);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 49);
            this.panel3.TabIndex = 6;
            // 
            // txtIdentification
            // 
            this.txtIdentification.Enabled = false;
            this.txtIdentification.Location = new System.Drawing.Point(664, 15);
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.ReadOnly = true;
            this.txtIdentification.Size = new System.Drawing.Size(191, 20);
            this.txtIdentification.TabIndex = 8;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(573, 13);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(85, 23);
            this.btnBrowser.TabIndex = 6;
            this.btnBrowser.Text = "Browser...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtPathAttach
            // 
            this.txtPathAttach.Location = new System.Drawing.Point(96, 13);
            this.txtPathAttach.Name = "txtPathAttach";
            this.txtPathAttach.Size = new System.Drawing.Size(471, 20);
            this.txtPathAttach.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tệp đính kèm:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // fGuiMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fGuiMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Không tiêu đề - Thư";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rTxtContent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtPathAttach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem mởEmailNhápToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gửiThưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chữDậmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chữNghiênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chữGạchChânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaNộiDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangMớiToolStripMenuItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}