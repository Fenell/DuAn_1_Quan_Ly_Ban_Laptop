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
    public class HangLinhKienRepository : IHangLinhKienRepository
    {
        QlBanLaptopContext _lapTopContext;
        public HangLinhKienRepository()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddHangLinhKien(HangLinhKien hangLinhKien)
        {
            try
            {
                if (hangLinhKien != null)
                {
                    hangLinhKien.Id = Guid.NewGuid();
                    _lapTopContext.Add(hangLinhKien);
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

        public bool DeleteHangLinhKien(Guid idHangLinhKien)
        {
            var ketqua = _lapTopContext.HangLinhKiens.Find(idHangLinhKien);
            if (ketqua != null)
            {
                _lapTopContext.Remove(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<HangLinhKien> GetAllHangLinhKien()
        {
            return _lapTopContext.HangLinhKiens.ToList();
        }

        public HangLinhKien GetHangLinhKienById(Guid idHangLinhKien)
        {
            var ketqua = _lapTopContext.HangLinhKiens.Find(idHangLinhKien);
            return ketqua;
        }

        public bool UpdateHangLinhKien(HangLinhKien hangLinhKien)
        {
            var ketqua = _lapTopContext.HangLinhKiens.FirstOrDefault(c => c.Id == hangLinhKien.Id);
            if (ketqua != null)
            {
                ketqua.Ma = hangLinhKien.Ma;
                ketqua.Ten = hangLinhKien.Ten;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
