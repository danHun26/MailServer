using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MailServer
{
    public partial class fDocMail : Form
    {
        private int borderSize = 2;
        public fDocMail()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
        }


        private void fDocMail_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PhongTo_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Button bth = new Button();
            {
                bth.Text = "Thư Ba Xàm! , THu Tào Lao ,THu ádjasd";
                    bth.AutoSize = true;
                flowLayoutPanel1.Controls.Add(bth);
                fSendMail fSM = new fSendMail();
                fSM.ShowDialog();
            }
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã đăng nhập tài khoản Toan123@yahhooooooooo!");
        }
    }
}
