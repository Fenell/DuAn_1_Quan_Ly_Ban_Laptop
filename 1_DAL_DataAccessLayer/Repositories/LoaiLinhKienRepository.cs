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
    public class LoaiLinhKienRepository : ILoaiLinhKienRepository
    {
        QlBanLaptopContext _lapTopContext;
        public LoaiLinhKienRepository()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddLoaiLinhKien(LoaiLinhKien loaiLinhKien)
        {
            try
            {
                if (loaiLinhKien != null)
                {
                    loaiLinhKien.Id = Guid.NewGuid();
                    _lapTopContext.Add(loaiLinhKien);
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

        public bool DeleteLoailinhKien(Guid idLoaiLinhKien)
        {
            var ketqua = _lapTopContext.LoaiLinhKiens.Find(idLoaiLinhKien);
            if (ketqua != null)
            {
                _lapTopContext.Remove(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<LoaiLinhKien> GetAllLoailinhKien()
        {
            return _lapTopContext.LoaiLinhKiens.ToList();
        }

        public LoaiLinhKien GetLoailinhKienById(Guid idLoaiLinhKien)
        {
            var ketqua = _lapTopContext.LoaiLinhKiens.Find(idLoaiLinhKien);
            return ketqua;
        }

        public bool UpdateLoaiLinhKien(LoaiLinhKien loaiLinhKien)
        {
            var ketqua = _lapTopContext.LoaiLinhKiens.FirstOrDefault(c => c.Id == loaiLinhKien.Id);
            if (ketqua != null)
            {
                ketqua.Ten = loaiLinhKien.Ten;
                ketqua.Ma = loaiLinhKien.Ma;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
