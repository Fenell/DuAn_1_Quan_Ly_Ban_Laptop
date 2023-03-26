using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface ILaptopService
    {
        string AddLapTop(SanPhamLaptop lapTop);
        string UpdateLapTop(SanPhamLaptop lapTop);
        SanPhamLaptop GetLapTopById(Guid idLapTop);
        List<SanPhamLaptop> GetAllLapTop();
    }
}
