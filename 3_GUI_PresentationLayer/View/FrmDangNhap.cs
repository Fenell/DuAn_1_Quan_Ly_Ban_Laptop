using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmDangNhap : Form
    {
        INhanVienServices _nhanVienServices;
        public FrmDangNhap()
        {
            _nhanVienServices = new NhanVienServies();
            InitializeComponent();
            txtEmail.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonCustom1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tên đăng nhập hoặc mật khẩu");
                return;
            }

            foreach (var x in _nhanVienServices.GetAll())
            {
                if (x.Email.ToLower() == txtEmail.Text.ToLower())
                {
                    if (x.MatKhau == txtMatKhau.Text)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        FrmHome home = new FrmHome();
                        this.Hide();
                        home.ShowDialog();
                        this.Close();
                        return;

                    }
                    MessageBox.Show("Mật khẩu chưa chính xác");
                    return;
                }
            }
            MessageBox.Show("Tài khoản không chính xác");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmQuenMatKhau quenMatKhau = new FrmQuenMatKhau();
            this.Hide();
            quenMatKhau.ShowDialog();
            this.Close();
        }
    }
}
