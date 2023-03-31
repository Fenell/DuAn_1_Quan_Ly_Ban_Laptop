using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public class NhanVienServies : INhanVienServices
    {
        INhanVienRepository _DALNhanVien;
        List<NhanVien> _lstNhanVien;
        public NhanVienServies()
        {
            _DALNhanVien = new NhanVienRepository();
            _lstNhanVien = new List<NhanVien>();
        }
        public bool Add(NhanVien nv)
        {
            throw new NotImplementedException();
        }

        public List<NhanVien> GetAll()
        {
            _lstNhanVien = _DALNhanVien.GetAllNhanVien();
            return _lstNhanVien;
        }

        public bool Sua(NhanVien nv)
        {
            var x = _DALNhanVien.GetAllNhanVien().FirstOrDefault(p => p.Id == nv.Id);
            x.Id = nv.Id;
            x.MatKhau = nv.MatKhau;
            return true;
        }

        public bool Xoa(NhanVien nv)
        {
            throw new NotImplementedException();
        }
    }
}
