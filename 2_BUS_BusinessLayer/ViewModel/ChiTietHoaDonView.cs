﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.ViewModel
{
    public class ChiTietHoaDonView
    {
        public Guid Id { get; set; }
        public Guid IdHoaDon { get; set; }
        public Guid IdSanPham { get; set; }
        public string TenSanPham{ get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}