using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public class HoaDonChiTietServices : IHoaDonChiTietServices
    {
        IChiTietHoaDonRepository _DALCThoaDon;
        List<ChiTietHoaDon> _lstCTHoaDon;
        ILapTopRepository _DAL_Laptop;
        ILinhKienRepository _Dal_LinhKien;
        public HoaDonChiTietServices()
        {
            _DAL_Laptop = new LapTopRepository();
            _Dal_LinhKien = new LinhKienRepository();
            _DALCThoaDon = new ChiTietHoaDonRepository();
            _lstCTHoaDon = new List<ChiTietHoaDon>();
        }
        public bool Add(ChiTietHoaDon CtHoaDon)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietHoaDon> GetAll()
        {

            _lstCTHoaDon = (from x in _DALCThoaDon.GetAllChiTietHoaDon()
                            join y in _DAL_Laptop.GetAllLapTop() on x.IdLaptop equals y.Id
                            join z in _Dal_LinhKien.GetAllLinhKien() on x.IdLinhKien equals z.Id
                          
                            select new ChiTietHoaDon
                          {
                          Id = x.Id,
                          IdLaptop=x.IdLaptop,
                          IdLinhKien = x.IdLinhKien,
                          IdHoaDon = x.IdHoaDon,
                          SoLuong = x.SoLuong,
                          DonGia = x.DonGia,
                          ThanhTien = x.ThanhTien
                          }).ToList();
            return _lstCTHoaDon;
        }

        public bool Sua(ChiTietHoaDon CtHoaDon)
        {
            throw new NotImplementedException();
        }
    }
}
