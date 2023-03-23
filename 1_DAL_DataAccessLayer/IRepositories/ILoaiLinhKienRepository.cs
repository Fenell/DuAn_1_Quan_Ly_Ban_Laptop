using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface ILoaiLinhKienRepository
    {
        bool AddLoaiLinhKien(LoaiLinhKien loaiLinhKien);
        bool UpdateLoaiLinhKien(LoaiLinhKien loaiLinhKien);
        bool DeleteLoailinhKien(Guid idLoaiLinhKien);
        LoaiLinhKien GetLoailinhKienById(Guid idLoaiLinhKien);
        List<LoaiLinhKien> GetAllLoailinhKien();
    }
}
