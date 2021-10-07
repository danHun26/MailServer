using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailServer
{
    public partial class fShowMail : Form
    {
        public fShowMail()
        {
            InitializeComponent();
        }


        private void btnNewMail_Click(object sender, EventArgs e)
        {
            try
            {
                fSendMail fsm = new fSendMail();
                fsm.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                fFeedBack fsm = new fFeedBack();
                fsm.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã thoát khỏi ứng dụng.");
            this.Close();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiền bạn hãy liên lạc với chúng tôi qua Hotline:0123456789");
        }
    }
}
