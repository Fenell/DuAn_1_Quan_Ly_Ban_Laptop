using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface ISerialLaptopService
    {
        public List<SerialLaptop> GetSerialLaptopList();
    }
}
