using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface INhaCungCapRepository
    {
        bool AddNhaCungCap(NhaCungCap nhaCungCap);
        bool Update(NhaCungCap nhaCungCap);
        bool Delete(Guid idNhaCungCap);
        NhaCungCap GetNhaCungCapById(Guid idNhaCungCap);
        List<NhaCungCap> GetAllNhaCungCap();
    }
}
