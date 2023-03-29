using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Repositories
{
    public class HoaDonRepository : IHoaDonRepository
    {
        QlBanLaptopContext _lapTopContext;
        public HoaDonRepository()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddHoaDon(HoaDon hoaDon)
        {
            try
            {
                if (hoaDon != null)
                {
                    hoaDon.Id = Guid.NewGuid();
                    _lapTopContext.Add(hoaDon);
                    _lapTopContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<HoaDon> GetAllHoaDon()
        {
            return _lapTopContext.HoaDons.ToList();
        }

        public HoaDon GetHoaDonById(Guid idHoaDon)
        {
            var ketqua = _lapTopContext.HoaDons.Find(idHoaDon);
            return ketqua;
        }

        public bool UpdateHoaDon(HoaDon hoaDon)
        {
            var ketqua = _lapTopContext.HoaDons.FirstOrDefault(c=>c.Id == hoaDon.Id);
            if (ketqua != null)
            {
                ketqua.Ma = hoaDon.Ma;
                ketqua.HinhThucTT = hoaDon.HinhThucTT;
                ketqua.NgayTao = hoaDon.NgayTao;
                ketqua.NgayThanhToan = hoaDon.NgayThanhToan;
                ketqua.TrangThaiGH = hoaDon.TrangThaiGH;
                ketqua.DiaChiNhanHang = hoaDon.DiaChiNhanHang;
                ketqua.GhiChu = hoaDon.GhiChu;
                ketqua.TongTien = hoaDon.TongTien;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
