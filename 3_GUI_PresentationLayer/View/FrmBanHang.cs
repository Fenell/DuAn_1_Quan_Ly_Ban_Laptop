﻿using System;
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
        private IKhachHangService _khachHangService;
        private IHoaDonSerevice _hoaDonSerevice;
        private IChiTietHoaDonService _chiTietHoaDonService;

        private IHangLapTopRepositories _hangLapTop;
        private IDongLapTopRepositories _dongLapTop;

        private Laptop _laptop;
        private List<ChiTietHoaDonView> _lstCtHoaDonViews;
        private string _serialSelected;
        private FilterInfoCollection _captureVideo;
        private VideoCaptureDevice _videoCaptureDevice;
        private List<LaptopView> _lstLaptopViews;
        public FrmBanHang()
        {
            InitializeComponent();
            _laptopService = new LaptopService();
            _serialLaptopService = new SerialLaptopService();
            _lstCtHoaDonViews = new List<ChiTietHoaDonView>();
            _laptop = new Laptop();
            _lstLaptopViews = new List<LaptopView>();
            _khachHangService = new KhachHangService();
            _hoaDonSerevice = new HoaDonService();
            _chiTietHoaDonService = new ChiTietHoaDonService();

            _hangLapTop = new HangLaptopRepositories();
            _dongLapTop = new DongLapTopReposittoies();

            _lstLaptopViews = _laptopService.GetAllLaptop();
            LoadData();
            GetDeviceVideoCapture();
            LoadSanPham();
        }

        private void LoadData()
        {
            AutoCompleteStringCollection lstKhachHang = new AutoCompleteStringCollection();
            var lst = _khachHangService.GetLstKhachHang();
            lst.ForEach(c => lstKhachHang.Add(c.SoDienThoai));
            cbbSdtKH.DisplayMember = "SoDienThoai";
            cbbSdtKH.DataSource = lst;
            cbbSdtKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbbSdtKH.AutoCompleteCustomSource = lstKhachHang;

            lblMaHD.Text = _hoaDonSerevice.AutoGenerateMa();
        }

        private void LoadSanPham()
        {
            dgvSanPham.ColumnCount = 4;
            dgvSanPham.Columns[0].Name = "Ten";
            dgvSanPham.Columns[1].Name = "Gia";
            dgvSanPham.Columns[2].Name = "So luong";
            dgvSanPham.Columns[3].Name = "Serial";

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

                foreach (var x in lstIdLaptop)
                {
                    var serial = _serialLaptopService.GetSerialLaptopList().Where(c => c.TrangThai).FirstOrDefault(c => c.IdLaptop == x.Id);

                    if (serial != null)
                        lstSerial.Add(serial.Serial);
                }

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
            dgvGioHang.ColumnCount = 6;
            dgvGioHang.Columns[0].Visible = false;
            dgvGioHang.Columns[1].Visible = false;
            dgvGioHang.Columns[2].Name = "Tên sản phẩm";
            dgvGioHang.Columns[3].Name = "Giá tiền";
            dgvGioHang.Columns[4].Name = "Số lượng";
            dgvGioHang.Columns[5].Name = "Thành tiền";

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "Thao tác";
            img.ImageLayout = DataGridViewImageCellLayout.Normal;
            img.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            img.Image = Image.FromFile(@"D:\CODE\C#\DuAn_1_Quan_Ly_Ban_Laptop\3_GUI_PresentationLayer\Resources\remove_to_cart.png");
            dgvGioHang.Columns.Add(img);

            dgvGioHang.Rows.Clear();
            foreach (var a in _lstCtHoaDonViews)
            {
                dgvGioHang.Rows.Add(a.Id, a.SerialSanPham, a.TenSanPham, a.DonGia, a.SoLuong, a.ThanhTien);
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
                cbb.Text = "Chọn serial";
            }
        }

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
            if (_serialSelected == "Chọn serial")
            {
                MessageBox.Show("Bạn chưa chọn serial cho sản phẩm");
                return;

            }

            if (e.ColumnIndex == 4 && string.IsNullOrEmpty(dgvSanPham.Rows[rowIndex].Cells[3].Value.ToString()) == false)
            {
                AddGioHang(_serialSelected);
                _serialLaptopService.UpdateStatusSerial(_serialSelected);
                LoadSanPham();
                LoadGioHang();
                TinhTien();
            }

        }

        private void AddGioHang(string serial)
        {
            var serialLaptop = _serialLaptopService.GetSerialLaptopList().Find(c => c.Serial == serial);
            if (serialLaptop != null)
            {
                _laptop = _laptopService.GetLaptopFromDb().Find(c => c.Id == serialLaptop.IdLaptop);
            }

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
                    TenSanPham = $"{hangLaptop.Ten} {donLaptop.Ten} {_laptop.Ten}",
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
            var idChiTietHD = Guid.Parse(dgvGioHang.Rows[rowIndex].Cells[0].Value.ToString());
            _serialSelected = Convert.ToString(dgvGioHang.Rows[rowIndex].Cells[1].Value);

            if (e.ColumnIndex == 6)
            {
                if (_serialSelected == "")
                {
                    MessageBox.Show("Khong co so serial");
                    return;
                }
                RemoveGioHang(idChiTietHD);
                LoadGioHang();
                _serialLaptopService.UpdateStatusSerial(_serialSelected);
                TinhTien();
                LoadSanPham();
            }
        }

        private void RemoveGioHang(Guid id)
        {
            var chiTietHD = _lstCtHoaDonViews.Find(x => x.Id == id);
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
                lblTongTien.Text = tongTien.ToString();
                txtKhachDua.Texts = tongTien.ToString();
                return;
            }

            txtKhachDua.Texts = "0";
            lblTongTien.Text = "0";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!_lstCtHoaDonViews.Any())
            {
                MessageBox.Show("Không có sản phẩm trong giỏ hàng");
                return;
            }

            var khachHang = _khachHangService.GetLstKhachHang().Find(c => c.SoDienThoai == cbbSdtKH.Text);
            if (khachHang == null)
            {
                MessageBox.Show("Bạn chưa chọn thông tin khách mua hàng", "Thông báo");
                return;
            }

            HoaDonView hoaDon = new HoaDonView()
            {
                Id = Guid.NewGuid(),
                IdNhanVien = Guid.Parse("f20f9470-1da9-44a9-8ad0-8b5543d47dc1"),
                IdKhachHang = khachHang.Id,
                MaHd = lblMaHD.Text,
                NgayTao = DateTime.Now,
                NgayThanhToan = DateTime.Now,
                GhiChu = txtGhiChu.Texts,
                HTThanhToan = rbtnTransfer.Checked ? "Chuyển khoản" : "Tiền mặt",
                TongTien = decimal.Parse(lblTongTien.Text),
            };
            _hoaDonSerevice.AddHoaDon(hoaDon);

            foreach (var a in _lstCtHoaDonViews)
            {
                a.IdHoaDon = hoaDon.Id;
                _chiTietHoaDonService.AddChiTietHoaDon(a);
            }

            MessageBox.Show("Thanh toan ok!");

        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {

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
            var khachHang = _khachHangService.GetLstKhachHang().Find(c => c.SoDienThoai == cbbSdtKH.Text);
            if (khachHang != null)
            {
                lblHoTen.Text = khachHang.Hoten;
            }
        }
    }
}
