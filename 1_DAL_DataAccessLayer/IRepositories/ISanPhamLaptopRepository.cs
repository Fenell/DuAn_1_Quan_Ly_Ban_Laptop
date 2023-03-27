using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface ISanPhamLapTopRepository
    {
        bool AddLapTop(SanPhamLaptop lapTop);
        bool UpdateLapTop(SanPhamLaptop lapTop);
        bool UpdateStatusLaptop(Guid id);
        SanPhamLaptop GetLapTopById(Guid idLapTop);
        List<SanPhamLaptop> GetAllLapTop();
    }
}
