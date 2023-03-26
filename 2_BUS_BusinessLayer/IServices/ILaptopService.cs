using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.ViewModel;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface ILaptopService
    {
        public string AddLaptop( SanPhamLaptopView obj);
        public string UpdateLaptop(SanPhamLaptopView obj);
        public string UpdateStatusLaptop(Guid id);
        public string DeleteLaptop(Guid id);
        public List<SanPhamLaptopView> GetAllLaptop();

    }
}
