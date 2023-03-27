using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.ViewModel
{
    public class HoaDonView
    {
        public Guid Id { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IdNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string TenKhachHang { get; set; }
        public string Ma { get; set; }
        public string HTThanhToan { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public int TrangThai { get; set; }
        public string DcNhanHang { get; set; }
        public string GhiChu { get; set; }
        public decimal TongTien{ get; set; }
    }
}
