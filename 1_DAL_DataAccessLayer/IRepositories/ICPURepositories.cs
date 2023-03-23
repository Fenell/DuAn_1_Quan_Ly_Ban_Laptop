using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface ICpuRepositories
    {
        bool AddCpu(Cpu cPu);
        bool Update(Cpu cPu);
        bool Delete(Guid idCpu);
        Cpu GetCpuById(Guid idCpu);
        List<Cpu> GetAllCpu();
    }
}
