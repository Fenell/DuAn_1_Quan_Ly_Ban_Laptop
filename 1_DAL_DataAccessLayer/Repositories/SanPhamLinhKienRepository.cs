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
    public class SanPhamLinhKienRepository : ISanPhamLinhKienRepository
    {
        QlBanLaptopContext _lapTopContext;
        public SanPhamLinhKienRepository()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddLinhKien(SanPhamLinhKien linhKien)
        {
            try
            {
                if (linhKien != null)
                {
                    linhKien.Id = Guid.NewGuid();
                    _lapTopContext.Add(linhKien);
                    _lapTopContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<SanPhamLinhKien> GetAllLinhKien()
        {
            return _lapTopContext.LinhKiens.ToList();
        }

        public SanPhamLinhKien GetLinhKienById(Guid idLinhKien)
        {
            var ketqua = _lapTopContext.LinhKiens.Find(idLinhKien);
            return ketqua;
        }

        public bool UpdateLinhKien(SanPhamLinhKien linhKien)
        {
            var ketqua = _lapTopContext.LinhKiens.FirstOrDefault(c => c.Id == linhKien.Id);
            if (ketqua != null)
            {
                ketqua.Ten = linhKien.Ten;
                ketqua.MoTaChiTiet = linhKien.MoTaChiTiet;
                ketqua.TonKho = linhKien.TonKho;
                ketqua.GiaBan = linhKien.GiaBan;
                ketqua.GiaNhap = linhKien.GiaNhap;
                ketqua.TrangThai = linhKien.TrangThai;
                ketqua.NamBH = linhKien.NamBH;
                ketqua.HinhAnh = linhKien.HinhAnh;
               // ketqua.Seri = linhKien.Seri;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
