﻿using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface INhanVienRepository
    {
        bool AddNhanVien(NhanVien nhanVien);
        bool UpdateNhanVien(Guid idNhanVien , NhanVien nhanVien);
        NhanVien GetNhanVienById(Guid idNhanVien);
        List<NhanVien> GetAllNhanVien();
    }
}
