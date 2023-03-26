using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface ISerialLinhKienRepository
    {
        public bool AddSerial(SerialLinhKien obj);
        public bool AddLstSerial(List<SerialLinhKien> lst);
        public bool UpdateStatusSerial(Guid id);
        public bool UpdateSerial(SerialLinhKien obj);
        public bool DeleteSerial(Guid Id);
        public List<SerialLinhKien> GetLstSerialLinhKienFromDb();
    }
}
