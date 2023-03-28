using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.ViewModel;

namespace _2_BUS_BusinessLayer.Services
{
    public class ChiTietHoaDonService:IChiTietHoaDonService
    {
        private IHoaDonRepository _hoaDonRepository;
        private IChiTietHoaDonRepository _chiTietHoaDonRepository;
        private ILapTopRepository _lapTopRepository;
        private ILinhKienRepository _linhKienRepository;

        public ChiTietHoaDonService()
        {
            _hoaDonRepository = new HoaDonRepository();
            _chiTietHoaDonRepository = new ChiTietHoaDonRepository();
            _lapTopRepository = new LapTopRepository();
            _linhKienRepository = new LinhKienRepository();
        }
        public string AddChiTietHoaDon(ChiTietHoaDonView obj)
        {
            var chiTietHoaDon = new ChiTietHoaDon()
            {
                Id = obj.Id,
                IdHoaDon = obj.IdHoaDon,
                IdLaptop = obj.IdSanPham,
                IdLinhKien = obj.IdSanPham,
                DonGia = obj.DonGia,
                SoLuong = obj.SoLuong,
                ThanhTien = (obj.DonGia * obj.SoLuong)
            };

            if (_chiTietHoaDonRepository.AddChiTietHoaDon(chiTietHoaDon))
            {
                return "Thanh cong";
            }

            return "Khong thanh cong";
        }

        public string RemoveChiTietHoaDon(Guid id)
        {
            throw new NotImplementedException();
        }

        public string UpdateChiTietHoaDon(ChiTietHoaDonView obj)
        {
            var chiTietHoaDon = _chiTietHoaDonRepository.GetChiTietHoaDonById(obj.Id);
            if (chiTietHoaDon != null)
            {
                chiTietHoaDon.IdHoaDon = obj.IdHoaDon;
                chiTietHoaDon.IdLaptop = obj.IdSanPham;
                chiTietHoaDon.IdLinhKien = obj.IdSanPham;
                chiTietHoaDon.SoLuong= obj.SoLuong;
                chiTietHoaDon.DonGia = obj.DonGia;
                chiTietHoaDon.ThanhTien = obj.ThanhTien;

                if (_chiTietHoaDonRepository.UpdateChiTietHoaDon(chiTietHoaDon))
                {
                    return "Sửa thành công";
                }

                return "Sửa thất bại";
            }

            return "Sửa thất bại";
        }

        public string UpdateStatusChiTietHoaDon(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietHoaDonView> GetAllChiTietHoaDon()
        {
            var lst = (from a in _chiTietHoaDonRepository.GetAllChiTietHoaDon()
                join b in _hoaDonRepository.GetAllHoaDon() on a.IdHoaDon equals b.Id
                join c in _lapTopRepository.GetAllLapTop() on a.IdLaptop equals c.Id into ltJoin
                from sanPhamLaptop in ltJoin.DefaultIfEmpty()
                join d in _linhKienRepository.GetAllLinhKien() on a.IdLinhKien equals d.Id into lkJoin
                from sanPhamLk in lkJoin.DefaultIfEmpty()
                select new ChiTietHoaDonView()
                {
                    Id = a.Id,
                    IdHoaDon = b.Id,
                    IdSanPham = sanPhamLaptop.Id != null ? sanPhamLaptop.Id : sanPhamLk.Id,
                    TenSanPham = sanPhamLaptop.Ten ?? sanPhamLk.Ten,
                    SoLuong = a.SoLuong,
                    DonGia = a.DonGia,
                }).ToList();

            return lst;
        }
    }
}
