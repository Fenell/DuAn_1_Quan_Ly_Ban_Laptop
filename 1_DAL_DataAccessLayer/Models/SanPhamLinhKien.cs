using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Models
{
    public class SanPhamLinhKien
    {
        public Guid Id { get; set; }
        public Guid IdLoaiLinhKien { get; set; }
        public Guid IdHangLinhKien { get; set; }
        public Guid IdNhaCungCap { get; set; }
        public string Ten { get; set; }
        public string? MoTaChiTiet { get; set; }
        public int TonKho { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public bool? TrangThai { get; set; }
        public int NamBH { get; set; }
        public byte[]? HinhAnh { get; set; }

        public HangLinhKien HangLinhKien { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public LoaiLinhKien LoaiLinhKien { get; set; }
        public ICollection<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public ICollection<SerialLinhKien> SerialLinhKiens { get; set; }
    }
}
