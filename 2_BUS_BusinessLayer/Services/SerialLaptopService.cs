using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;

namespace _2_BUS_BusinessLayer.Services
{
    public class SerialLaptopService:ISerialLaptopService
    {
        private ISerialLaptopRepository _serialLaptopRes;

        public SerialLaptopService()
        {
            _serialLaptopRes = new SerialLaptopRepository();
        }
        public List<SerialLaptop> GetSerialLaptopList()
        {
            return _serialLaptopRes.GetLstSerialLaptopFromDb();
        }
    }
}
