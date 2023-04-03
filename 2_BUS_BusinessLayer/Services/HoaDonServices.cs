using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public class HoaDonServices : IHoaDonServices
    {
        IKhachHangRepository _DAL_KhacHang;
        IHoaDonRepository _DALhoaDon;
        INhanVienRepository _DAl_NhanVien;
        List<HoaDon> _lstHoaDon;

      public HoaDonServices() 
        {
            _DAL_KhacHang = new KhachHangRepository();
            _DAl_NhanVien = new NhanVienRepository();
            _DALhoaDon = new HoaDonRepository();
            _lstHoaDon = new List<HoaDon>();
                }
        public bool Add(HoaDon hoaDon)
        {
            if (hoaDon == null)
            {
                return false;

            }
            _DALhoaDon.AddHoaDon(hoaDon);
            return true;
        }

        public List<hoaDonView> GetAll()
        {
           List<hoaDonView> _lsthoadon = new List<hoaDonView>();
            _lsthoadon = (from x in _DALhoaDon.GetAllHoaDon()
                          join y in _DAL_KhacHang.GetAllKhachHang() on x.IdKhachHang equals y.Id
                          join z in _DAl_NhanVien.GetAllNhanVien() on x.IdNhanVien equals z.Id
                        
                          select new hoaDonView
                          {
                              Id = x.Id,
                              IdNv = x.IdNhanVien,
                              IdKh = x.IdKhachHang,
                              TenKH = y.Hoten,
                              TenNV = z.Hoten,
                              Ma = x.Ma,
                              HTTT = x.HinhThucTT,
                              NgayTao = x.NgayTao,
                              NgayThanhToan = x.NgayThanhToan,
                              TrangThai = x.TrangThai,

                              GhiChu = x.GhiChu,
                              TongTien = x.TongTien
                          }).ToList();
            return _lsthoadon;
        }

        public bool Sua(HoaDon hoaDon)
        {
            _DALhoaDon.UpdateHoaDon(hoaDon);
            return true;
        }
    }
}
