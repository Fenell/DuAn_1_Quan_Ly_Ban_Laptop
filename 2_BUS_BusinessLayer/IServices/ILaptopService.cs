using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.ViewModel;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface ILaptopService
    {
        public string AddLaptop( LaptopView obj);
        public string UpdateLaptop(LaptopView obj);
        public string UpdateStatusLaptop(Guid id);
        public string DeleteLaptop(Guid id);
        public List<Laptop> GetLaptopFromDb();
        public List<LaptopView> GetAllLaptop();

    }
}
