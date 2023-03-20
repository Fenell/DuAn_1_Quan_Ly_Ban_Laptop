using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Models
{
    public class ChiTietLinhKien
    {
        public Guid Id { get; set; }
        public string Seri { get; set; }

        public Guid IdLinhKien { get; set; }
        public LinhKien LinhKien { get; set; }
    }
}
