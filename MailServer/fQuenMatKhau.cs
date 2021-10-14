﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MailServer
{
    public partial class fQuenMatKhau : Form
    {
        private string userMailAcc = "jamk1126@gmail.com";
        private string userMailPass = "jamk@1230";
        private string subject = "[MailBox] Mã khôi phục tài khoản của bạn!";
        private string content = "";
        private int idMK = 0;
        private int tempShowPass = 0;
        public fQuenMatKhau()
        {
            InitializeComponent();
        }

        //Di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void fQuenMatKhau_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Sự kiện khôi phục mật khẩu
        private void btnContinueStep1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (txtEmail.Text == "")
                        throw new Exception("Nhập email để khôi phục tài khoản!");
                    else
                    {
                        using (dbMailServerDataContext db = new dbMailServerDataContext())
                        {
                            string emailClient = "";
                            foreach (var item in db.THONGTIN_CLIENTs.ToList())
                            {
                                if (txtEmail.Text == item.EMAIL.ToString())
                                {
                                    emailClient = item.EMAIL.ToString();
                                    this.content =  $"Chào {item.TEN}." + System.Environment.NewLine + 
                                                    $"Vui lòng sử dụng mã bảo mật sau cho tài khoản MailBox: {item.EMAIL}." + System.Environment.NewLine + 
                                                    $"Mã bảo mật: {item.MAPIN}" + Environment.NewLine + 
                                                    $"Hãy nhập mã trên để khôi phục tải khoản MailBox." + System.Environment.NewLine + 
                                                    $"Xin cảm ơn!";
                                    foreach (var item2 in db.MATKHAU_LOCALs.ToList())
                                        if (item.FK_id_MATKHAU_LOCAL == item2.id)
                                            this.idMK = item2.id;
                                    break;
                                }
                            }
                            if (emailClient == "") throw new Exception("Email chưa được đăng ký!");
                            else
                            {
                                MailMessage mail = new MailMessage(this.userMailAcc, emailClient, this.subject.ToString(), this.content.ToString());
                                mail.IsBodyHtml = true;
                                SmtpClient client = new SmtpClient("smtp.gmail.com");
                                client.UseDefaultCredentials = false;
                                client.Port = 587;
                                client.Credentials = new System.Net.NetworkCredential(this.userMailAcc, this.userMailPass);
                                client.EnableSsl = true;
                                client.Send(mail);

                                txtPin.Enabled = true;
                                btnAccept.Enabled = true;

                                MessageBox.Show("Gửi mail xác nhận thành công." + Environment.NewLine + "Vui lòng nhập mã để khôi phục tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please contact the developer!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện xác nhận mã pin
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    using (dbMailServerDataContext db = new dbMailServerDataContext())
                    {
                        int temp = 0;
                        foreach (var item in db.THONGTIN_CLIENTs.ToList())
                        {
                            if (txtPin.Text == item.MAPIN.ToString())
                            {
                                temp = 1;
                                txtPassword.Enabled = true;
                                txtReEnter.Enabled = true;
                                btnContinueStep2.Enabled = true;
                                btnReadPw1.Enabled = true;
                                btnReadPw2.Enabled = true;
                                throw new Exception("Xác nhận mã pin thành công" + Environment.NewLine + "Mời qua bước 2 đặt lại mật khẩu mới!");
                            }
                        }
                        if (temp == 0) throw new Exception("Mã khôi phục không chính xác!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please contact the developer!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện quay lại đăng nhập
        private void btnBackStep1_Click(object sender, EventArgs e)
        {
            //Kiểm tra trước khi thoát 
            if (txtEmail.Text == "" && txtPassword.Text == "" && txtPin.Text == "" && txtReEnter.Text == "")
            {
                fDangNhap dn = new fDangNhap();
                this.Hide();
                dn.ShowDialog();
                this.Close();
            }
            else
            {
                DialogResult check = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    fDangNhap dn = new fDangNhap();
                    this.Hide();
                    dn.ShowDialog();
                    this.Close();
                }
            }
        }

        //Hiển thị mật khẩu
        private void btnReadPw1_Click(object sender, EventArgs e)
        {
            tempShowPass++;
            if(tempShowPass%2 == 0)
            {
                txtPassword.Password = true;
                txtReEnter.Password = true;
            }
            else
            {
                txtPassword.Password = false;
                txtReEnter.Password = false;
            }
        }

        //Thay đổi mật khẩu
        private void btnContinueStep2_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (txtPassword.Text == "" || txtReEnter.Text == "") throw new Exception("Nhập mật khẩu mới để khôi phục!");
                    else
                    {
                        using (dbMailServerDataContext db = new dbMailServerDataContext())
                        {
                            MATKHAU_LOCAL mkLocal = new MATKHAU_LOCAL();
                            THONGTIN_CLIENT infoClient = new THONGTIN_CLIENT();
                            mkLocal = db.MATKHAU_LOCALs.Where(s => s.id == this.idMK).Single();
                            infoClient = db.THONGTIN_CLIENTs.Where(s => s.FK_id_MATKHAU_LOCAL == this.idMK).Single();
                            if (txtPassword.Text == txtReEnter.Text)
                            {
                                mkLocal.PASSWORD_LOCAL = Eramake.eCryptography.Encrypt(txtPassword.Text);
                                //Random mã pin mới
                                Random rdpin = new Random();
                                infoClient.MAPIN = rdpin.Next(100000, 999999);

                                DialogResult check = MessageBox.Show("Xác nhận khôi phục mật khẩu!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (check == DialogResult.Yes)
                                {
                                    db.SubmitChanges();
                                    MessageBox.Show("Khôi phục mật khẩu thành công." + System.Environment.NewLine + "Quay lại cửa sổ đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                }
                            }
                            else
                                throw new Exception("Nhập lại password không chính xác!");
                        }
                        fQuenMatKhau_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please contact the developer!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Sự kiên load lại form
        private void fQuenMatKhau_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtPin.Text = "";
            txtReEnter.Text = "";
            txtPin.Enabled = false;
            btnAccept.Enabled = false;
            txtPassword.Enabled = false;
            btnContinueStep2.Enabled = false;
            btnReadPw1.Enabled = false;
            txtReEnter.Enabled = false;
            btnReadPw2.Enabled = false;
        }
    }
}
