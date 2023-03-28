using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmLaptop : Form
    {
        ICpuServices _cpuServices;
        IVgaServices _vgaServices;
        IMauSacServices _mauSacServices;
        IOCungServices _oCungServices;
        IRamServices _ramServices;
        IManHinhServices _manHinhServices;
        INhaCungCapServices _nhaCungCapServices;
        IHangLaptopServices _hangLaptopServices;
        IDongLaptopServices _dongLaptopServices;
        List<Cpu> _lstCpu;
        public FrmLaptop()
        {
            InitializeComponent();
            _cpuServices = new CpuServices();
            _vgaServices = new VgaServices();
            _mauSacServices = new MauSacServices();
            _oCungServices = new OCungServices();
            _ramServices = new RamServices();
            _manHinhServices = new ManHinhServices();
            _nhaCungCapServices = new NhaCungCapServices();
            _hangLaptopServices = new HangLaptopServices();
            _dongLaptopServices = new DongLaptopServices();
            _lstCpu = new List<Cpu>();
            Loadcbb();
        }

        private void btnCpu_Click(object sender, EventArgs e)
        {
            FrmCpu newCpu = new FrmCpu(_lstCpu);
            //newCpu.Location = new Point(915, 67);
            newCpu.ShowDialog();
        }

        private void btnVga_Click(object sender, EventArgs e)
        {
            FrmVga frmVga = new FrmVga();
            frmVga.ShowDialog();

        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap frmNhaCungCap = new FrmNhaCungCap();
            frmNhaCungCap.ShowDialog();
        }

        private void btnDongLaptop_Click(object sender, EventArgs e)
        {
            FrmDongLaptop frmDongLaptop = new FrmDongLaptop();
            frmDongLaptop.ShowDialog();
        }

        private void btnHangSanXuat_Click(object sender, EventArgs e)
        {
            FrmHangLaptop frmHangLaptop = new FrmHangLaptop();
            frmHangLaptop.ShowDialog();
        }

        private void btnRam_Click(object sender, EventArgs e)
        {
            FrmRam frmRam = new FrmRam();
            frmRam.ShowDialog();
        }

        private void btnOCung_Click(object sender, EventArgs e)
        {
            FrmOCung frmOCung = new FrmOCung();
            frmOCung.ShowDialog();
        }

        private void btnManHinh_Click(object sender, EventArgs e)
        {
            FrmManHinh frmManHinh = new FrmManHinh();
            frmManHinh.ShowDialog();
        }

        private void btnMauSac_Click(object sender, EventArgs e)
        {
            FrmMauSac frmMauSac = new FrmMauSac();
            //frmMauSac.Show();
            // Lấy vị trí của nút thêm nhanh
            //Point buttonPosition = btnMauSac.PointToScreen(Point.Empty);

            //// Tính toán vị trí của form con
            //int x = buttonPosition.X + btnMauSac.Width;
            //int y = buttonPosition.Y;

            //// Hiển thị form con
            //frmMauSac.Location = new Point(x, y);
            frmMauSac.ShowDialog();
        }
        private void Loadcbb()
        {
            // CPU
            cbbCpu.DisplayMember = "Ten";
            cbbCpu.ValueMember = "Id";
            _lstCpu = _cpuServices.GetAllCpu();
            cbbCpu.DataSource = _lstCpu;
            // VGA
            cbbVga.DisplayMember = "Ten";
            cbbVga.ValueMember = "Id";
            cbbVga.DataSource = _vgaServices.GetAllVga();
            //Màu Sắc
            cbbMauSac.DisplayMember = "Ten";
            cbbMauSac.ValueMember = "Id";
            cbbMauSac.DataSource = _mauSacServices.GetAllMauSac();
            //Ổ cứng
            cbbOCung.DisplayMember = "Ten";
            cbbOCung.ValueMember = "Id";
            cbbOCung.DataSource = _oCungServices.GetAllOCungs();
            //Ram
            cbbRam.DisplayMember = "Ten";
            cbbRam.ValueMember = "Id";
            cbbRam.DataSource = _ramServices.GetAllRam();
            //Màn hình
            cbbManHinh.DisplayMember = "Ten";
            cbbManHinh.ValueMember = "Id";
            cbbManHinh.DataSource = _manHinhServices.GetAllManHinh();
            //Nha cung cấp
            cbbNhaCungCap.DisplayMember = "Ten";
            cbbNhaCungCap.ValueMember = "Id";
            cbbNhaCungCap.DataSource = _nhaCungCapServices.GetAllNhaCungCap();
            //Hãng Laptop
            cbbHangSanXuat.DisplayMember = "Ten";
            cbbHangSanXuat.ValueMember = "Id";
            cbbHangSanXuat.DataSource = _hangLaptopServices.GetAllHangLaptops();
            //Dòng Laptop
            cbbDong.DisplayMember = "Ten";
            cbbDong.ValueMember = "Id";
            cbbDong.DataSource = _dongLaptopServices.GetAllDongLaptop();
        }
    }
}
