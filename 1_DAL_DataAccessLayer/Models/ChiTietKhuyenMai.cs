using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Models
{
    public class ChiTietKhuyenMai
    {
        public Guid Id { get; set; }
        public Guid IdKhuyenMai { get; set; }
        public Guid? IdLinhKien { get; set; }
        public Guid? IdLaptop { get; set; }

        public KhuyenMai KhuyenMai { get; set; }
        public SanPhamLinhKien LinhKien { get; set; }
        public Laptop Laptop{ get; set; }
    }
}
