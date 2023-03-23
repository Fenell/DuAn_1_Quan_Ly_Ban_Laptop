using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Repositories
{
    public class ChiTietKhuyenMaiRepository : IChiTietKhuyenMaiRepository
    {
        QlBanLaptopContext _lapTopContext;
        public ChiTietKhuyenMaiRepository()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public List<ChiTietKhuyenMai> GetAllChiTietKhuyenMai()
        {
            return _lapTopContext.ChiTietKhuyenMais.ToList();
        }
    }
}
