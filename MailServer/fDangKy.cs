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
using System.Security.Cryptography;

namespace MailServer
{
    public partial class fDangKy : Form
    {
        public fDangKy()
        {
            InitializeComponent();
        }

        //Di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Sự kiện đăng kí
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (txtUserName.Text == "" && txtReEnter.Text == "" && txtPassword.Text == "" &&
                    txtLastName.Text == "" && txtFirstName.Text == "" && txtEmail.Text == "")
                        throw new Exception("Enter completed information!");
                    else
                    {
                        using (dbMailServerDataContext db = new dbMailServerDataContext())
                        {
                            MATKHAU_LOCAL mkLocal = new MATKHAU_LOCAL();
                            THONGTIN_CLIENT infoClient = new THONGTIN_CLIENT();

                            //Kiểm tra tên dăng nhập và email
                            foreach (var item in db.MATKHAU_LOCALs.ToList())
                                if (item.USERNAME_LOCAL == txtUserName.Text)
                                    throw new Exception("This username already exists!");
                            foreach (var item in db.THONGTIN_CLIENTs.ToList())
                                if (item.EMAIL == txtEmail.Text)
                                    throw new Exception("This email already registered!");
         
                            //Insert dữ liệu vào MATKHAU_LOCAL
                            mkLocal.USERNAME_LOCAL = txtUserName.Text;
                            if (txtPassword.Text == "" && txtReEnter.Text == "")
                                throw new Exception("Enter completed information!");
                            else if (txtPassword.Text == txtReEnter.Text)
                            {
                                //using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                                //{
                                //    UTF8Encoding utf8 = new UTF8Encoding();
                                //    byte[] data = md5.ComputeHash(utf8.GetBytes(txtPassword.Text));
                                //    mkLocal.PASSWORD_LOCAL = Convert.ToBase64String(data);
                                //}
                                mkLocal.PASSWORD_LOCAL = Eramake.eCryptography.Encrypt(txtPassword.Text);
                            }
                            else
                            {
                                txtPassword.Text = "";
                                txtReEnter.Text = "";
                                throw new Exception("Wrong password, please re-enter!");
                            }
                            //Lưu vào MATKHAU_LOCAL
                            db.MATKHAU_LOCALs.InsertOnSubmit(mkLocal);
                            db.SubmitChanges();
                            //Insert dữ liệu vào THONGTIN_CLIENT
                            infoClient.HO = txtLastName.Text;
                            infoClient.TEN = txtFirstName.Text;
                            infoClient.EMAIL = txtEmail.Text;
                            infoClient.NTNS = dTBirth.Value;
                            //Lưu giá trị số giới tính
                            if (cmdSex.Text == "Male") infoClient.GIOITINH = 1;
                            else if (cmdSex.Text == "Female") infoClient.GIOITINH = 0;
                            else infoClient.GIOITINH = -1;
                            //Lấy khóa chính
                            int temp = 0;
                            foreach (var item in db.MATKHAU_LOCALs)
                            {
                                if (temp < item.id)
                                    temp = item.id;
                                    infoClient.FK_id_MATKHAU_LOCAL = item.id;
                            }
                            //Random mã pin
                            Random rdpin = new Random();
                            infoClient.MAPIN = rdpin.Next(100000, 999999);
                            infoClient.NGAYTAOTK = DateTime.Now.ToLocalTime();
                            //Lưu vào THONGTIN_CLIENT
                            db.THONGTIN_CLIENTs.InsertOnSubmit(infoClient);
                            db.SubmitChanges();
                            //Thông báo thành công   
                            MessageBox.Show("Successful registration information!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    fDangKy_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please contact the developer!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra trước khi thoát form
                if (txtUserName.Text == "" && txtReEnter.Text == "" && txtPassword.Text == "" && 
                    txtLastName.Text == "" && txtFirstName.Text == "" && txtEmail.Text == "")
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
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiên hiện mật khẩu
        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
            {
                txtPassword.Password = false;
                txtReEnter.Password = false;
            }
            else if (cbShowPass.Checked == false)
            {
                txtPassword.Password = true;
                txtReEnter.Password = true;
            }       
        }

        //Sự kiện load form đầu tiên
        private void fDangKy_Load(object sender, EventArgs e)
        {
            cmdSex.Text = "Male";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtReEnter.Text = "";
            txtUserName.Text = "";
            cbShowPass.Checked = false;

        }

        //Đồng hồ
        private void timer_Tick(object sender, EventArgs e)
        {
            lTime.Text = DateTime.Now.ToLongTimeString();
            lDate.Text = DateTime.Now.ToLongDateString();
            timer.Start();
        }

        //Đi đến đang nhập
        private void lBackLogin_Click(object sender, EventArgs e)
        {
            fDangNhap login = new fDangNhap();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
