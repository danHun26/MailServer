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
    public partial class fFeedBack : Form
    {
        public fFeedBack()
        {
            InitializeComponent();
        }

        private void fFeedBack_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã phản hồi cho chúng tôi..", "Phản hồi thành công.", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
