using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IHoaDonChiTietServices
    {
        bool Add(ChiTietHoaDon CtHoaDon);
        bool Sua(ChiTietHoaDon CtHoaDon);
        List<ChiTietHoaDon> GetAll();
    }
}
