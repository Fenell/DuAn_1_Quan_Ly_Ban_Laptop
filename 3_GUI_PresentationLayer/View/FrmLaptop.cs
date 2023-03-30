using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.ViewModel;
using _3_GUI_PresentationLayer.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmLaptop : Form
    {
        ILaptopService _lapTopService;
        ICpuServices _cpuServices;
        IVgaServices _vgaServices;
        IMauSacServices _mauSacServices;
        IOCungServices _oCungServices;
        IRamServices _ramServices;
        IManHinhServices _manHinhServices;
        INhaCungCapServices _nhaCungCapServices;
        IHangLaptopServices _hangLaptopServices;
        IDongLaptopServices _dongLaptopServices;
        List<Cpu> _lstCpu;
        string fileAnh;
        string _ten;
        public FrmLaptop()
        {
            InitializeComponent();
            _lapTopService = new LaptopService();
            _cpuServices = new CpuServices();
            _vgaServices = new VgaServices();
            _mauSacServices = new MauSacServices();
            _oCungServices = new OCungServices();
            _ramServices = new RamServices();
            _manHinhServices = new ManHinhServices();
            _nhaCungCapServices = new NhaCungCapServices();
            _hangLaptopServices = new HangLaptopServices();
            _dongLaptopServices = new DongLaptopServices();
            _lstCpu = new List<Cpu>();
            Loadcbb();
            //LoadDgv();
        }

        private void btnCpu_Click(object sender, EventArgs e)
        {
            FrmCpu newCpu = new FrmCpu(_lstCpu);
            //newCpu.Location = new Point(915, 67);
            newCpu.ShowDialog();
        }

        private void btnVga_Click(object sender, EventArgs e)
        {
            FrmVga frmVga = new FrmVga();
            frmVga.ShowDialog();

        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap frmNhaCungCap = new FrmNhaCungCap();
            frmNhaCungCap.ShowDialog();
        }

        private void btnDongLaptop_Click(object sender, EventArgs e)
        {
            FrmDongLaptop frmDongLaptop = new FrmDongLaptop();
            frmDongLaptop.ShowDialog();
        }

        private void btnHangSanXuat_Click(object sender, EventArgs e)
        {
            FrmHangLaptop frmHangLaptop = new FrmHangLaptop();
            frmHangLaptop.ShowDialog();
        }

        private void btnRam_Click(object sender, EventArgs e)
        {
            FrmRam frmRam = new FrmRam();
            frmRam.ShowDialog();
        }

        private void btnOCung_Click(object sender, EventArgs e)
        {
            FrmOCung frmOCung = new FrmOCung();
            frmOCung.ShowDialog();
        }

        private void btnManHinh_Click(object sender, EventArgs e)
        {
            FrmManHinh frmManHinh = new FrmManHinh();
            frmManHinh.ShowDialog();
        }

        private void btnMauSac_Click(object sender, EventArgs e)
        {
            FrmMauSac frmMauSac = new FrmMauSac();
            //frmMauSac.Show();
            // Lấy vị trí của nút thêm nhanh
            //Point buttonPosition = btnMauSac.PointToScreen(Point.Empty);

            //// Tính toán vị trí của form con
            //int x = buttonPosition.X + btnMauSac.Width;
            //int y = buttonPosition.Y;

            //// Hiển thị form con
            //frmMauSac.Location = new Point(x, y);
            frmMauSac.ShowDialog();
        }
        private void Loadcbb()
        {
            // CPU
            cbbCpu.DisplayMember = "Ten";
            cbbCpu.ValueMember = "Id";
            _lstCpu = _cpuServices.GetAllCpu();
            cbbCpu.DataSource = _lstCpu;
            // VGA
            cbbVga.DisplayMember = "Ten";
            cbbVga.ValueMember = "Id";
            cbbVga.DataSource = _vgaServices.GetAllVga();
            //Màu Sắc
            cbbMauSac.DisplayMember = "Ten";
            cbbMauSac.ValueMember = "Id";
            cbbMauSac.DataSource = _mauSacServices.GetAllMauSac();
            //Ổ cứng
            cbbOCung.DisplayMember = "Ten";
            cbbOCung.ValueMember = "Id";
            cbbOCung.DataSource = _oCungServices.GetAllOCungs();
            //Ram
            cbbRam.DisplayMember = "Ten";
            cbbRam.ValueMember = "Id";
            cbbRam.DataSource = _ramServices.GetAllRam();
            //Màn hình
            cbbManHinh.DisplayMember = "Ten";
            cbbManHinh.ValueMember = "Id";
            cbbManHinh.DataSource = _manHinhServices.GetAllManHinh();
            //Nha cung cấp
            cbbNhaCungCap.DisplayMember = "Ten";
            cbbNhaCungCap.ValueMember = "Id";
            cbbNhaCungCap.DataSource = _nhaCungCapServices.GetAllNhaCungCap();
            //Hãng Laptop
            cbbHangSanXuat.DisplayMember = "Ten";
            cbbHangSanXuat.ValueMember = "Id";
            cbbHangSanXuat.DataSource = _hangLaptopServices.GetAllHangLaptops();
            //Dòng Laptop
            cbbDong.DisplayMember = "Ten";
            cbbDong.ValueMember = "Id";
            cbbDong.DataSource = _dongLaptopServices.GetAllDongLaptop();
        }
        private void LoadDgv()
        {
            dgvLaptop.ColumnCount = 6;
            dgvLaptop.Columns[0].Name = "Tên";
            dgvLaptop.Columns[1].Name = "Số lượng";
            dgvLaptop.Columns[2].Name = "Giá nhập";
            dgvLaptop.Columns[3].Name = "Giá bán";
            dgvLaptop.Columns[4].Name = "Năm bảo hành";
            dgvLaptop.Columns[5].Visible = false;
            dgvLaptop.Rows.Clear();
            foreach (var x in _lapTopService.GetAllLaptop())
            {
                dgvLaptop.Rows.Add($"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.SoLuongTon, x.GiaBan, x.GiaNhap, x.NamBh, x.Ten);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LaptopView laptop = new LaptopView()
            {
                Id = Guid.Empty,
                IdCpu = Guid.Parse(cbbCpu.SelectedValue.ToString()),
                IdVga = Guid.Parse(cbbVga.SelectedValue.ToString()),
                IdMauSac = Guid.Parse(cbbMauSac.SelectedValue.ToString()),
                IdOCung = Guid.Parse(cbbOCung.SelectedValue.ToString()),
                IdRam = Guid.Parse(cbbRam.SelectedValue.ToString()),
                IdManHinh = Guid.Parse(cbbManHinh.SelectedValue.ToString()),
                IdNhaCungCap = Guid.Parse(cbbNhaCungCap.SelectedValue.ToString()),
                IdHangLaptop = Guid.Parse(cbbHangSanXuat.SelectedValue.ToString()),
                IdDongLaptop = Guid.Parse(cbbDong.SelectedValue.ToString()),
                Ten = txtTen.Texts,
                GiaNhap = decimal.Parse(txtGiaNhap.Texts),
                GiaBan = decimal.Parse(txtGiaBan.Texts),
                Mota = txtMoTa.Texts,
                TrongLuong = decimal.Parse(txtTrongLuong.Texts),
                NamBh = int.Parse(txtNamBh.Texts),
                TrangThai = true,
                Anh = Extension.ImageToArrBytes(pcbHinhAnh.Image)
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(_lapTopService.AddLaptop(laptop));
            }
            LoadDgv();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LaptopView laptop = new LaptopView()
            {
                Ten = _ten,
                IdCpu = Guid.Parse(cbbCpu.SelectedValue.ToString()),
                IdVga = Guid.Parse(cbbVga.SelectedValue.ToString()),
                IdMauSac = Guid.Parse(cbbMauSac.SelectedValue.ToString()),
                IdOCung = Guid.Parse(cbbOCung.SelectedValue.ToString()),
                IdRam = Guid.Parse(cbbRam.SelectedValue.ToString()),
                IdManHinh = Guid.Parse(cbbManHinh.SelectedValue.ToString()),
                IdNhaCungCap = Guid.Parse(cbbNhaCungCap.SelectedValue.ToString()),
                IdHangLaptop = Guid.Parse(cbbHangSanXuat.SelectedValue.ToString()),
                IdDongLaptop = Guid.Parse(cbbDong.SelectedValue.ToString()),
                GiaNhap = decimal.Parse(txtGiaNhap.Texts),
                GiaBan = decimal.Parse(txtGiaBan.Texts),
                Mota = txtMoTa.Texts,
                TrongLuong = decimal.Parse(txtTrongLuong.Texts),
                NamBh = int.Parse(txtNamBh.Texts),
                TrangThai = true,
                Anh = Extension.ImageToArrBytes(pcbHinhAnh.Image)
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(_lapTopService.UpdateLaptop(laptop));
            }
            LoadDgv();
        }

        private void pcbHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileAnh = ofd.FileName;
                pcbHinhAnh.Image = Image.FromFile(fileAnh);
            }
        }

        private void dgvLaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _lapTopService.GetAllLaptop().Count)
            {
                return;
            }
            if (rdbKhongSeri.Checked == true)
            {
                _ten = dgvLaptop.Rows[rowindex].Cells[4].Value.ToString();
                var lt = _lapTopService.GetAllLaptopNoSerial().FirstOrDefault(c => c.Ten == _ten);
                txtTen.Texts = lt.Ten;
                txtTrongLuong.Texts = lt.TrongLuong.ToString();
                txtNamBh.Texts = lt.NamBh.ToString();
                txtGiaNhap.Texts = lt.GiaNhap.ToString();
                txtGiaBan.Texts = lt.GiaBan.ToString();
                txtMoTa.Texts = lt.Mota;
                cbbCpu.Text = lt.Cpu;
                cbbVga.Text = lt.Vga;
                cbbMauSac.Text = lt.MauSac;
                cbbOCung.Text = lt.OCung;
                cbbRam.Text = lt.Ram;
                cbbManHinh.Text = lt.ManHinh;
                cbbNhaCungCap.Text = lt.NhaCungCap;
                cbbHangSanXuat.Text = lt.HangLaptop;
                cbbDong.Text = lt.DongLaptop;
                // lấy dữ liệu ảnh từ cơ sở dữ liệu
                byte[] imageData = (byte[])lt.Anh;
                if (imageData != null)
                {
                    // chuyển đổi dữ liệu byte thành kiểu MemoryStream
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        // chuyển đổi kiểu MemoryStream thành kiểu Image
                        Image image = Image.FromStream(ms);
                        // hiển thị ảnh lên PictureBox
                        pcbHinhAnh.Image = image;
                    }
                }
                else
                {
                    pcbHinhAnh.Image = null;
                }
            }
            else
            {
                _ten = dgvLaptop.Rows[rowindex].Cells[5].Value.ToString();
                var lt = _lapTopService.GetAllLaptop().FirstOrDefault(c => c.Ten == _ten);
                txtTen.Texts = lt.Ten;
                txtTrongLuong.Texts = lt.TrongLuong.ToString();
                txtNamBh.Texts = lt.NamBh.ToString();
                txtGiaNhap.Texts = lt.GiaNhap.ToString();
                txtGiaBan.Texts = lt.GiaBan.ToString();
                txtMoTa.Texts = lt.Mota;
                cbbCpu.Text = lt.Cpu;
                cbbVga.Text = lt.Vga;
                cbbMauSac.Text = lt.MauSac;
                cbbOCung.Text = lt.OCung;
                cbbRam.Text = lt.Ram;
                cbbManHinh.Text = lt.ManHinh;
                cbbNhaCungCap.Text = lt.NhaCungCap;
                cbbHangSanXuat.Text = lt.HangLaptop;
                cbbDong.Text = lt.DongLaptop;
                // lấy dữ liệu ảnh từ cơ sở dữ liệu
                byte[] imageData = (byte[])lt.Anh;
                if (imageData != null)
                {
                    // chuyển đổi dữ liệu byte thành kiểu MemoryStream
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        // chuyển đổi kiểu MemoryStream thành kiểu Image
                        Image image = Image.FromStream(ms);
                        // hiển thị ảnh lên PictureBox
                        pcbHinhAnh.Image = image;
                    }
                }
                else
                {
                    pcbHinhAnh.Image = null;
                }

            }
        }

        private void btnDoiTT_Click(object sender, EventArgs e)
        {
            var lstLaptop = _lapTopService.GetLaptopFromDb().Where(c => c.Ten == _ten).ToList();
            if (MessageBox.Show("Bạn có chắc chắn muốn chuyển trạng thái", "Chuyển trạng thái", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_lapTopService.UpdateStatusLaptop(lstLaptop));
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtTen.Texts = "";
            txtTrongLuong.Texts = "";
            txtNamBh.Texts = "";
            txtGiaNhap.Texts = "";
            txtGiaBan.Texts = "";
            txtMoTa.Texts = "";
            cbbCpu.Text = "";
            cbbVga.Text = "";
            cbbMauSac.Text = "";
            cbbOCung.Text = "";
            cbbRam.Text = "";
            cbbManHinh.Text = "";
            cbbNhaCungCap.Text = "";
            cbbHangSanXuat.Text = "";
            cbbDong.Text = "";
        }

        //rdb lọc seri
        private void rdbCoSeri_Click(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void rdbKhongSeri_Click(object sender, EventArgs e)
        {
            dgvLaptop.Rows.Clear();
            dgvLaptop.ColumnCount = 5;
            dgvLaptop.Columns[0].Name = "Tên";
            dgvLaptop.Columns[1].Name = "Giá nhập";
            dgvLaptop.Columns[2].Name = "Giá bán";
            dgvLaptop.Columns[3].Name = "Năm bảo hành";
            dgvLaptop.Columns[4].Visible = false;
            foreach (var x in _lapTopService.GetAllLaptopNoSerial())
            {
                dgvLaptop.Rows.Add($"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.GiaBan, x.GiaNhap, x.NamBh, x.Ten);
            }
        }

        // rdbtn lọc trạng thái
        private void rdbtnDangBan_Click(object sender, EventArgs e)
        {
            dgvLaptop.Rows.Clear();
            dgvLaptop.ColumnCount = 5;
            dgvLaptop.Columns[0].Name = "Tên";
            //dgvLaptop.Columns[1].Name = "Số lượng";
            dgvLaptop.Columns[1].Name = "Giá nhập";
            dgvLaptop.Columns[2].Name = "Giá bán";
            dgvLaptop.Columns[3].Name = "Năm bảo hành";
            dgvLaptop.Columns[4].Visible = false;
            foreach (var x in _lapTopService.GetAllLaptopNoSerial().Where(c => c.TrangThai == true))
            {
                dgvLaptop.Rows.Add($"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.GiaBan, x.GiaNhap, x.NamBh, x.Ten);
            }
        }
        private void rdbtnNgungBan_Click(object sender, EventArgs e)
        {
            dgvLaptop.Rows.Clear();
            dgvLaptop.ColumnCount = 5;
            dgvLaptop.Columns[0].Name = "Tên";
            //dgvLaptop.Columns[1].Name = "Số lượng";
            dgvLaptop.Columns[1].Name = "Giá nhập";
            dgvLaptop.Columns[2].Name = "Giá bán";
            dgvLaptop.Columns[3].Name = "Năm bảo hành";
            dgvLaptop.Columns[4].Visible = false;
            foreach (var x in _lapTopService.GetAllLaptopNoSerial().Where(c => c.TrangThai == false))
            {
                dgvLaptop.Rows.Add($"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.GiaBan, x.GiaNhap, x.NamBh, x.Ten);
            }

        }

        //txtTimKiem
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvLaptop.Rows.Clear();
            dgvLaptop.ColumnCount = 5;
            dgvLaptop.Columns[0].Name = "Tên";
            //dgvLaptop.Columns[1].Name = "Số lượng";
            dgvLaptop.Columns[1].Name = "Giá nhập";
            dgvLaptop.Columns[2].Name = "Giá bán";
            dgvLaptop.Columns[3].Name = "Năm bảo hành";
            dgvLaptop.Columns[4].Visible = false;
            foreach (var x in _lapTopService.GetAllLaptop().Where(c => c.Ten.ToLower().Contains(txtTimKiem.Text.ToLower())))
            {
                dgvLaptop.Rows.Add($"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.GiaBan, x.GiaNhap, x.NamBh, x.Ten);
            }

        }
    }
}
