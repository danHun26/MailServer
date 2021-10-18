﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailServer
{
    public partial class fMail : Form
    {
        private int idPassLocal = 0;
        private int idDSMail = 0;
        public fMail()
        {
            InitializeComponent();
        }

        //Nhận id mật khẩu local [AddMail]
        public fMail(int idPassLocal) : this()
        {
            this.idPassLocal = idPassLocal;
        }

        //Nhận lại tên user trước đó [SendMail]
        public fMail(string cmbUserNameEmail, int idPassLocal) : this()
        {
            cmbEmail.Text = cmbUserNameEmail;
            this.idPassLocal = idPassLocal;
        }

        //Sự kiện chọn combobox để gửi mail mới
        private void btnNewMail_Click(object sender, EventArgs e)
        {
            try
            { 
                using (dbMailServerDataContext db = new dbMailServerDataContext())
                {
                    int temp = 0;
                    foreach (var item in db.DANHSACH_MAILs.ToList())
                    {
                        //Mail nháp
                        if (item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == true)
                        {
                            if (cmbEmail.Text == item.MATKHAU_MAIL.USERNAME_MAIL.ToString() && item.id == this.idDSMail)
                            {
                                temp = 1;
                                fSendMail fsm = new fSendMail(item.MATKHAU_MAIL.DOMAIN_MAIL.DOMAIN, item.MATKHAU_MAIL.DOMAIN_MAIL.PORT_MAIL,
                                                            item.MATKHAU_MAIL.USERNAME_MAIL, item.MATKHAU_MAIL.PASSWORD_MAIL,
                                                            item.MATKHAU_MAIL.id, item.NOIDUNG_MAIL.id, this.idPassLocal);
                                this.Hide();
                                fsm.ShowDialog();
                                this.Close();
                            }
                        }
                        //Thư mới
                        else if(item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == false)
                        {
                            if (cmbEmail.Text == item.MATKHAU_MAIL.USERNAME_MAIL.ToString())
                            {
                                temp = 1;
                                fSendMail fsm = new fSendMail(item.MATKHAU_MAIL.DOMAIN_MAIL.DOMAIN, item.MATKHAU_MAIL.DOMAIN_MAIL.PORT_MAIL,
                                                            item.MATKHAU_MAIL.USERNAME_MAIL, item.MATKHAU_MAIL.PASSWORD_MAIL, 
                                                            item.MATKHAU_MAIL.id, this.idPassLocal);
                                this.Hide();
                                fsm.ShowDialog();
                                this.Close();
                            }
                        }
                    }
                    if (temp == 0)
                    {
                        foreach (var item in db.MATKHAU_MAILs.ToList())
                        {
                            if (cmbEmail.Text == item.USERNAME_MAIL.ToString())
                            {
                                fSendMail fsm = new fSendMail(item.DOMAIN_MAIL.DOMAIN, item.DOMAIN_MAIL.PORT_MAIL,
                                                            item.USERNAME_MAIL, item.PASSWORD_MAIL, item.id, this.idPassLocal);
                                this.Hide();
                                fsm.ShowDialog();
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            fAddEmail fAddMail = new fAddEmail(this.idPassLocal);
            this.Hide();
            fAddMail.ShowDialog();
            this.Close();
        }

        private void dgvListMail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvListMail.Rows.Count - 1)
                {
                    DataGridViewRow row = dgvListMail.Rows[e.RowIndex];
                    using (dbMailServerDataContext db = new dbMailServerDataContext())
                    {
                        foreach (var item in db.DANHSACH_MAILs.ToList())
                            if (item.id.ToString() == row.Cells[1].Value.ToString())
                                this.idDSMail = item.id;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please contact the developer!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện load lại form
        private void fMail_Load(object sender, EventArgs e)
        {
            if (this.idPassLocal == 0)
            {
                fDangNhap fLogin = new fDangNhap();
                this.Hide();
                fLogin.ShowDialog();
                this.Close();
            }
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
