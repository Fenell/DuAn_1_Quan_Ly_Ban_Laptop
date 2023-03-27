using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
<<<<<<<< HEAD:1_DAL_DataAccessLayer/IRepositories/ISanPhamLaptopRepository.cs
    public interface ISanPhamLaptopRepository
========
    public interface ISanPhamLapTopRepository
>>>>>>>> Dat:1_DAL_DataAccessLayer/IRepositories/ISanPhamLapTopRepository.cs
    {
        bool AddLapTop(SanPhamLaptop lapTop);
        bool UpdateLapTop(SanPhamLaptop lapTop);
        bool UpdateStatusLaptop(Guid id);
        SanPhamLaptop GetLapTopById(Guid idLapTop);
        List<SanPhamLaptop> GetAllLapTop();
    }
}
