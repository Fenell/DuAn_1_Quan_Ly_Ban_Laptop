using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public class NhanvienService
    {
        private NhanVienRepository _nhanVienRepository;

        public NhanvienService()
        {
            _nhanVienRepository= new NhanVienRepository();

        }

        public string AddNhanVien(NhanVien nhanVien)
        {
            if (_nhanVienRepository.AddNhanVien(nhanVien))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public string UpdateNhanVien(Guid idNhanVien,NhanVien nhanVien)
        {
            if (_nhanVienRepository.UpdateNhanVien(idNhanVien,nhanVien))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }

        public List<NhanVien> GetAllNhanViens()
        {
            return _nhanVienRepository.GetAllNhanVien();
        }
    }
}
