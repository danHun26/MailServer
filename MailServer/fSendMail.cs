using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Threading;

namespace MailServer
{
    public partial class fSendMail : Form
    {
        private string serverMail;
        private int portServerMail;
        private string userMailAcc;
        private string passMailAcc;

        //Constructor mặc định
        public fSendMail()
        {
            InitializeComponent();
        }

        //Constructor có tham số truyền vào từ form show mail
        public fSendMail(string serverMail, int portServerMail, string userMailAcc, string passMailAcc) : this()
        {
            txtFrom.Text = userMailAcc;

            this.serverMail = serverMail;
            this.portServerMail = portServerMail;
            this.userMailAcc = userMailAcc;
            this.passMailAcc = passMailAcc;
        }

        //bấm nút gửi thư
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    MailMessage mail = new MailMessage(this.userMailAcc, txtTo.Text, txtSubject.Text, rTxtContent.Text);
                    mail.IsBodyHtml = true;
                    if (File.Exists(txtPathAttach.Text))
                    {
                        Attachment fAttach = new Attachment(txtPathAttach.Text);
                        mail.Attachments.Add(fAttach);
                    }

                    SmtpClient client = new SmtpClient(this.serverMail);
                    client.UseDefaultCredentials = false;
                    client.Port = this.portServerMail;
                    client.Credentials = new System.Net.NetworkCredential(this.userMailAcc, this.passMailAcc);
                    client.EnableSsl = true;
                    client.Send(mail);

                    MessageBox.Show("Đã gửi mail thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã gửi mail thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Chọn file đính kèm
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    txtPathAttach.Text = openFileDialog.FileName;

                if (txtPathAttach.Text.Contains(".png") || txtPathAttach.Text.Contains(".jpg") || txtPathAttach.Text.Contains(".jpeg"))
                {
                    if (txtPathAttach.Text.Contains(".png"))
                        txtIdentification.Text = "File kèm là: ẢNH RAW";
                    if (txtPathAttach.Text.Contains(".jpg") || txtPathAttach.Text.Contains(".jpeg"))
                        txtIdentification.Text = "File kèm: ẢNH";
                }
                else if (txtPathAttach.Text.Contains(".doc") || txtPathAttach.Text.Contains(".docx"))
                {
                    txtIdentification.Text = "File kèm: WORD";
                }
                else if (txtPathAttach.Text.Contains(".xls") || txtPathAttach.Text.Contains(".xlsx") || txtPathAttach.Text.Contains(".xlsm"))
                {
                    txtIdentification.Text = "File kèm: EXCEL";
                }
                else if (txtPathAttach.Text.Contains(".pptx"))
                {
                    txtIdentification.Text = "File kèm: POWER PORINT";
                }
                else if (txtPathAttach.Text.Contains(".pdf"))
                {
                    txtIdentification.Text = "File kèm: PDF ";
                }
                else if (txtPathAttach.Text.Contains(".txt"))
                {
                    txtIdentification.Text = "File kèm: TEXT";
                }
                else
                    txtIdentification.Text = "File kèm: KHÔNG XÁC ĐỊNH";
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Chữ đậm
        private void chữĐậmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                rTxtContent.Font = new Font(rTxtContent.Font, FontStyle.Bold);
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Chữ nghiên
        private void chữNghiênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rTxtContent.Font = new Font(rTxtContent.Font, FontStyle.Italic);
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Chữ gạch chân
        private void chữGạchChânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rTxtContent.Font = new Font(rTxtContent.Font, FontStyle.Underline);
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Mở thư nháp
        private void mởThưNhápToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //<> thunhap = new <>;
                this.Hide();
                //thunhap.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Thoát soạn mail
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult check = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    //phát hiện yes thì close()
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Xóa nội dung mail
        private void xóaNộiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rTxtContent.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Tạo trang mới
        private void tạoThưMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fSendMail newMail = new fSendMail(this.serverMail, this.portServerMail, this.userMailAcc, this.passMailAcc);
                this.Hide();
                newMail.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Lưu thư vào nháp
        private void lưuThưToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rTxtContent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
