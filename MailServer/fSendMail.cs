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
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace MailServer
{
    public partial class fSendMail : Form
    {
        private string serverMail = "";
        private int portServerMail = 0;
        private string userMailAcc = "";
        private string passMailAcc = "";
        private int idpassMail = 0;
        private int idTempMail = 0;
        private int classifyMail = 0;

        //Di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Constructor mặc định
        public fSendMail()
        {
            InitializeComponent();
        }

        //Constructor có tham số cho mail mới
        public fSendMail(string serverMail, int portServerMail, string userMailAcc, 
            string passMailAcc, int idpassMail) : this()
        {
            txtFromMail.Text = userMailAcc;

            this.serverMail = serverMail;
            this.portServerMail = portServerMail;
            this.userMailAcc = userMailAcc;
            this.passMailAcc = passMailAcc;
            this.idpassMail = idpassMail;
        }

        ////Constructor có tham số mở mail nháp
        public fSendMail(string serverMail, int portServerMail, string userMailAcc, 
            string passMailAcc, int idpassMail, int idTempMail) : this()
        {
            this.serverMail = serverMail;
            this.portServerMail = portServerMail;
            this.userMailAcc = userMailAcc;
            this.passMailAcc = passMailAcc;
            this.idpassMail = idpassMail;
            this.idTempMail = idTempMail;
            this.classifyMail = 1;
        }

        //bấm nút gửi thư
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                    if (Regex.IsMatch(txtToMail.Text, pattern) == false)
                        throw new Exception("Định dạng email gửi không đúng.");

                    MailMessage mail = new MailMessage(this.userMailAcc, txtToMail.Text, txtSubjectMail.Text, rTxtContent.Text);
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
                    try
                    {
                        client.Send(mail);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Gửi mail thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("Gửi mail thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (this.classifyMail == 0)
                    {
                        //Lưu vào database
                        using (dbMailServerDataContext db = new dbMailServerDataContext())
                        {
                            int tempIDNDMail = 0;
                            int tempIDStatus = 0;

                            DANHSACH_MAIL dsMail = new DANHSACH_MAIL();
                            NOIDUNG_MAIL ndMail = new NOIDUNG_MAIL();
                            TRANG_THAI status = new TRANG_THAI();

                            //TRẠNG THÁI
                            status.DANHDAU = false;
                            status.XOATHU = false;
                            status.STATUS_MAIL = false;
                            status.UPDATE_TIME_MAIL = DateTime.Now.ToLocalTime();
                            db.TRANG_THAIs.InsertOnSubmit(status);
                            db.SubmitChanges();

                            //NỘI DUNG MAIL
                            ndMail.FROM_MAIL = txtFromMail.Text;
                            ndMail.TO_MAIL = txtToMail.Text;
                            ndMail.SUBJECT_MAIL = txtSubjectMail.Text;
                            ndMail.CONTENT_MAIL = rTxtContent.Text;
                            ndMail.PATH_ATTACH = txtPathAttach.Text;

                            foreach (var item in db.TRANG_THAIs.ToList())
                            {
                                if (tempIDStatus < item.id)
                                    tempIDStatus = item.id;
                                ndMail.FK_id_TRANG_THAI = tempIDStatus;
                            }
                            db.NOIDUNG_MAILs.InsertOnSubmit(ndMail);
                            db.SubmitChanges();

                            //DANH SÁCH MAIL
                            dsMail.THOIGIAN_GUI = DateTime.Now.ToLocalTime();
                            dsMail.FK_id_MATKHAU_MAIL = this.idpassMail;
                            foreach (var item in db.NOIDUNG_MAILs.ToList())
                            {
                                if (tempIDNDMail < item.id)
                                    tempIDNDMail = item.id;
                                dsMail.FK_id_NOIDUNG_MAIL = tempIDNDMail;
                            }
                            db.DANHSACH_MAILs.InsertOnSubmit(dsMail);
                            db.SubmitChanges();
                        }
                    }
                    else
                    {
                        using (dbMailServerDataContext db = new dbMailServerDataContext())
                        {
                            NOIDUNG_MAIL ndMail = new NOIDUNG_MAIL();
                            ndMail = db.NOIDUNG_MAILs.Where(s => s.id == this.idTempMail).Single();
                            ndMail.TRANG_THAI.STATUS_MAIL = false;
                            ndMail.TO_MAIL = txtToMail.Text;
                            ndMail.SUBJECT_MAIL = txtSubjectMail.Text;
                            ndMail.CONTENT_MAIL = rTxtContent.Text;
                            ndMail.PATH_ATTACH = txtPathAttach.Text;
                            db.SubmitChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    else if (txtPathAttach.Text.Contains(".jpg") || txtPathAttach.Text.Contains(".jpeg"))
                        txtIdentification.Text = "File kèm: ẢNH";
                }    
                else if (txtPathAttach.Text.Contains(".doc") || txtPathAttach.Text.Contains(".docx"))
                    txtIdentification.Text = "File kèm: WORD";
                else if (txtPathAttach.Text.Contains(".xls") || txtPathAttach.Text.Contains(".xlsx") || txtPathAttach.Text.Contains(".xlsm"))
                    txtIdentification.Text = "File kèm: EXCEL";
                else if (txtPathAttach.Text.Contains(".pptx"))
                    txtIdentification.Text = "File kèm: POWER PORINT";
                else if (txtPathAttach.Text.Contains(".pdf"))
                    txtIdentification.Text = "File kèm: PDF ";
                else if (txtPathAttach.Text.Contains(".txt"))
                    txtIdentification.Text = "File kèm: TEXT";
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
            rTxtContent.Font = new Font(rTxtContent.Font, FontStyle.Bold);
        }

        //Chữ nghiên
        private void chữNghiênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtContent.Font = new Font(rTxtContent.Font, FontStyle.Italic);
        }

        //Chữ gạch chân
        private void chữGạchChânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtContent.Font = new Font(rTxtContent.Font, FontStyle.Underline);
        }

        //Thoát soạn mail
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(txtFromMail.Text == "" && txtPathAttach.Text == "" && txtSubjectMail.Text == "" && txtToMail.Text == "" && rTxtContent.Text == "")
            {
                fShowMail fSM = new fShowMail();
                this.Hide();
                fSM.ShowDialog();
                this.Close();
            }
            else
            {
                DialogResult check = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    fShowMail fSM = new fShowMail();
                    this.Hide();
                    fSM.ShowDialog();
                    this.Close();
                }
            }
        }

        //Xóa nội dung mail
        private void xóaNộiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtContent.Clear();
        }

        //Tạo trang mới
        private void tạoThưMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSendMail_Load(sender, e);
        }

        //Lưu thư vào nháp
        private void lưuThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                //Lưu vào database
                using (dbMailServerDataContext db = new dbMailServerDataContext())
                {
                    int tempIDNDMail = 0;
                    int tempIDStatus = 0;

                    DANHSACH_MAIL dsMail = new DANHSACH_MAIL();
                    NOIDUNG_MAIL ndMail = new NOIDUNG_MAIL();
                    TRANG_THAI status = new TRANG_THAI();

                    //TRẠNG THÁI
                    status.DANHDAU = false;
                    status.XOATHU = false;
                    status.STATUS_MAIL = true;
                    status.UPDATE_TIME_MAIL = DateTime.Now.ToLocalTime();
                    db.TRANG_THAIs.InsertOnSubmit(status);
                    db.SubmitChanges();

                    //NỘI DUNG MAIL
                    ndMail.FROM_MAIL = txtFromMail.Text;
                    ndMail.TO_MAIL = txtToMail.Text;
                    ndMail.SUBJECT_MAIL = txtSubjectMail.Text;
                    ndMail.CONTENT_MAIL = rTxtContent.Text;
                    ndMail.PATH_ATTACH = txtPathAttach.Text;
                    foreach (var item in db.TRANG_THAIs.ToList())
                    {
                        if (tempIDStatus < item.id)
                            tempIDStatus = item.id;
                        ndMail.FK_id_TRANG_THAI = tempIDStatus;
                    }
                    db.NOIDUNG_MAILs.InsertOnSubmit(ndMail);
                    db.SubmitChanges();

                    //DANH SÁCH MAIL
                    dsMail.THOIGIAN_GUI = DateTime.Now.ToLocalTime();
                    dsMail.FK_id_MATKHAU_MAIL = this.idpassMail;
                    foreach (var item in db.NOIDUNG_MAILs.ToList())
                    {
                        if (tempIDNDMail < item.id)
                            tempIDNDMail = item.id;
                        dsMail.FK_id_NOIDUNG_MAIL = tempIDNDMail;
                    }
                    db.DANHSACH_MAILs.InsertOnSubmit(dsMail);
                    db.SubmitChanges();
                    MessageBox.Show("Lưu vào thư nháp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fShowMail fSM = new fShowMail();
                    this.Hide();
                    fSM.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowser1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    txtPathAttach.Text = openFileDialog.FileName;

                if (txtPathAttach.Text.Contains(".png") || txtPathAttach.Text.Contains(".jpg") || txtPathAttach.Text.Contains(".jpeg"))
                {
                    if (txtPathAttach.Text.Contains(".png"))
                        txtIdentification.Text = "File: ẢNH RAW";
                    else if (txtPathAttach.Text.Contains(".jpg") || txtPathAttach.Text.Contains(".jpeg"))
                        txtIdentification.Text = "File: ẢNH";
                }
                else if (txtPathAttach.Text.Contains(".doc") || txtPathAttach.Text.Contains(".docx"))
                    txtIdentification.Text = "File: WORD";
                else if (txtPathAttach.Text.Contains(".xls") || txtPathAttach.Text.Contains(".xlsx") || txtPathAttach.Text.Contains(".xlsm"))
                    txtIdentification.Text = "File: EXCEL";
                else if (txtPathAttach.Text.Contains(".pptx"))
                    txtIdentification.Text = "File: POWER PORINT";
                else if (txtPathAttach.Text.Contains(".pdf"))
                    txtIdentification.Text = "File: PDF ";
                else if (txtPathAttach.Text.Contains(".txt"))
                    txtIdentification.Text = "File: TEXT";
                else
                    txtIdentification.Text = "File: OTHER";
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Di chuyển form
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Load form
        private void fSendMail_Load(object sender, EventArgs e)
        {
            if (this.classifyMail == 0)
            {
                txtFromMail.Text = this.userMailAcc;
                txtIdentification.Text = "File: ";
                txtPathAttach.Text = "";
                txtSubjectMail.Text = "";
                txtToMail.Text = "";
                rTxtContent.Text = "";
            }
            else
            {
                using (dbMailServerDataContext db = new dbMailServerDataContext())
                {
                    foreach (var item in db.NOIDUNG_MAILs.ToList())
                    {
                        if (item.id == this.idTempMail)
                        {
                            txtFromMail.Text = item.FROM_MAIL;
                            txtToMail.Text = item.TO_MAIL;
                            txtSubjectMail.Text = item.SUBJECT_MAIL;
                            rTxtContent.Text = item.CONTENT_MAIL;
                            txtPathAttach.Text = item.PATH_ATTACH;
                        }
                    }
                }
            }
        }
    }
}
