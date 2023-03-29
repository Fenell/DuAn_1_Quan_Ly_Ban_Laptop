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
    public partial class FrmHoaDon : Form
    {
        IHoaDonServices _Bus_hoaDon;
        List<HoaDon> _lst_hoaDon;
        IHoaDonChiTietServices _bus_chiTietHoaDon;
        List<ChiTietHoaDon> _lst_CTHD;
        public FrmHoaDon()
        {
            _bus_chiTietHoaDon = new HoaDonChiTietServices();
            _lst_CTHD = new List<ChiTietHoaDon>();
            _Bus_hoaDon = new HoaDonServices();
            _lst_hoaDon = new List<HoaDon>();
            InitializeComponent();
            ShowHĐ();
            ShowCTHĐ();
        }
        public void ShowHĐ()
        {

            dgv_hoaDon.ColumnCount = 10;
            dgv_hoaDon.Columns[0].Name = " ID";
            dgv_hoaDon.Columns[1].Name = " IdNhanVien";
            dgv_hoaDon.Columns[2].Name = " IdKhachHang";
            dgv_hoaDon.Columns[3].Name = " Ma";
            dgv_hoaDon.Columns[4].Name = " HinhThucTT";
            dgv_hoaDon.Columns[5].Name = " NgayTao";
            dgv_hoaDon.Columns[6].Name = " NgayThanhToan";
            dgv_hoaDon.Columns[7].Name = " DiaChiNhanHang";
            dgv_hoaDon.Columns[8].Name = " Ghi chú";
            dgv_hoaDon.Columns[9].Name = " TongTien";
            dgv_hoaDon.Rows.Clear();
            foreach (var item in _Bus_hoaDon.GetAll())
            {
                dgv_hoaDon.Rows.Add(item.Id, item.IdNhanVien, item.IdKhachHang, item.Ma, item.HinhThucTT, item.NgayTao, item.NgayThanhToan, item.DiaChiNhanHang, item.GhiChu, item.TongTien);
            }
        }
        public void ShowCTHĐ()
        {


            dgv_CTHD.ColumnCount = 7;
            dgv_CTHD.Columns[0].Name = " ID";
            dgv_CTHD.Columns[1].Name = " IdLaptop";
            dgv_CTHD.Columns[2].Name = " IdLinhKien";
            dgv_CTHD.Columns[3].Name = " IdHoaDon";
            dgv_CTHD.Columns[4].Name = " SoLuong";
            dgv_CTHD.Columns[5].Name = " DonGia";
            dgv_CTHD.Columns[6].Name = " ThanhTien";

            dgv_hoaDon.Rows.Clear();
            foreach (var item in _bus_chiTietHoaDon.GetAll())
            {
                dgv_CTHD.Rows.Add(item.Id, item.IdLaptop, item.IdLinhKien, item.IdHoaDon, item.SoLuong, item.DonGia, item.ThanhTien);
            }
        }

        private void dateTimePickerCustom2_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePickerCustom2.Value != null)
            {
                DateTime startDate = dateTimePickerCustom1.Value;
                DateTime endDate = dateTimePickerCustom2.Value;

                _lst_hoaDon = _Bus_hoaDon.GetAll().Where(o => o.NgayTao >= startDate && o.NgayTao <= endDate)
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
                _lst_hoaDon = _Bus_hoaDon.GetAll().Where(o => o.TrangThai == 0)
                                       .ToList();
                ShowHĐ();
            }
            else if ((radioButtonCustom2.Checked ))
            {
                _lst_hoaDon = _Bus_hoaDon.GetAll().Where(o => o.TrangThai == 1)
                                       .ToList();
                ShowHĐ();
            }else if ((radioButtonCustom3.Checked))
            {
                _lst_hoaDon = _Bus_hoaDon.GetAll().Where(o => o.TrangThai == 2)
                                       .ToList();
                ShowHĐ();
            }
        }

        private void bt_theongay_Click(object sender, EventArgs e)
        {
            var id = textBoxCustom2_04.Text;
            dgv_hoaDon.Rows.Clear();
            dgv_hoaDon.Rows.Clear();
            var items = _Bus_hoaDon.GetAll().Where(x => x.Id = id);
            if (items.Any())
            {
                foreach (var item in _Bus_hoaDon.GetAll())
                {
                    dgv_hoaDon.Rows.Add(item.Id, item.IdNhanVien, item.IdKhachHang, item.Ma, item.HinhThucTT, item.NgayTao, item.NgayThanhToan, item.DiaChiNhanHang, item.GhiChu, item.TongTien);
                }
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào có Mã hóa đơn tương ứng");
            }
        }
    }
}