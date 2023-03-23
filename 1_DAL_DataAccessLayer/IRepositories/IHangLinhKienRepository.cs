using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IHangLinhKienRepository
    {
        bool AddHangLinhKien(HangLinhKien hangLinhKien);
        bool UpdateHangLinhKien(HangLinhKien hangLinhKien);
        bool DeleteHangLinhKien(Guid idHangLinhKien);
        HangLinhKien GetHangLinhKienById(Guid idHangLinhKien);
        List<HangLinhKien> GetAllHangLinhKien();
    }
}
