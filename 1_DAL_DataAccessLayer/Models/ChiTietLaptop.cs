using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Models
{
    public class ChiTietLaptop
    {
        public Guid Id { get; set; }
        public string Imei { get; set; }

        public Guid IdLaptop { get; set; }
        public Laptop Laptop { get; set; }
    }
}
