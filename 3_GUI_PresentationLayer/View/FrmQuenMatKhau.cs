using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmQuenMatKhau : Form
    {
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            txt_Email.Select();
        }
        Random  random = new Random();
        int otp;
        private void iconButton1_Click(object sender, EventArgs e)
        {
            try {
                otp = random.Next(100000, 100000);
                var emailAddress = new MailAddress("hieunguyen10122000@gmail.com");
                var toEmail = new MailAddress(txt_Email.ToString());
                const string frompass = "dfnclphnfgkdnkpc";
                const string subject = "OTP code";

                string body = otp.ToString();
                var smtp = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(emailAddress.Address, frompass),
                    Timeout = 200000,

                };
                using (var messen = new MailMessage(emailAddress, toEmail)
                {
                    Subject = subject,
                    Body = body
                }) {
                    smtp.Send(messen);

                }
                MessageBox.Show("Vui lòng check email để nhận OTP");
                }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công");
            }
            }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if(otp.ToString().Equals(txt_OTP.Text))
            {
                txt_MK_New.Visible = true;
                txt_XacNhan_MK.Visible = true;
            }
            else
            {
                MessageBox.Show("OTP không chính xác");
            }
        }

        private void textBoxCustom2_03_Load(object sender, EventArgs e)
        {

        }
    }
}
