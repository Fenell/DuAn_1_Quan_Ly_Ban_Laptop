using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.ViewModel;
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
    public partial class FrmHoaDon : Form
    {
        //IHangLapTopRepositories _Bus_hangLapTop;
        ILaptopService _Bus_LapTop;
        IHoaDonSerevice _Bus_hoaDon;
        List<HoaDonView> _lst_hoaDon;
        IChiTietHoaDonService _bus_chiTietHoaDon;
        List<ChiTietHoaDon> _lst_CTHD;
        private Guid _ID;
        public FrmHoaDon()
        {
            
            _Bus_LapTop = new LaptopService();
            _bus_chiTietHoaDon = new ChiTietHoaDonService ();
            _lst_CTHD = new List<ChiTietHoaDon>();
            _Bus_hoaDon = new HoaDonService();
            _lst_hoaDon = new List<HoaDonView>();
            InitializeComponent();
            ShowHĐ();
           
        }
        public void loadHDCT(Guid id)
        {
            _ID = id;
            dgv_CTHD.Rows.Clear();
            foreach (var item in _bus_chiTietHoaDon.GetAllChiTietHoaDon(id))
            {
                dgv_CTHD.Rows.Add( item.TenSanPham, item.SoLuong, item.DonGia,item.ThanhTien);
            }
        }
        public void ShowHĐ()
        {

            dgv_hoaDon.ColumnCount = 10;
            dgv_hoaDon.Columns[0].Name = " ID";
            dgv_hoaDon.Columns[1].Name = " Tên Nhân Viên";
            dgv_hoaDon.Columns[2].Name = " Tên Khách Hàng";
            dgv_hoaDon.Columns[3].Name = " Ma";
            dgv_hoaDon.Columns[4].Name = " HinhThucTT";
            dgv_hoaDon.Columns[5].Name = " NgayTao";
            dgv_hoaDon.Columns[6].Name = " NgayThanhToan";
            dgv_hoaDon.Columns[7].Name = " Ghi chú";
            dgv_hoaDon.Columns[8].Name = " TongTien";
            dgv_hoaDon.Rows.Clear();
            foreach (var item in _Bus_hoaDon.GetAllHoaDonViews())
            {
               dgv_hoaDon.Rows.Add(item.Id, item.TenNhanVien, item.TenKhachHang, item.MaHd, item.HTThanhToan, item.NgayTao, item.NgayThanhToan, item.GhiChu, item.TongTien);
            }
        }
       

        private void dateTimePickerCustom2_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePickerCustom2.Value != null)
            {
                DateTime startDate = dateTimePickerCustom1.Value;
                DateTime endDate = dateTimePickerCustom2.Value;

                _lst_hoaDon = _Bus_hoaDon.GetAllHoaDonViews().Where(o => o.NgayTao >= startDate && o.NgayTao <= endDate)
                                        .ToList();
                ShowHĐ();
            }
        }

        private void radioButtonCustom1_CheckedChanged(object sender, EventArgs e)
        { 
           
        }

        public void CheckTrangThai()
        {
            if (radioButtonCustom1.Checked )
            {
                _lst_hoaDon = _Bus_hoaDon.GetAllHoaDonViews().Where(o => o.TrangThaiHD == 0)
                                       .ToList();
                ShowHĐ();
            }
            else if ((radioButtonCustom2.Checked ))
            {
                _lst_hoaDon = _Bus_hoaDon.GetAllHoaDonViews().Where(o => o.TrangThaiHD == 1)
                                       .ToList();
                ShowHĐ();
            }else if ((radioButtonCustom3.Checked))
            {
                _lst_hoaDon = _Bus_hoaDon.GetAllHoaDonViews().Where(o => o.TrangThaiHD == 2)
                                       .ToList();
                ShowHĐ();
            }
        }

        private void bt_theongay_Click(object sender, EventArgs e)
        {
            var id = textBoxCustom2_04.Text;
            dgv_hoaDon.Rows.Clear();
            dgv_hoaDon.Rows.Clear();
            var items = _Bus_hoaDon.GetAllHoaDonViews().Where(x => x.MaHd == id);
            if (items.Any())
            {
                foreach (var item in _Bus_hoaDon.GetAllHoaDonViews())
                {
                    dgv_hoaDon.Rows.Add(item.Id, item.TenNhanVien, item.TenKhachHang, item.MaHd, item.HTThanhToan, item.NgayTao, item.NgayThanhToan,  item.GhiChu, item.TongTien);
                }
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào có Mã hóa đơn tương ứng");
            }
        }
        private void comboLoaiSanPham()
        {
            var load = (from x in _Bus_LapTop.GetAllLaptop() select x.HangLaptop);
             
        }

        private void comboBoxCustom1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cbb_loaiSanPham.SelectedItem.ToString();

        }

        private void dgv_hoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               _ID  = Guid.Parse(dgv_hoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
                loadHDCT(_ID);
            }
        }
    }
}