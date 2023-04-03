using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IHoaDonServices
    {
        bool Add(HoaDon hoaDon);
        bool Sua(HoaDon hoaDon);
        List<hoaDonView> GetAll(); 
        


    }
}
