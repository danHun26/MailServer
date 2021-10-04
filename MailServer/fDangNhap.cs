using System;
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

        private void timer_Tick(object sender, EventArgs e)
        {
            lTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            fDangKy signup = new fDangKy();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }
    }
}
