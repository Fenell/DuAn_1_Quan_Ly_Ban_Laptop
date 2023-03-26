using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface ILapTopRepository
    {
        bool AddLapTop(SanPhamLaptop lapTop);
        bool UpdateLapTop(SanPhamLaptop lapTop);
        SanPhamLaptop GetLapTopById(Guid idLapTop);
        List<SanPhamLaptop> GetAllLapTop();
    }
}
