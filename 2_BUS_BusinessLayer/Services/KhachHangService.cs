using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.ViewModel;

namespace _2_BUS_BusinessLayer.Services
{
    public class KhachHangService:IKhachHangService
    {
        private IKhachHangRepository _khachHangRepository;

        public KhachHangService()
        {
            _khachHangRepository = new KhachHangRepository();
        }
        public List<KhachHangView> GetLstKhachHang()
        {
            var lst = (from a in _khachHangRepository.GetAllKhachHang()
                select new KhachHangView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Hoten = a.Hoten,
                    DiaChi = a.DiaChi,
                    GioiTinh = a.GioiTinh,
                    SoDienThoai = a.SoDienThoai,
                }).ToList();
            return lst;
        }
    }
}
