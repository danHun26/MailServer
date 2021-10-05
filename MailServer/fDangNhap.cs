﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailServer
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        //Di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        //Sự kiện thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra trước khi thoát form
                if (txtUsername.Text == "" && txtPassword.Text == "")  this.Close();
                else
                {
                    DialogResult check = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                        this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện đồng hồ
        private void timer_Tick(object sender, EventArgs e)
        {
            lTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        //Sự kiện di chuyên form
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Sự kiên đăng kí
        private void label2_Click(object sender, EventArgs e)
        {
            fDangKy signup = new fDangKy();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }

        //Sự kiện đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    using(dbMailServerDataContext db = new dbMailServerDataContext())
                    {
                        if (txtPassword.Text == "" || txtUsername.Text == "") throw new Exception("Enter complete information!");
                        int temp = 0;
                        foreach (var item in db.MATKHAU_LOCALs.ToList())
                        {
                            if (item.USERNAME_LOCAL == txtUsername.Text 
                                && txtPassword.Text == Eramake.eCryptography.Decrypt(item.PASSWORD_LOCAL))
                            {
                                temp++;
                                fDangNhap_Load(sender, e);
                                throw new Exception("Đăng nhập thành công!");
                            }
                        }
                        if (temp == 0)
                        {
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtUsername.Hint = "Re-enter username";
                            txtPassword.Hint = "Re-enter password";
                            throw new Exception("Username or password is incorrect!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please contact the developer!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện đăng nhập
        private void fDangNhap_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Hint = "Username:";
            txtPassword.Hint = "Password:";
        }
    }
}
