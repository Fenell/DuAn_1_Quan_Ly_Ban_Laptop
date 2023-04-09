﻿using _1_DAL_DataAccessLayer.IRepositories;
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
            _bus_chiTietHoaDon = new ChiTietHoaDonService();
            _lst_CTHD = new List<ChiTietHoaDon>();
            _Bus_hoaDon = new HoaDonService();
            _lst_hoaDon = new List<HoaDonView>();
            InitializeComponent();
            ShowHĐ();
            CheckTrangThai();

        }
        public void loadHDCT(Guid id)
        {
            _ID = id;
            dgv_CTHD.Rows.Clear();
            dgv_CTHD.ColumnCount = 6;
            dgv_CTHD.Columns[0].Visible = false;
            dgv_CTHD.Columns[1].Name = "Tên laptop";
            dgv_CTHD.Columns[2].Name = "Số lượng";
            dgv_CTHD.Columns[3].Name = "Đơn giá";
            dgv_CTHD.Columns[3].DefaultCellStyle.Format = "N0";
            dgv_CTHD.Columns[4].Name = "Giảm giá";
            dgv_CTHD.Columns[4].DefaultCellStyle.Format = "N0";
            dgv_CTHD.Columns[5].Name = "Thành tiền";
            dgv_CTHD.Columns[5].DefaultCellStyle.Format = "N0";


            dgv_CTHD.Rows.Clear();
            foreach (var item in _bus_chiTietHoaDon.GetAllCTHĐ(id))
            {
                dgv_CTHD.Rows.Add(item.Id, item.TenSanPham, item.SoLuong, item.DonGia, item.GiamGia, item.ThanhTien);
            }
        }
        public void ShowHĐ()
        {

            dgv_hoaDon.ColumnCount = 10;
            dgv_hoaDon.Columns[0].Visible = false;
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




        private void radioButtonCustom1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void CheckTrangThai()
        {
            if (radioButtonCustom1.Checked)
            {
                _lst_hoaDon = _Bus_hoaDon.GetAllHoaDonViews().Where(o => o.TrangThaiHD == 0)
                                       .ToList();
                ShowHĐ();
            }
            else if ((radioButtonCustom2.Checked))
            {
                _lst_hoaDon = _Bus_hoaDon.GetAllHoaDonViews().Where(o => o.TrangThaiHD == 1)
                                       .ToList();
                ShowHĐ();
            }
           
        }

        private void bt_theongay_Click(object sender, EventArgs e)
        {
            var id = textBoxCustom2_04.Text;
            dgv_hoaDon.Rows.Clear();
            dgv_hoaDon.Rows.Clear();
            var items = _Bus_hoaDon.GetAllHoaDonViews().Where(x => x.SDT == id);
            if (items.Any())
            {
                foreach (var a in items)
                {
                    ShowHĐ();
                }
            }
            else
            {
                MessageBox.Show("Không có");
            }
        }
              
        private void dgv_hoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _ID = Guid.Parse(dgv_hoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
                loadHDCT(_ID);
            }
        }

        private void bt_TheoNgayTuyChinh_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1);

            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var listHoaDon = _Bus_hoaDon.GetAllHoaDonViews().Where(hd => hd.NgayTao >= startDate && hd.NgayTao <= endDate).ToList();

            if (listHoaDon.Count == 0)
            {
                MessageBox.Show("Không có hoá đơn nào được tạo trong khoảng thời gian bạn đã chọn, vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgv_hoaDon.Rows.Clear();

            foreach (var item in listHoaDon)
            {
                ShowHĐ();
            }
        }
    }
}