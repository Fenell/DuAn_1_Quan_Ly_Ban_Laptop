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
    public partial class FrmNhaCungCap : Form
    {
        INhaCungCapServices _nhaCungCapServices;
        Guid _idNhaCungCap;
        public FrmNhaCungCap()
        {
            InitializeComponent();
            _nhaCungCapServices = new NhaCungCapServices();
        }
        private void LoadDgv()
        {
            dgvNhaCungCap.ColumnCount = 3;
            dgvNhaCungCap.Columns[0].Visible = false;
            dgvNhaCungCap.Columns[1].Name = "Mã";
            dgvNhaCungCap.Columns[2].Name = "Tên";
            dgvNhaCungCap.Rows.Clear();
            foreach (var x in _nhaCungCapServices.GetAllNhaCungCap())
            {
                dgvNhaCungCap.Rows.Add(x.Id, x.Ma, x.Ten);
            }
        }
        private void txtTrue()
        {
            btnSua.Enabled = true;
            txtTenNhaCungCap.Enabled = true;
            lbMa.Enabled = true;
        }
        private void txtFalse()
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            txtTenNhaCungCap.Enabled = false;
            lbMa.Enabled = false;
        }
        private string RandomMa()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 100000); // Sinh ra một số nguyên ngẫu nhiên từ 10000 đến 99999
            return randomNumber.ToString(); // Chuyển đổi giá trị số nguyên thành chuỗi và trả về chuỗi đó
        }
        private bool checkNhap()
        {
            if (txtTenNhaCungCap.Texts == "") return true;
            return false;
        }
    }
}
