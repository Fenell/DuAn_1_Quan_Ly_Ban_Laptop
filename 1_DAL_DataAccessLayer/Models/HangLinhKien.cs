using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Models
{
    public class HangLinhKien
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }

        public ICollection<SanPhamLinhKien> LinhKiens { get; set; }
        public ICollection<LoaiLinhKien> LoaiLinhKiens { get; set; }
    }
}
