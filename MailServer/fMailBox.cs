using System;
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
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;


namespace MailServer
{
    public partial class fMailBox : Form
    {
        private int idPassLocal = 0;
        private int idDSMail = 0;

        public fMailBox()
        {
            InitializeComponent();
        }

        //Nhận id mật khẩu local
        public fMailBox(int idPassLocal)
        {
            this.idPassLocal = idPassLocal;
        }

        private void btnNewMail_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbMailServerDataContext db = new dbMailServerDataContext())
                {
                    foreach (var item in db.MATKHAU_MAILs.ToList())
                    {
                        if (idDSMail == 0)
                        {
                            if (cmbEmail.Text.Contains("gmail") && cmbEmail.Text == item.USERNAME_MAIL.ToString())
                            {
                                fSendMail fsm = new fSendMail(item.DOMAIN_MAIL.DOMAIN, item.DOMAIN_MAIL.PORT_MAIL,
                                                            item.USERNAME_MAIL, item.PASSWORD_MAIL, item.id);
                                fsm.ShowDialog();
                                this.Close();
                            }
                            else if (cmbEmail.Text.Contains("yahoo") && cmbEmail.Text == item.USERNAME_MAIL.ToString())
                            {
                                fSendMail fsm = new fSendMail(item.DOMAIN_MAIL.DOMAIN, item.DOMAIN_MAIL.PORT_MAIL,
                            item.USERNAME_MAIL, item.PASSWORD_MAIL, item.id);
                                fsm.ShowDialog();
                                this.Close();
                            }
                            else if (cmbEmail.Text.Contains("outlook") && cmbEmail.Text == item.USERNAME_MAIL.ToString())
                            {
                                fSendMail fsm = new fSendMail(item.DOMAIN_MAIL.DOMAIN, item.DOMAIN_MAIL.PORT_MAIL,
                            item.USERNAME_MAIL, item.PASSWORD_MAIL, item.id);
                                fsm.ShowDialog();
                                this.Close();
                            }
                           
                        }
                        else
                        {

                        }
                    } 
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void fShowMail_Load(object sender, EventArgs e)
        {

        }

        private void btnAllMail_Click(object sender, EventArgs e)
        {

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

        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            fAddEmail fAddMail = new fAddEmail();
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
                        {
                            if (item.id.ToString() == row.Cells[1].Value.ToString())
                            {
                                this.idDSMail = item.id;
                            }
                        }
                    }
                }

            }
            catch (Exception) { }
        }
    }
}
