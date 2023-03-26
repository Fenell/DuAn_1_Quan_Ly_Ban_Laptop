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
    public class SanPhamLaptopRepository : ISanPhamLaptopRepository
    {
        QlBanLaptopContext _lapTopContext;
        public SanPhamLaptopRepository()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddLapTop(SanPhamLaptop lapTop)
        {
            try
            {
                if(lapTop != null)
                {
                    lapTop.Id = Guid.NewGuid();
                    _lapTopContext.Add(lapTop);
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

        public List<SanPhamLaptop> GetAllLapTop()
        {
            return _lapTopContext.Laptops.ToList();
        }

        public SanPhamLaptop GetLapTopById(Guid idLapTop)
        {
            var ketqua = _lapTopContext.Laptops.Find(idLapTop);
            return ketqua;
        }

        public bool UpdateLapTop(SanPhamLaptop lapTop)
        {
            var ketqua = _lapTopContext.Laptops.FirstOrDefault(c=>c.Id == lapTop.Id);
            if (ketqua != null)
            {
                ketqua.ManHinh = lapTop.ManHinh;
                ketqua.Mota = lapTop.Mota;
                ketqua.MauSac = lapTop.MauSac;
                ketqua.TrongLuong = lapTop.TrongLuong;
                ketqua.GiaNhap = lapTop.GiaNhap;
                ketqua.GiaBan = lapTop.GiaBan;
                ketqua.NamBh = lapTop.NamBh;
                ketqua.TrangThai = lapTop.TrangThai;
                ketqua.HinhAnh = lapTop.HinhAnh;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
