using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmQuenMatKhau : Form
    {
        INhanVienService _BUS_NhanViens;
        List<NhanVien> _lst_NhanVienl;

        public FrmQuenMatKhau()
        {
            _BUS_NhanViens = new NhanvienService();
            _lst_NhanVienl = new List<NhanVien>();
            InitializeComponent();
            txt_Email.Select();
        }
        Random random = new Random();
        private int _randomCode;

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var a = _BUS_NhanViens.GetAllNhanViens().FirstOrDefault(nv => nv.Email == txt_Email.Text);
            if (a == null)
            {
                MessageBox.Show("Email không tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                _randomCode = new Random().Next(100000, 999999);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("maituandat087804@gmail.com");
                mail.To.Add(txt_Email.Texts);
                mail.Body = "Ma code cua ban la: " + _randomCode;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                NetworkCredential nc = new NetworkCredential();
                nc.UserName = "maituandat087804@gmail.com";
                nc.Password = "dyeeqsadlarqjync";
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(mail);
                MessageBox.Show("Gui thanh cong");
                txt_Email.Enabled = false;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (txt_OTP.Texts == _randomCode.ToString())
            {
                txt_MK_New.Visible = true;
                txt_XacNhan_MK.Visible = true;

                MessageBox.Show("Ma chinh xac");
                return;
            }


            MessageBox.Show("Otp sai");

        }

        private void textBoxCustom2_03_Load(object sender, EventArgs e)
        {

        }

        private void buttonCustom1_Click(object sender, EventArgs e)
        {
            if (txt_MK_New.Texts == txt_XacNhan_MK.Texts)
            {
                var x = _BUS_NhanViens.GetAllNhanViens().FirstOrDefault(e => e.Email == txt_Email.Texts).Id;
                var a = _BUS_NhanViens.GetAllNhanViens().FirstOrDefault(e => e.Id == x);
                a.MatKhau = txt_MK_New.Text;
                _BUS_NhanViens.UpdateNV(a);
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Hide();
                FrmDangNhap frmdn = new FrmDangNhap();
                frmdn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không thành công vui lòng kiểm tra lại mật khẩu mới đã nhập");
            }
        }

        private void FrmQuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void FrmQuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FrmDangNhap frmdn = new FrmDangNhap();
            frmdn.ShowDialog();
        }
    }
}
