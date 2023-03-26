using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Models
{
    public class SerialLinhKien
    {
        public Guid Id { get; set; }
        public Guid IdSanPhamLinhKien{ get; set; }
        public string Serial { get; set; }
        public bool TrangThai{ get; set; }

        public SanPhamLinhKien SanPhamLinhKien { get; set; }
    }
}
