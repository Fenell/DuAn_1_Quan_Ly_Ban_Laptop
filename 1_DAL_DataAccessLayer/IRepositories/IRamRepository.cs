using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IRamRepository
    {
        bool AddRam(Ram ram);
        bool Update(Ram ram);
        bool Delete(Guid idRam);
        Ram GetRamById(Guid idRam);
        List<Ram> GetAllRam();
    }
}
