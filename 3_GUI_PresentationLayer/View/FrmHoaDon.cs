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
        public FrmHoaDon()
        {
            InitializeComponent();
            ShowHĐ();
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

       
    }
}
