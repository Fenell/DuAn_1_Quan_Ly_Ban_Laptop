using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IChiTietLapTopRepository
    {
        List<ChiTietLaptop> GetChiTietLapTop();
        bool AddLT(ChiTietLaptop chiTietLaptop);
        bool RemoveLT(ChiTietLaptop chiTietLaptop);
        bool UpdateLT(ChiTietLaptop chiTietLaptop);
    }
}
