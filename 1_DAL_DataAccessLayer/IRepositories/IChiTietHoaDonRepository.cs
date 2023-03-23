using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IChiTietHoaDonRepository
    {
        List<ChiTietHoaDon> GetChiTietHĐ();
        bool AddHĐ(ChiTietHoaDon chiTietHĐ);
        bool RemoveHĐ(ChiTietHoaDon chiTietHĐ);
        bool UpdateHĐ(ChiTietHoaDon chiTietHĐ);
    }
}
