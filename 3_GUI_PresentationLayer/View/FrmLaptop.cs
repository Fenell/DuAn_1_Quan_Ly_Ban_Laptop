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
using System.Windows.Input;
using static System.Resources.ResXFileRef;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmLaptop : Form
    {
        private ILaptopService _lapTopService;
        private ICpuServices _cpuServices;
        private IVgaServices _vgaServices;
        private IMauSacServices _mauSacServices;
        private IOCungServices _oCungServices;
        private IRamServices _ramServices;
        private IManHinhServices _manHinhServices;
        private INhaCungCapServices _nhaCungCapServices;
        private IHangLaptopServices _hangLaptopServices;
        private IDongLaptopServices _dongLaptopServices;
        private ISerialLaptopService _serialLaptopService;

        private List<Cpu> _lstCpu;
        private List<Vga> _lstVga;
        private List<MauSac> _lstMauSac;
        private List<OCung> _lstOCung;
        private List<Ram> _lstRam;
        private List<ManHinh> _lstManHinh;
        private List<NhaCungCap> _lstNhaCungCap;
        private List<HangLaptop> _lstHangLaptop;
        private List<DongLaptop> _lstDongLaptop;
        private List<SerialLaptop> _lstserialLaptops;

        private string fileAnh;
        private Guid _idLaptop;

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
            _serialLaptopService = new SerialLaptopService();

            _lstCpu = new List<Cpu>();
            _lstVga = new List<Vga>();
            _lstMauSac = new List<MauSac>();
            _lstOCung = new List<OCung>();
            _lstRam = new List<Ram>();
            _lstManHinh = new List<ManHinh>();
            _lstNhaCungCap = new List<NhaCungCap>();
            _lstHangLaptop = new List<HangLaptop>();
            _lstDongLaptop = new List<DongLaptop>();
            _lstserialLaptops = new List<SerialLaptop>();

            Loadcbb();
            LoadDgv();
            txtFalse();
        }

        #region ShowFormCon
        //Cpu
        public FrmLaptop(List<Cpu> cpus)
        {
            this._lstCpu = cpus;
        }
        private void btnCpu_Click(object sender, EventArgs e)
        {
            FrmCpu newCpu = new FrmCpu(_lstCpu);
            //newCpu.Location = new Point(915, 67);
            newCpu.ShowDialog();
            Loadcbb();
        }

        //Vga
        public FrmLaptop(List<Vga> vgas)
        {
            this._lstVga = vgas;
        }
        private void btnVga_Click(object sender, EventArgs e)
        {
            FrmVga newVga = new FrmVga(_lstVga);
            newVga.ShowDialog();
            Loadcbb();
        }

        //NhaCungCap
        public FrmLaptop(List<NhaCungCap> nhaCungCaps)
        {
            this._lstNhaCungCap = nhaCungCaps;
        }
        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap frmNhaCungCap = new FrmNhaCungCap(_lstNhaCungCap);
            frmNhaCungCap.ShowDialog();
            Loadcbb();
        }

        //DongLaptop
        public FrmLaptop(List<DongLaptop> dongLaptops)
        {
            this._lstDongLaptop = dongLaptops;
        }
        private void btnDongLaptop_Click(object sender, EventArgs e)
        {
            FrmDongLaptop frmDongLaptop = new FrmDongLaptop(_lstDongLaptop);
            frmDongLaptop.ShowDialog();
            Loadcbb();
        }

        //Hang san xuat
        public FrmLaptop(List<HangLaptop> hangLaptops)
        {
            this._lstHangLaptop = hangLaptops;
        }
        private void btnHangSanXuat_Click(object sender, EventArgs e)
        {
            FrmHangLaptop frmHangLaptop = new FrmHangLaptop(_lstHangLaptop);
            frmHangLaptop.ShowDialog();
            Loadcbb();
        }

        // Ram
        public FrmLaptop(List<Ram> rams)
        {
            this._lstRam = rams;
        }
        private void btnRam_Click(object sender, EventArgs e)
        {
            FrmRam frmRam = new FrmRam(_lstRam);
            frmRam.ShowDialog();
            Loadcbb();
        }

        // Ổ cứng
        public FrmLaptop(List<OCung> oCungs)
        {
            this._lstOCung = oCungs;
        }
        private void btnOCung_Click(object sender, EventArgs e)
        {
            FrmOCung frmOCung = new FrmOCung(_lstOCung);
            frmOCung.ShowDialog();
            Loadcbb();
        }

        //Màn hình
        public FrmLaptop(List<ManHinh> manHinhs)
        {
            this._lstManHinh = manHinhs;
        }
        private void btnManHinh_Click(object sender, EventArgs e)
        {
            FrmManHinh frmManHinh = new FrmManHinh(_lstManHinh);
            frmManHinh.ShowDialog();
            Loadcbb();
        }

        //Màu sắc
        public FrmLaptop(List<MauSac> mauSacs)
        {
            this._lstMauSac = mauSacs;
        }
        private void btnMauSac_Click(object sender, EventArgs e)
        {
            FrmMauSac frmMauSac = new FrmMauSac(_lstMauSac);
            //frmMauSac.Show();
            // Lấy vị trí của nút thêm nhanh
            //Point buttonPosition = btnMauSac.PointToScreen(Point.Empty);

            //// Tính toán vị trí của form con
            //int x = buttonPosition.X + btnMauSac.Width;
            //int y = buttonPosition.Y;

            //// Hiển thị form con
            //frmMauSac.Location = new Point(x, y);
            frmMauSac.ShowDialog();
            Loadcbb();
        }

        //Serial
        public FrmLaptop(List<SerialLaptop> serialLaptops)
        {
            this._lstserialLaptops = serialLaptops;
        }
        private void btnSerial_Click(object sender, EventArgs e)
        {
            if (_idLaptop == Guid.Empty)
            {
                MessageBox.Show("Bạn chưa chọn Laptop", "Thông báo");
                return;
            }
            FrmSerial frmSerial = new FrmSerial(_idLaptop);
            frmSerial.ShowDialog();
            LoadDgv();
        }
        #endregion
        #region LoadForm
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
            _lstVga = _vgaServices.GetAllVga();
            cbbVga.DataSource = _lstVga;
            //Màu Sắc
            cbbMauSac.DisplayMember = "Ten";
            cbbMauSac.ValueMember = "Id";
            _lstMauSac = _mauSacServices.GetAllMauSac();
            cbbMauSac.DataSource = _lstMauSac;
            //Ổ cứng
            // cbbOCung.DisplayMember = "Ten";
            cbbOCung.ValueMember = "Id";
            _lstOCung = _oCungServices.GetAllOCungs();
            _lstOCung.ForEach(c => cbbOCung.Items.Add($"{c.Loai}-{c.DungLuong}GB"));
            //cbbOCung.DataSource = _oCungServices.GetAllOCungs();
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
            dgvLaptop.Columns[0].Visible = false;
            dgvLaptop.Columns[1].Name = "Tên Laptop";
            dgvLaptop.Columns[2].Name = "Tồn kho";
            dgvLaptop.Columns[3].Name = "Giá nhập";
            dgvLaptop.Columns[4].Name = "Giá bán";
            dgvLaptop.Columns[5].Name = "Năm bảo hành";
            dgvLaptop.Rows.Clear();
            foreach (var x in _lapTopService.GetAllLaptop())
            {
                dgvLaptop.Rows.Add(x.Id, $"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.SoLuongTon, x.GiaNhap, x.GiaBan, x.NamBh);
            }
        }
        #endregion

        #region btnIcon
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
            txtFalse();
            LaptopView laptop = new LaptopView()
            {
                Id = _idLaptop,
                IdCpu = Guid.Parse(cbbCpu.SelectedValue.ToString()),
                IdVga = Guid.Parse(cbbVga.SelectedValue.ToString()),
                IdMauSac = Guid.Parse(cbbMauSac.SelectedValue.ToString()),
                IdOCung = _oCungServices.GetAllOCungs()[cbbOCung.SelectedIndex].Id,
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
                MessageBox.Show(_lapTopService.UpdateLaptop(laptop));
            }
            btnThem.Enabled = false;
            LoadDgv();
        }

        private void btnDoiTT_Click(object sender, EventArgs e)
        {
            txtFalse();
            var lstLaptop = _lapTopService.GetLaptopFromDb().Where(c => c.Id == _idLaptop).ToList();
            if (MessageBox.Show("Bạn có chắc chắn muốn chuyển trạng thái", "Chuyển trạng thái", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_lapTopService.UpdateStatusLaptop(lstLaptop));
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtFalse();
            btnThem.Enabled = true;
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
            pcbHinhAnh.Image = null;
            //Loadcbb();
            LoadDgv();
        }
        private void txtFalse()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnDoiTT.Enabled = false;
        }
        #endregion

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

            _idLaptop = Guid.Parse(dgvLaptop.Rows[rowindex].Cells[0].Value.ToString());
            var lt = _lapTopService.GetAllLaptop().FirstOrDefault(c => c.Id == _idLaptop);
            var oCung = _oCungServices.GetAllOCungs().Find(c => c.Id == lt.IdOCung);
            txtTen.Texts = lt.Ten;
            txtTrongLuong.Texts = lt.TrongLuong.ToString();
            txtNamBh.Texts = lt.NamBh.ToString();
            txtGiaNhap.Texts = lt.GiaNhap.ToString();
            txtGiaBan.Texts = lt.GiaBan.ToString();
            txtMoTa.Texts = lt.Mota;
            cbbCpu.Text = lt.Cpu;
            cbbVga.Text = lt.Vga;
            cbbMauSac.Text = lt.MauSac;
            cbbOCung.Text = $"{oCung.Loai}-{oCung.DungLuong}GB";
            cbbRam.Text = lt.Ram;
            cbbManHinh.Text = lt.ManHinh;
            cbbNhaCungCap.Text = lt.NhaCungCap;
            cbbHangSanXuat.Text = lt.HangLaptop;
            cbbDong.Text = lt.DongLaptop;

            //Load Serial
            cbbSerial.Items.Clear();
            foreach (var x in _serialLaptopService.GetSerialLaptopList().Where(c => c.IdLaptop == lt.Id && c.TrangThai))
            {
                cbbSerial.Items.Insert(0, x.Serial);
            }

            var img = Extension.ArrBytesToImage(lt.Anh);
            if (img != null)
            {
                pcbHinhAnh.Image = img;
            }
            else
            {
                pcbHinhAnh.Image = null;
            }
            // lấy dữ liệu ảnh từ cơ sở dữ liệu
            //byte[] imageData = (byte[])lt.Anh;
            //if (imageData != null)
            //{
            //    // chuyển đổi dữ liệu byte thành kiểu MemoryStream
            //    using (MemoryStream ms = new MemoryStream(imageData))
            //    {
            //        // chuyển đổi kiểu MemoryStream thành kiểu Image
            //        Image image = Image.FromStream(ms);
            //        // hiển thị ảnh lên PictureBox
            //        pcbHinhAnh.Image = image;
            //    }
            //}
            //else
            //    {
            //        pcbHinhAnh.Image = null;
            //    }
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnDoiTT.Enabled = true;

        }

        #region Lọc

        // rdbtn lọc trạng thái
        private void rdbtnDangBan_Click(object sender, EventArgs e)
        {
            dgvLaptop.Rows.Clear();
            dgvLaptop.ColumnCount = 6;
            dgvLaptop.Columns[0].Visible = false;
            dgvLaptop.Columns[1].Name = "Tên";
            dgvLaptop.Columns[2].Name = "Số lượng";
            dgvLaptop.Columns[3].Name = "Giá nhập";
            dgvLaptop.Columns[4].Name = "Giá bán";
            dgvLaptop.Columns[5].Name = "Năm bảo hành";
            foreach (var x in _lapTopService.GetAllLaptop().Where(c => c.TrangThai == true))
            {
                dgvLaptop.Rows.Add(x.Id, $"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.SoLuongTon, x.GiaNhap, x.GiaBan, x.NamBh);
            }
        }
        private void rdbtnNgungBan_Click(object sender, EventArgs e)
        {
            dgvLaptop.Rows.Clear();
            dgvLaptop.ColumnCount = 6;
            dgvLaptop.Columns[0].Visible = false;
            dgvLaptop.Columns[1].Name = "Tên";
            dgvLaptop.Columns[2].Name = "Số lượng";
            dgvLaptop.Columns[3].Name = "Giá nhập";
            dgvLaptop.Columns[4].Name = "Giá bán";
            dgvLaptop.Columns[5].Name = "Năm bảo hành";
            foreach (var x in _lapTopService.GetAllLaptop().Where(c => c.TrangThai == false))
            {
                dgvLaptop.Rows.Add(x.Id, $"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.SoLuongTon, x.GiaNhap, x.GiaBan, x.NamBh);
            }

        }

        //txtTimKiem
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvLaptop.Rows.Clear();
            dgvLaptop.ColumnCount = 6;
            dgvLaptop.Columns[0].Visible = false;
            dgvLaptop.Columns[1].Name = "Tên";
            dgvLaptop.Columns[2].Name = "Số lượng";
            dgvLaptop.Columns[3].Name = "Giá nhập";
            dgvLaptop.Columns[4].Name = "Giá bán";
            dgvLaptop.Columns[5].Name = "Năm bảo hành";
            foreach (var x in _lapTopService.GetAllLaptop().Where(c => String.Concat(c.HangLaptop, c.DongLaptop, c.Ten).ToLower().Contains(txtTimKiem.Text.ToLower())))
            {
                dgvLaptop.Rows.Add(x.Id, $"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.SoLuongTon, x.GiaNhap, x.GiaBan, x.NamBh);
            }

        }
        #endregion


        private void cbbOCung_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
