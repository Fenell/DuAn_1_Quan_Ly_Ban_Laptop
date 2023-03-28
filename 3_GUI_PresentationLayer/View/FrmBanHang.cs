using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.ViewModel;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmBanHang : Form
    {
        private ILaptopService _laptopService;
        private ISerialLaptopService _serialLaptopService;
        private Laptop _laptop;
        private List<ChiTietHoaDonView> _lstCtHoaDonViews;
        private string _serialSelected;
        public FrmBanHang()
        {
            InitializeComponent();
            _laptopService = new LaptopService();
            _serialLaptopService = new SerialLaptopService();
            _laptop = new Laptop();
            _lstCtHoaDonViews = new List<ChiTietHoaDonView>();
            LoadSanPham();
        }

        private void LoadSanPham()
        {
            dgvSanPham.ColumnCount = 4;
            dgvSanPham.Columns[0].Name = "Ten";
            dgvSanPham.Columns[1].Name = "Gia";
            dgvSanPham.Columns[2].Name = "So luong";
            dgvSanPham.Columns[3].Name = "Serial";

            dgvSanPham.Rows.Clear();
            foreach (var a in _laptopService.GetAllLaptop())
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
            dgvGioHang.ColumnCount = 5;
            dgvGioHang.Columns[0].Visible = false;
            dgvGioHang.Columns[1].Name = "Tên sản phẩm";
            dgvGioHang.Columns[2].Name = "Giá tiền";
            dgvGioHang.Columns[3].Name = "Số lượng";
            dgvGioHang.Columns[4].Name = "Thành tiền";

            dgvGioHang.Rows.Clear();
            foreach (var a in _lstCtHoaDonViews)
            {
                dgvGioHang.Rows.Add(a.Id, a.TenSanPham, a.DonGia, a.SoLuong, a.ThanhTien);
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

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            //var seriaWhenClick = dgvSanPham.Rows[e.RowIndex].Cells[2].ToString();
            //var serial = _serialLaptopService.GetSerialLaptopList().FirstOrDefault(c => c.Serial == seriaWhenClick);
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            _serialSelected = Convert.ToString(dgvSanPham.Rows[rowIndex].Cells[3].Value);
            if (_serialSelected == "")
            {
                MessageBox.Show("Bạn chưa chọn serial cho sản phẩm");
                return;

            }

            if (e.ColumnIndex == 4 && string.IsNullOrEmpty(dgvSanPham.Rows[rowIndex].Cells[3].Value.ToString()) == false)
            {
                AddGioHang(_serialSelected);
                LoadGioHang();
            }

        }

        private void AddGioHang(string serial)
        {
            var serialLaptop = _serialLaptopService.GetSerialLaptopList().FirstOrDefault(c => c.Serial == serial);
            if (serialLaptop != null)
            {
                _laptop = _laptopService.GetLaptopFromDb().FirstOrDefault(c => c.Id == serialLaptop.IdLaptop);
            }

            ChiTietHoaDonView ctHoaDon = new ChiTietHoaDonView()
            {
                Id = Guid.NewGuid(),
                IdSanPham = _laptop.Id,
                SoLuong = 1,
                DonGia = _laptop.GiaBan,
                TenSanPham = $"{_laptop.Ten}",
            };
            _lstCtHoaDonViews.Add(ctHoaDon);
        }
    }
}
