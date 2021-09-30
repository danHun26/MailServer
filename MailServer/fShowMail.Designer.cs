
namespace MailServer
{
    partial class fShowMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fShowMail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbEmail = new MaterialSkin.Controls.MaterialComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInbox = new System.Windows.Forms.Button();
            this.btnAllMail = new System.Windows.Forms.Button();
            this.btnStarred = new System.Windows.Forms.Button();
            this.btnDrafts = new System.Windows.Forms.Button();
            this.btnGarbage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.drvTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drvSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drvContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 86);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnGarbage);
            this.panel2.Controls.Add(this.btnDrafts);
            this.panel2.Controls.Add(this.btnStarred);
            this.panel2.Controls.Add(this.btnAllMail);
            this.panel2.Controls.Add(this.btnInbox);
            this.panel2.Controls.Add(this.cmbEmail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 475);
            this.panel2.TabIndex = 1;
            // 
            // cmbEmail
            // 
            this.cmbEmail.AutoResize = false;
            this.cmbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEmail.Depth = 0;
            this.cmbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbEmail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmail.DropDownHeight = 174;
            this.cmbEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmail.DropDownWidth = 121;
            this.cmbEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmail.FormattingEnabled = true;
            this.cmbEmail.IntegralHeight = false;
            this.cmbEmail.ItemHeight = 43;
            this.cmbEmail.Items.AddRange(new object[] {
            "minhhuanpbt26@gmail.com"});
            this.cmbEmail.Location = new System.Drawing.Point(0, 0);
            this.cmbEmail.MaxDropDownItems = 4;
            this.cmbEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmail.Name = "cmbEmail";
            this.cmbEmail.Size = new System.Drawing.Size(261, 49);
            this.cmbEmail.StartIndex = 0;
            this.cmbEmail.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(550, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 475);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(263, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 475);
            this.panel4.TabIndex = 3;
            // 
            // btnInbox
            // 
            this.btnInbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.btnInbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInbox.Image = ((System.Drawing.Image)(resources.GetObject("btnInbox.Image")));
            this.btnInbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInbox.Location = new System.Drawing.Point(0, 49);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(261, 50);
            this.btnInbox.TabIndex = 1;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInbox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInbox.UseVisualStyleBackColor = false;
            // 
            // btnAllMail
            // 
            this.btnAllMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.btnAllMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAllMail.Image = ((System.Drawing.Image)(resources.GetObject("btnAllMail.Image")));
            this.btnAllMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllMail.Location = new System.Drawing.Point(0, 99);
            this.btnAllMail.Name = "btnAllMail";
            this.btnAllMail.Size = new System.Drawing.Size(261, 50);
            this.btnAllMail.TabIndex = 1;
            this.btnAllMail.Text = "All mail";
            this.btnAllMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllMail.UseVisualStyleBackColor = false;
            // 
            // btnStarred
            // 
            this.btnStarred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.btnStarred.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStarred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStarred.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarred.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStarred.Image = ((System.Drawing.Image)(resources.GetObject("btnStarred.Image")));
            this.btnStarred.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStarred.Location = new System.Drawing.Point(0, 149);
            this.btnStarred.Name = "btnStarred";
            this.btnStarred.Size = new System.Drawing.Size(261, 50);
            this.btnStarred.TabIndex = 1;
            this.btnStarred.Text = "Starred";
            this.btnStarred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStarred.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStarred.UseVisualStyleBackColor = false;
            // 
            // btnDrafts
            // 
            this.btnDrafts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.btnDrafts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrafts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDrafts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrafts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDrafts.Image = ((System.Drawing.Image)(resources.GetObject("btnDrafts.Image")));
            this.btnDrafts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrafts.Location = new System.Drawing.Point(0, 199);
            this.btnDrafts.Name = "btnDrafts";
            this.btnDrafts.Size = new System.Drawing.Size(261, 50);
            this.btnDrafts.TabIndex = 1;
            this.btnDrafts.Text = "Drafts";
            this.btnDrafts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrafts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrafts.UseVisualStyleBackColor = false;
            // 
            // btnGarbage
            // 
            this.btnGarbage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.btnGarbage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGarbage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGarbage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGarbage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGarbage.Image = ((System.Drawing.Image)(resources.GetObject("btnGarbage.Image")));
            this.btnGarbage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGarbage.Location = new System.Drawing.Point(0, 249);
            this.btnGarbage.Name = "btnGarbage";
            this.btnGarbage.Size = new System.Drawing.Size(261, 50);
            this.btnGarbage.TabIndex = 1;
            this.btnGarbage.Text = "Garbage can";
            this.btnGarbage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGarbage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGarbage.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drvTo,
            this.drvSubject,
            this.drvContent});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(287, 475);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 401);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(534, 74);
            this.panel5.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(534, 401);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // drvTo
            // 
            this.drvTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.drvTo.HeaderText = "To";
            this.drvTo.Name = "drvTo";
            this.drvTo.Width = 81;
            // 
            // drvSubject
            // 
            this.drvSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.drvSubject.HeaderText = "Subject";
            this.drvSubject.Name = "drvSubject";
            this.drvSubject.Width = 83;
            // 
            // drvContent
            // 
            this.drvContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.drvContent.HeaderText = "Content";
            this.drvContent.Name = "drvContent";
            this.drvContent.Width = 82;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabSend);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Controls.Add(this.tabHelp);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 82);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.button1);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(1072, 56);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabSend
            // 
            this.tabSend.Location = new System.Drawing.Point(4, 22);
            this.tabSend.Name = "tabSend";
            this.tabSend.Size = new System.Drawing.Size(1072, 56);
            this.tabSend.TabIndex = 1;
            this.tabSend.Text = "Send/Receive";
            this.tabSend.UseVisualStyleBackColor = true;
            // 
            // tabHelp
            // 
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Size = new System.Drawing.Size(1072, 56);
            this.tabHelp.TabIndex = 2;
            this.tabHelp.Text = "Help";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // tabAccount
            // 
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(1072, 56);
            this.tabAccount.TabIndex = 3;
            this.tabAccount.Text = "Account";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fShowMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fShowMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inbox";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialComboBox cmbEmail;
        private System.Windows.Forms.Button btnGarbage;
        private System.Windows.Forms.Button btnDrafts;
        private System.Windows.Forms.Button btnStarred;
        private System.Windows.Forms.Button btnAllMail;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn drvTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn drvSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn drvContent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabSend;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Button button1;
    }
}