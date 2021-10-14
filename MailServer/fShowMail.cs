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
    public partial class fShowMail : Form
    {
        public fShowMail()
        {
            InitializeComponent();
        }

        string[] Scopes =
       {
            GmailService.Scope.GmailReadonly
        };

        GmailService service;
        string mEmail = "nhatnguyet202@gmail.com";
        string ApplicatonName = "Gmail";


        private void btnNewMail_Click(object sender, EventArgs e)
        {
            try
            {
                fSendMail fsm = new fSendMail("smtp.gmail.com", 587, "jamk1126@gmail.com",
                    "jamk@1230", 18, 1, 10);;
                fsm.ShowDialog();
                this.Close();
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
            //tạo đường dẫn xác minh
            UserCredential credential;
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read)) ;
            {
                string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");
                //credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(credPath, true)).Result;
            }

            //tạo Gmail API
            service = new GmailService(new BaseClientService.Initializer())
            {
                //HttpClientInitializer = credential,
                //ApplicationName = ApplicatonName,
            };

            var inboxlistReqiest = service.Users.Messages.List(mEmail);
            inboxlistReqiest.LabelIds = "INBOX";

            inboxlistReqiest.IncludeSpamTrash = false;

            //lấy thông tin email
            var emailListResponse = inboxlistReqiest.Execute();
            if (emailListResponse != null && emailListResponse.Messages != null)
            {
                //chọn trường email cần lấy
                foreach (var emai in emailListResponse.Messages)
                {
                    var emailInfoRequest = service.Users.Messages.Get(mEmail, emai.Id);
                    var emailInfoResponse = emailInfoRequest.Execute();
                    if(emailInfoResponse != null)
                    {
                        String from = "";
                        String date = "";
                        String subject = "";
                        //lấy địa chỉ, ngày gửi, tiêu đề
                        foreach(var mParts in emailInfoResponse.Payload.Headers)
                        {
                            if(mParts.Name == "Date")
                            {
                                date = mParts.Value;
                            }
                            else if(mParts.Name == "From")
                            {
                                from = mParts.Value;
                            }
                            else if(mParts.Name == "Subject")
                            {
                                subject = mParts.Value;
                            }
                        }
                        
                    }
                }
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
