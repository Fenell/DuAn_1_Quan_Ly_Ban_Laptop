using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.ViewModel;

namespace _2_BUS_BusinessLayer.Services
{
    public class LaptopService: ILaptopService

    {
        private IHangLapTopRepositories _hangLapTopRepositories;
        private IDongLapTopRepositories _dongLapTopRepositories;
        private ICpuRepositories _cpuRepositories;
        private IVgaRepositories _vgaRepositories;
        private IRamRepository _ramRepository;
        private IOCungReposittories _oCungReposittories;
        private IManHinhRepositories _manHinhRepositories;
        private IMauSacRepository _mauSacRepository;
        private ISerialLaptopRepository _serialLaptopRepository;
        private INhaCungCapRepository _nhaCungCapRepository;
        private ISanPhamLapTopRepository _sanPhamLapTopRepository;

        public LaptopService()
        {
            _hangLapTopRepositories = new HangLaptopRepositories();
            _dongLapTopRepositories = new DongLapTopReposittoies();
            _cpuRepositories = new CpuRepositories();
            _vgaRepositories = new VGARepositories();
            _ramRepository = new Ramrepository();
            _oCungReposittories = new OCungRepositories();
            _manHinhRepositories = new ManHinhRepositories();
            _mauSacRepository = new MauSacRepositories();
            _serialLaptopRepository = new SerialLaptopRepository();
            _nhaCungCapRepository = new NhaCungCapRepository();
            _sanPhamLapTopRepository = new SanPhamLapTopRepository();
        }
        public string AddLaptop(SanPhamLaptopView obj)
        {
            Laptop laptop = new Laptop()
            {
                Id = obj.Id,
                IdHangLaptop = obj.IdHangLaptop,
                IdDongLaptop = obj.IdDongLaptop,
                IdCpu = obj.IdCpu,
                IdRam = obj.IdRam,
                IdVga = obj.IdVga,
                IdOCung = obj.IdOCung,
                IdMauSac = obj.IdMauSac,
                IdManHinh = obj.IdManHinh,

                Mota = obj.Mota,
                TrongLuong = obj.TrongLuong,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                NamBh = obj.NamBh,
                TrangThai = obj.TrangThai,
                HinhAnh = obj.Anh
            };
            if (_sanPhamLapTopRepository.AddLapTop(laptop))
            {
                return "Thêm thành công";
            }

            return "Thêm thất bại";
        }

        public string UpdateLaptop(SanPhamLaptopView obj)
        {
            var laptop = _sanPhamLapTopRepository.GetAllLapTop().FirstOrDefault(c => c.Id == obj.Id);
            laptop.IdHangLaptop = obj.IdHangLaptop;
            laptop.IdDongLaptop = obj.IdDongLaptop;
            laptop.IdCpu = obj.IdCpu;
            laptop.IdVga = obj.IdVga;
            laptop.IdRam = obj.IdRam;
            laptop.IdOCung = obj.IdOCung;
            laptop.IdMauSac = obj.IdMauSac;
            laptop.IdManHinh = obj.IdManHinh;
            laptop.IdNhaCungCap = obj.IdNhaCungCap;

            laptop.Mota = obj.Mota;
            laptop.TrangThai = obj.TrangThai;
            laptop.TrongLuong = obj.TrongLuong;
            laptop.GiaBan = obj.GiaBan;
            laptop.GiaNhap = obj.GiaNhap;
            laptop.NamBh = obj.NamBh;
            laptop.HinhAnh = obj.Anh;

            if (_sanPhamLapTopRepository.UpdateLapTop(laptop))
            {
                return "Sửa thành công";
            }

            return "Sửa thất bại";
        }

        public string DeleteLaptop(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<SanPhamLaptopView> GetAllLaptop()
        {
            var lst = (from a in _sanPhamLapTopRepository.GetAllLapTop()
                join b in _hangLapTopRepositories.GetAllHangLaptops() on a.IdHangLaptop equals b.Id
                join c in _dongLapTopRepositories.GetAllDongLaptop() on a.IdDongLaptop equals c.Id
                join d in _cpuRepositories.GetAllCpu() on a.IdCpu equals d.Id
                join e in _vgaRepositories.GetAllVga() on a.IdVga equals e.Id
                join f in _ramRepository.GetAllRam() on a.IdRam equals f.Id
                join g in _oCungReposittories.GetAllOCungs() on a.IdOCung equals g.Id
                join h in _mauSacRepository.GetAllMauSac() on a.IdMauSac equals h.Id
                join i in _manHinhRepositories.GetAllManHinh() on a.IdManHinh equals i.Id
                join k in _nhaCungCapRepository.GetAllNhaCungCap() on a.IdNhaCungCap equals k.Id
                select new SanPhamLaptopView()
                {
                    Id = a.Id,
                    IdHangLaptop = a.IdHangLaptop,
                    IdDongLaptop = a.IdDongLaptop,
                    IdCpu = a.IdCpu,
                    IdVga = a.IdVga,
                    IdRam = a.IdRam,
                    IdOCung = a.IdOCung,
                    IdMauSac = a.IdMauSac,
                    IdManHinh = a.IdManHinh,
                    IdNhaCungCap = a.IdNhaCungCap,

                    HangLaptop = b.Ten,
                    DongLaptop = c.Ten,
                    Ten = a.Ten,
                    Cpu = d.Ten,
                    Vga = e.Ten,
                    Ram = f.Ten,
                    OCung = g.Ten,
                    MauSac = h.Ma,
                    ManHinh = i.Ma,
                    NhaCungCap = k.Ten,
                    Mota = a.Mota,
                    TrongLuong = a.TrongLuong,
                    GiaBan = a.GiaBan,
                    GiaNhap = a.GiaNhap,
                    NamBh = a.NamBh,
                    TrangThai = a.TrangThai,
                    Anh = a.HinhAnh
                }).ToList();
            return lst;
        }

        public string UpdateStatusLaptop(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
