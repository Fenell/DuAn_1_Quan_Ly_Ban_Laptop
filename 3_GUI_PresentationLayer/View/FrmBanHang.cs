using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.ViewModel;
using _3_GUI_PresentationLayer.CustomControl;
using AForge.Video.DirectShow;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ZXing;
using ZXing.Windows.Compatibility;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmBanHang : Form
    {
        private ILaptopService _laptopService;
        private ISerialLaptopService _serialLaptopService;
        private IHoaDonSerevice _hoaDonSerevice;
        private IChiTietHoaDonService _chiTietHoaDonService;
        private IKhuyenMaiServices _khuyenMaiServices;
        private IHangLapTopRepositories _hangLapTop;
        private IDongLapTopRepositories _dongLapTop;
        private IKhachHangService _khachHangService;

        private Laptop _laptop;
        private List<ChiTietHoaDonView> _lstCtHoaDonViews;
        private string _serialSelected;
        private FilterInfoCollection _captureVideo;
        private VideoCaptureDevice _videoCaptureDevice;
        private List<LaptopView> _lstLaptopViews;
        private HoaDonView _hoaDon;
        private Guid _idHoaDon;
        private Guid _idChiTietHD;
        public FrmBanHang()
        {
            InitializeComponent();
            _laptopService = new LaptopService();
            _serialLaptopService = new SerialLaptopService();
            _laptop = new Laptop();
            _lstLaptopViews = new List<LaptopView>();
            _khachHangService = new KhachhangService();
            _hoaDonSerevice = new HoaDonService();
            _chiTietHoaDonService = new ChiTietHoaDonService();
            _khuyenMaiServices = new KhuyenMaiServices();
            _hangLapTop = new HangLaptopRepositories();
            _dongLapTop = new DongLapTopReposittoies();

            _lstLaptopViews = _laptopService.GetAllLaptop();
            GetDeviceVideoCapture();
            LoadData();
        }

        private void LoadData()
        {
            _lstCtHoaDonViews = new List<ChiTietHoaDonView>();
            _hoaDon = new HoaDonView();
            _idHoaDon = Guid.Empty;



            txtMaHD.Texts = _hoaDonSerevice.AutoGenerateMa();

            LoadSanPham();
            ResetForm();
            LoadGioHang();
            LoadKhachHang();

        }

        private void LoadSanPham()
        {
            dgvSanPham.ColumnCount = 4;
            dgvSanPham.Columns[0].Name = "Tên laptop";
            dgvSanPham.Columns[1].Name = "Giá bán";
            dgvSanPham.Columns[1].DefaultCellStyle.Format = "N0";
            dgvSanPham.Columns[2].Name = "Tồn kho";
            dgvSanPham.Columns[3].Name = "Danh sách Serial";

            dgvSanPham.Rows.Clear();
            foreach (var a in _lstLaptopViews)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgvSanPham);
                row.Cells[0].Value = $"{a.HangLaptop} {a.DongLaptop} {a.Ten}";
                row.Cells[1].Value = a.GiaBan;
                row.Cells[2].Value = a.SoLuongTon;

                var lstSerial = new List<string>();
                var lstIdLaptop = _laptopService.GetLaptopFromDb().Where(c => c.Ten == a.Ten);

                var serial = _serialLaptopService.GetSerialLaptopList().Where(c => c.TrangThai && c.IdLaptop == a.Id);

                if (serial != null)
                    lstSerial = serial.Select(c => c.Serial).ToList();


                var cbbCell = new DataGridViewComboBoxCell();
                cbbCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                cbbCell.AutoComplete = true;
                cbbCell.Items.AddRange(lstSerial.ToArray());
                row.Cells[3] = cbbCell;

                dgvSanPham.Rows.Add(row);
            }

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Thao tac";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            imageColumn.Image = Image.FromFile(@"D:\CODE\C#\DuAn_1_Quan_Ly_Ban_Laptop\3_GUI_PresentationLayer\Resources\add-to-cart.png");
            dgvSanPham.Columns.Add(imageColumn);
        }

        private void LoadGioHang()
        {
            dgvGioHang.ColumnCount = 8;
            dgvGioHang.Columns[0].Visible = false;
            dgvGioHang.Columns[1].Visible = false;
            dgvGioHang.Columns[2].Name = "Tên sản phẩm";
            dgvGioHang.Columns[3].Name = "Số serial";
            dgvGioHang.Columns[4].Name = "Số lượng";
            dgvGioHang.Columns[5].Name = "Giá tiền";
            dgvGioHang.Columns[5].DefaultCellStyle.Format = "N0";
            dgvGioHang.Columns[6].Name = "Giảm giá";
            dgvGioHang.Columns[6].DefaultCellStyle.Format = "N0";
            dgvGioHang.Columns[7].Name = "Thành tiền";
            dgvGioHang.Columns[7].DefaultCellStyle.Format = "N0";


            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "Thao tác";
            img.ImageLayout = DataGridViewImageCellLayout.Normal;
            img.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            img.Image = Image.FromFile(@"D:\CODE\C#\DuAn_1_Quan_Ly_Ban_Laptop\3_GUI_PresentationLayer\Resources\remove_to_cart.png");
            dgvGioHang.Columns.Add(img);

            dgvGioHang.Rows.Clear();
            foreach (var a in _lstCtHoaDonViews)
            {
                dgvGioHang.Rows.Add(a.Id, a.IdSanPham, $"{a.Hang} {a.Dong} {a.TenSanPham}", a.SerialSanPham, a.SoLuong, a.DonGia, a.GiamGia, a.ThanhTien);
            }

        }

        private void LoadKhachHang()
        {
            var lst = _khachHangService.GetAllKhachHangs();
            AutoCompleteStringCollection lstKhachHang = new AutoCompleteStringCollection();
            lst.ForEach(c => lstKhachHang.Add(c.SoDienThoai));
            cbbSdtKH.AutoCompleteCustomSource = lstKhachHang;
            cbbSdtKH.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cbbSdtKH.DisplayMember = "SoDienThoai";
            cbbSdtKH.Text = "Chọn số điện thoại";
            cbbSdtKH.Items.Clear();
            lst.ForEach(c => cbbSdtKH.Items.Add(c.SoDienThoai));
            cbbSdtKH.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void LoadKhuyenMai(Guid? idKhuyenMai)
        {
            var khuyenMai = _khuyenMaiServices.GetAllKhuyenMai().Where(c => c.TrangThai == 0 && c.Id == idKhuyenMai);
            cbbGiamGia.Text = "";
            cbbGiamGia.Items.Clear();
            if (khuyenMai.Any())
            {
                foreach (var a in khuyenMai)
                {
                    cbbGiamGia.Items.Add(a.Ten);
                    cbbGiamGia.SelectedIndex = 0;
                }
            }
        }
        private void dgvSanPham_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvSanPham.CurrentCell.ColumnIndex == 3 && e.Control is ComboBox)
            {
                ComboBox cbb = (ComboBox)e.Control;
                cbb.Name = "cbbSerial";
                cbb.DropDownStyle = ComboBoxStyle.DropDown;
                cbb.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
        }

        //Cell click San pham
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            _serialSelected = Convert.ToString(dgvSanPham.Rows[rowIndex].Cells[3].Value);

            if (e.ColumnIndex == 4)
            {
                if (_serialSelected == "")
                {
                    MessageBox.Show("Bạn chưa chọn serial cho sản phẩm", "Thông báo");
                    return;
                }

                AddGioHang(_serialSelected);
                _serialLaptopService.UpdateStatusSerial(_serialSelected);
                LoadSanPham();
                LoadGioHang();
                TinhTien();
            }

        }

        #region Donhangcho
        //private void dgcDHCho_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    btnThanhToan.Enabled = true;
        //    int rowIndex = e.RowIndex;
        //    if (rowIndex < 0)
        //    {
        //        return;
        //    }

        //    if (_lstCtHoaDonViews.Any(c => c.IdHoaDon == Guid.Empty))
        //    {
        //        MessageBox.Show("Bạn chưa lưu thay đổi đơn hàng");
        //        return;
        //    }

        //    _idHoaDon = Guid.Parse(dgcDHCho.Rows[rowIndex].Cells[0].Value.ToString());
        //    var hoaDonView = _hoaDonSerevice.GetAllHoaDonViews().Find(c => c.Id == _idHoaDon);
        //    if (hoaDonView != null)
        //    {
        //        cbbSdtKH.Text = hoaDonView.SDT;
        //        txtMaHD.Texts = hoaDonView.MaHd;
        //        txtGhiChu.Texts = hoaDonView.GhiChu;
        //        lblTongTien.Text = hoaDonView.TongTien.ToString();
        //        if (hoaDonView.HTThanhToan == "Chuyển khoản")
        //        {
        //            rbtnTransfer.Checked = true;
        //        }
        //        else
        //        {
        //            rbtnCash.Checked = true;
        //        }

        //        if (hoaDonView.DcNhanHang == "Tại cửa hàng")
        //        {
        //            rbtnTrucTiep.Checked = true;
        //        }
        //        else
        //        {
        //            rbtnShip.Checked = true;
        //            txtDiaChi.Texts = hoaDonView.DcNhanHang;
        //        }

        //    }
        //    _lstCtHoaDonViews.Clear();
        //    foreach (var a in _chiTietHoaDonService.GetAllChiTietHoaDon())
        //    {
        //        if (a.IdHoaDon == _idHoaDon)
        //        {
        //            _lstCtHoaDonViews.Add(a);
        //        }
        //    }
        //    LoadGioHang();
        //} 
        #endregion

        private void AddGioHang(string serial)
        {
            btnThanhToan.Enabled = true;
            var serialLaptop = _serialLaptopService.GetSerialLaptopList().Find(c => c.Serial == serial);
            if (serialLaptop == null)
            {
                MessageBox.Show("Không tìm được sản phẩm", "Thông báo");
                return;
            }
            _laptop = _laptopService.GetLaptopFromDb().Find(c => c.Id == serialLaptop.IdLaptop);

            if (_laptop is Laptop)
            {
                var hangLaptop = _hangLapTop.GetAllHangLaptops().Find(c => c.Id == _laptop.IdHangLaptop);
                var donLaptop = _dongLapTop.GetAllDongLaptop().Find(c => c.Id == _laptop.IdDongLaptop);

                ChiTietHoaDonView ctHoaDon = new ChiTietHoaDonView()
                {
                    Id = Guid.NewGuid(),
                    IdSanPham = _laptop.Id,
                    SoLuong = 1,
                    DonGia = _laptop.GiaBan,
                    TenSanPham = _laptop.Ten,
                    Hang = hangLaptop.Ten,
                    Dong = donLaptop.Ten,
                    SerialSanPham = serial
                };
                _lstCtHoaDonViews.Add(ctHoaDon);

                foreach (var a in _lstLaptopViews)
                {
                    if (a.Ten == _laptop.Ten)
                    {
                        a.SoLuongTon--;
                    }
                }

            }
        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            _idChiTietHD = Guid.Parse(dgvGioHang.Rows[rowIndex].Cells[0].Value.ToString());
            _serialSelected = Convert.ToString(dgvGioHang.Rows[rowIndex].Cells[3].Value);


            if (e.ColumnIndex == 8)
            {
                if (_serialSelected == "")
                {
                    MessageBox.Show("Khong co so serial");
                    return;
                }
                RemoveGioHang(_idChiTietHD);
                LoadGioHang();
                _serialLaptopService.UpdateStatusSerial(_serialSelected);
                TinhTien();
                LoadSanPham();
            }
        }

        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            _idChiTietHD = Guid.Parse(dgvGioHang.Rows[rowIndex].Cells[0].Value.ToString());
            var idLapttop = Guid.Parse(dgvGioHang.Rows[rowIndex].Cells[1].Value.ToString());
            var laptop = _laptopService.GetLaptopFromDb().FirstOrDefault(x => x.Id == idLapttop);
            if (laptop != null)
            {
                LoadKhuyenMai(laptop.IdKhuyenMai);

            }

        }

        private void RemoveGioHang(Guid idCtHoaDon)
        {
            var chiTietHD = _lstCtHoaDonViews.Find(x => x.Id == idCtHoaDon);
            _lstCtHoaDonViews.Remove(chiTietHD);

            var serial = _serialLaptopService.GetSerialLaptopList().Find(c => c.Serial == _serialSelected);
            if (serial != null)
            {
                var laptop = _laptopService.GetLaptopFromDb().Find(c => c.Id == serial.IdLaptop);
                if (laptop != null)
                {
                    foreach (var a in _lstLaptopViews)
                    {
                        if (a.Ten == laptop.Ten)
                        {
                            a.SoLuongTon++;
                        }
                    }
                }
            }
        }

        private void TinhTien()
        {
            if (_lstCtHoaDonViews.Count > 0)
            {
                decimal tongTien = 0;
                foreach (var a in _lstCtHoaDonViews)
                {
                    tongTien += a.ThanhTien;
                }
                lblTongTien.Text = tongTien.ToString("N0");
                return;
            }

            lblTongTien.Text = "0";
        }

        //Thanh toan
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!_lstCtHoaDonViews.Any())
            {
                MessageBox.Show("Không có sản phẩm trong giỏ hàng");
                return;
            }

            var khachHang = _khachHangService.GetAllKhachHangs().Find(c => c.SoDienThoai == cbbSdtKH.Text);
            if (khachHang == null)
            {
                MessageBox.Show("Bạn chưa chọn thông tin khách mua hàng", "Thông báo");
                return;
            }

            if (!rbtnTransfer.Checked && !rbtnCash.Checked)
            {
                MessageBox.Show("Bạn chưa chọn hình thức thanh toán");
                return;
            }

            if (MessageBox.Show("Xác nhận thanh toán hóa đơn?", "Hỏi", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            if (_idHoaDon == Guid.Empty)
            {
                _hoaDon = new HoaDonView()
                {
                    Id = Guid.NewGuid(),
                    IdNhanVien = Guid.Parse("f20f9470-1da9-44a9-8ad0-8b5543d47dc1"),
                    IdKhachHang = khachHang.Id,
                    MaHd = txtMaHD.Texts,
                    NgayTao = DateTime.Now,
                    NgayThanhToan = DateTime.Now,
                    GhiChu = txtGhiChu.Texts,
                    HTThanhToan = rbtnTransfer.Checked ? "Chuyển khoản" : "Tiền mặt",
                    TongTien = decimal.Parse(lblTongTien.Text),
                    TrangThaiHD = 0
                };
                _hoaDonSerevice.AddHoaDon(_hoaDon);

                foreach (var a in _lstCtHoaDonViews)
                {
                    a.IdHoaDon = _hoaDon.Id;
                    _chiTietHoaDonService.AddChiTietHoaDon(a);
                }
                LoadData();
                LoadGioHang();
                MessageBox.Show("Thanh toán thành công", "Thông báo");
            }
            else
            {
                var hoaDon = _hoaDonSerevice.GetAllHoaDonViews().FirstOrDefault(c => c.Id == _idHoaDon);
                hoaDon.TrangThaiHD = 0;
                hoaDon.NgayThanhToan = DateTime.Now;
                _hoaDonSerevice.UpdateHoaDon(hoaDon);
                LoadData();
                LoadGioHang();
                MessageBox.Show("Thanh toán thành công", "Thông báo");
            }


        }

        //Luu hoa don
        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if (!_lstCtHoaDonViews.Any())
            {
                MessageBox.Show("Không có sản phẩm trong giỏ hàng");
                return;
            }

            var khachHang = _khachHangService.GetAllKhachHangs().Find(c => c.SoDienThoai == cbbSdtKH.Text);
            if (khachHang == null)
            {
                MessageBox.Show("Bạn chưa chọn thông tin khách mua hàng", "Thông báo");
                return;
            }

            if (!rbtnTransfer.Checked && !rbtnCash.Checked)
            {
                MessageBox.Show("Bạn chưa chọn hình thức thanh toán");
                return;
            }

            if (_idHoaDon != Guid.Empty)
            {
                var hoaDon = _hoaDonSerevice.GetAllHoaDonViews().Find(c => c.Id == _idHoaDon);
                hoaDon.Id = _idHoaDon;
                hoaDon.IdNhanVien = Guid.Parse("f20f9470-1da9-44a9-8ad0-8b5543d47dc1");
                hoaDon.IdKhachHang = khachHang.Id;
                hoaDon.MaHd = txtMaHD.Texts;
                hoaDon.GhiChu = txtGhiChu.Texts;
                hoaDon.HTThanhToan = rbtnTransfer.Checked ? "Chuyển khoản" : "Tiền mặt";
                hoaDon.TrangThaiHD = 1;
                hoaDon.TongTien = decimal.Parse(lblTongTien.Text);
                _hoaDonSerevice.UpdateHoaDon(hoaDon);

                foreach (var a in _lstCtHoaDonViews.Where(c => c.IdHoaDon == Guid.Empty))
                {
                    a.IdHoaDon = _idHoaDon;
                    _chiTietHoaDonService.AddChiTietHoaDon(a);
                }
                _lstCtHoaDonViews.Clear();
                LoadGioHang();
                LoadData();
            }
            else
            {
                _hoaDon = new HoaDonView()
                {
                    Id = Guid.NewGuid(),
                    IdNhanVien = Guid.Parse("f20f9470-1da9-44a9-8ad0-8b5543d47dc1"),
                    IdKhachHang = khachHang.Id,
                    MaHd = txtMaHD.Texts,
                    NgayTao = DateTime.Now,
                    GhiChu = txtGhiChu.Texts,
                    HTThanhToan = rbtnTransfer.Checked ? "Chuyển khoản" : "Tiền mặt",
                    TrangThaiHD = 1,
                    TongTien = decimal.Parse(lblTongTien.Text),
                };
                _hoaDonSerevice.AddHoaDon(_hoaDon);
                foreach (var a in _lstCtHoaDonViews)
                {
                    a.IdHoaDon = _hoaDon.Id;
                    _chiTietHoaDonService.AddChiTietHoaDon(a);
                }

                MessageBox.Show("Tạo đơn hàng thành công", "Thông báo");
                _lstCtHoaDonViews.Clear();
                LoadGioHang();
                LoadData();
            }

        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (_lstCtHoaDonViews.Any())
            {
                foreach (var a in _lstCtHoaDonViews)
                {
                    _serialLaptopService.UpdateStatusSerial(a.SerialSanPham);
                }
            }
            LoadData();
        }

        private void activeCamera_Click(object sender, EventArgs e)
        {
            if (activeCamera.Text == "Bật camera")
            {
                _videoCaptureDevice = new VideoCaptureDevice(_captureVideo[cbbCamera.SelectedIndex].MonikerString);
                _videoCaptureDevice.NewFrame += VdeoCaptureDevice_NewFrame;
                _videoCaptureDevice.Start();
                tCamera.Enabled = true;
                tCamera.Start();
                activeCamera.Text = "Tắt camera";
            }
            else
            {
                _videoCaptureDevice.SignalToStop();
                while (_videoCaptureDevice.IsRunning)
                {
                    Thread.Sleep(100);
                }
                _videoCaptureDevice.Stop();
                tCamera.Stop();
                ptbCamera.Image = null;
                activeCamera.Text = "Bật camera";
            }
        }

        private void VdeoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            ptbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void GetDeviceVideoCapture()
        {
            _captureVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo a in _captureVideo)
            {
                cbbCamera.Items.Add(a.Name);
            }
            cbbCamera.SelectedIndex = 0;
        }

        private void tCamera_Tick(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)ptbCamera.Image;
            if (img != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)ptbCamera.Image);
                if (result != null)
                {
                    try
                    {
                        string decoded = result.ToString();
                        if (_serialLaptopService.GetSerialLaptopList().Where(c => c.TrangThai).FirstOrDefault(c => c.Serial == decoded) == null)
                        {
                            tCamera.Stop();
                            DialogResult dialog = MessageBox.Show($"Không tìm được sản phẩm có số serial: {decoded}", "Thông báo", MessageBoxButtons.OK);
                            if (dialog == DialogResult.OK)
                            {
                                tCamera.Start();
                                return;
                            }
                        }
                        AddGioHang(decoded);
                        _serialLaptopService.UpdateStatusSerial(decoded);
                        LoadSanPham();
                        LoadGioHang();
                        TinhTien();

                    }
                    catch (Exception)
                    {
                        _videoCaptureDevice.Stop();
                    }
                }
            }
        }

        private void cbbSdtKH_TextChanged(object sender, EventArgs e)
        {
            var khachHang = _khachHangService.GetAllKhachHangs().Find(c => c.SoDienThoai == cbbSdtKH.Text);
            if (khachHang != null)
            {
                lblHoTen.Text = khachHang.Hoten;
                return;
            }

            lblHoTen.Text = "";
        }

        private void ResetForm()
        {
            lblHoTen.Text = string.Empty;
            txtTimKiem.Texts = "";
            txtGhiChu.Texts = "";
            lblTongTien.Text = "";
            rbtnTransfer.Checked = false;
            rbtnCash.Checked = false;
            btnThanhToan.Enabled = false;

            cbbSdtKH.Text = "Chọn số điện thoại";


            //var seriaWhenClick = dgvSanPham.Rows[e.RowIndex].Cells[2].ToString();
            //var serial = _serialLaptopService.GetSerialLaptopList().FirstOrDefault(c => c.Serial == seriaWhenClick);
        }

        private void dgvGioHang_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvGioHang.Rows[e.RowIndex].Selected = true;
                this.menuStrip.Show(dgvGioHang, e.Location);
                menuStrip.Show(Cursor.Position);
            }

        }

        private void FrmBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_lstCtHoaDonViews.Any())
            {
                foreach (var a in _lstCtHoaDonViews)
                {
                    _serialLaptopService.UpdateStatusSerial(a.SerialSanPham);
                }
            }
        }

        private void strKhuyenMai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa click");
        }

        private void cbbGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbbGiamGia_SelectedValueChanged(object sender, EventArgs e)
        {
            string result = cbbGiamGia.Text;
            if (result == "") return;

            var khuyenMai = _khuyenMaiServices.GetAllKhuyenMai().Find(c => c.Ten == result);
            var index = _lstCtHoaDonViews.FindIndex(c => c.Id == _idChiTietHD);
            var chiTietHD = _lstCtHoaDonViews.ElementAt(index);
            if (khuyenMai.LoaiKhuyenMai == "Giảm %")
            {
                chiTietHD.GiamGia = chiTietHD.DonGia * (khuyenMai.GiaTri / 100);
            }
            else
            {
                chiTietHD.GiamGia = khuyenMai.GiaTri;
            }
            LoadGioHang();
            TinhTien();
        }
    }
}
