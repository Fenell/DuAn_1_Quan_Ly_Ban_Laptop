using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
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
    public partial class FrmKhuyenMai : Form
    {
        private IKhuyenMaiServices _khuyenMaiServices;
        Guid _idKhuyenMai;
        public FrmKhuyenMai()
        {
            InitializeComponent();
            _khuyenMaiServices = new KhuyenMaiServices();
            ChuyenTrangThai();
            LoadDgv();
        }
        private void LoadDgv()
        {
            cbbLoaiKhuyenMai.DisplayMember = "LoaiKhuyenMai";
            //cbbLoaiKhuyenMai.ValueMember = "Id";
            cbbLoaiKhuyenMai.DataSource = _khuyenMaiServices.GetAllKhuyenMai();
            dgvKhuyenMai.ColumnCount = 6;
            dgvKhuyenMai.Columns[0].Visible = false;
            dgvKhuyenMai.Columns[1].Name = "Tên";
            dgvKhuyenMai.Columns[2].Name = "Loại";
            dgvKhuyenMai.Columns[3].Name = "Giá trị";
            dgvKhuyenMai.Columns[4].Name = "Ngày bắt đầu";
            dgvKhuyenMai.Columns[5].Name = "Ngày kết thúc";
            dgvKhuyenMai.Rows.Clear();
            foreach (var x in _khuyenMaiServices.GetAllKhuyenMai())
            {
                dgvKhuyenMai.Rows.Add(x.Id, x.Ten, x.LoaiKhuyenMai, x.GiaTri, x.NgayBatDau, x.NgayKetThuc);
            }
        }
        private string RandomMa()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 100000); // Sinh ra một số nguyên ngẫu nhiên từ 10000 đến 99999
            return randomNumber.ToString(); // Chuyển đổi giá trị số nguyên thành chuỗi và trả về chuỗi đó
        }

        private bool checkDateTime()
        {
            if (dtBatDau.Value > DateTime.Now && dtKetThuc.Value > dtBatDau.Value) return true;
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!checkDateTime())
            {
                MessageBox.Show("Ngày bắt đầu phải lớn hơn ngày hôm nay hoặc ngày kết thúc phải lớn hơn ngày bắt đầu");
                return;
            }
            txtMa.Texts = RandomMa();
            KhuyenMai khuyenMai = new KhuyenMai()
            {
                Ten = txtTenCT.Texts,
                Ma = txtMa.Texts,
                LoaiKhuyenMai = cbbLoaiKhuyenMai.Text,
                GiaTri = decimal.Parse(txtMucGia.Texts),
                NgayBatDau = dtBatDau.Value,
                NgayKetThuc = dtKetThuc.Value,
                TrangThai = dtBatDau.Value == DateTime.Now ? 0 : 1,
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_khuyenMaiServices.AddKhuyenMai(khuyenMai));
            }
            LoadDgv();
        }
        private void ChuyenTrangThai()
        {
            foreach (var x in _khuyenMaiServices.GetAllKhuyenMai())
            {
                _khuyenMaiServices.ChuyenTrangThai(x);
            }
        }

        private void iconbtnSua_Click(object sender, EventArgs e)
        {
            if (!checkDateTime())
            {
                MessageBox.Show("Ngày bắt đầu phải lớn hơn ngày hôm nay hoặc ngày kết thúc phải lớn hơn ngày bắt đầu");
                return;
            }
            KhuyenMai khuyenMai = new KhuyenMai()
            {
                Id = _idKhuyenMai,
                Ten = txtTenCT.Texts,
                //Ma = txtMa.Texts,
                LoaiKhuyenMai = cbbLoaiKhuyenMai.Text,
                GiaTri = decimal.Parse(txtMucGia.Texts),
                NgayBatDau = dtBatDau.Value,
                NgayKetThuc = dtKetThuc.Value,
                TrangThai = dtBatDau.Value == DateTime.Now ? 0 : 1,
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_khuyenMaiServices.UpdateKhuyenMai(khuyenMai));
            }
            LoadDgv();
        }
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            txtMa.Texts = "";
            txtTenCT.Texts = "";
            cbbLoaiKhuyenMai.Text = "";
            txtMucGia.Texts = "";
            dtBatDau.Value = DateTime.Now;
            dtKetThuc.Value = DateTime.Now;
        }
        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _khuyenMaiServices.GetAllKhuyenMai().Count)
            {
                return;
            }
            _idKhuyenMai = Guid.Parse(dgvKhuyenMai.Rows[rowindex].Cells[0].Value.ToString());
            var khuyenMai = _khuyenMaiServices.GetAllKhuyenMai().FirstOrDefault(c => c.Id == _idKhuyenMai);
            txtMa.Texts = khuyenMai.Ma;
            txtTenCT.Texts = khuyenMai.Ten;
            cbbLoaiKhuyenMai.Text = khuyenMai.LoaiKhuyenMai;
            dtBatDau.Value = khuyenMai.NgayBatDau;
            dtKetThuc.Value = khuyenMai.NgayKetThuc;
            txtMucGia.Texts = khuyenMai.GiaTri.ToString();
            if (khuyenMai.TrangThai == 1)
            {
                btnrdSap.Checked = true;
            }
            if (khuyenMai.TrangThai == 0)
            {
                btnrbDang.Checked = true;
            }
            if (khuyenMai.TrangThai == 2)
            {
                btnrdKetThuc.Checked = true;
            }
            btnThem.Enabled = false;
        }


    }
}
