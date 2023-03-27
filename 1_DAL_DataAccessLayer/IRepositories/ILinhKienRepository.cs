using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface ILinhKienRepository
    {
        bool AddLinhKien(SanPhamLinhKien linhKien);
        bool UpdateLinhKien(SanPhamLinhKien linhKien);
        SanPhamLinhKien GetLinhKienById(Guid idLinhKien);
        List<SanPhamLinhKien> GetAllLinhKien();
    }
}
