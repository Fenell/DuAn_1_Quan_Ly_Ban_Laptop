using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Models
{
    public class LoaiLinhKien
    {
        public Guid Id { get; set; }
        public Guid IdHangLinhKien { get; set; }
        public string Ten { get; set; }
        public string Ma { get; set; }

        public HangLinhKien HangLinhKien { get; set; }
        public ICollection<SanPhamLinhKien> LinhKiens { get; set; }
    }
}
