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
    }
}
