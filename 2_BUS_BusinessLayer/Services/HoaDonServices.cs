using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public class HoaDonServices : IHoaDonServices
    {
        IHoaDonRepository _DALhoaDon;
        List<HoaDon> _lstHoaDon;

      public HoaDonServices() 
        {
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

        public List<HoaDon> GetAll()
        {
           
            _lstHoaDon = (from x in _DALhoaDon.GetAllHoaDon()
                     select new HoaDon
                     {
                         Id= x. Id ,
                         Ma= x.Ma,
                         HinhThucTT=  x.HinhThucTT,
                         NgayTao =  x.NgayTao,
                         NgayThanhToan=  x.NgayThanhToan,
                         TrangThai =   x.TrangThai,
                         DiaChiNhanHang =  x.DiaChiNhanHang,
                         GhiChu=  x.GhiChu,
                         TongTien =  x.TongTien
                     }).ToList();
            return _lstHoaDon;
        }

        public bool Sua(HoaDon hoaDon)
        {
            _DALhoaDon.UpdateHoaDon(hoaDon);
            return true;
        }
    }
}
