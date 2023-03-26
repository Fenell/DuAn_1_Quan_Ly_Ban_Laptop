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
        public FrmLaptop()
        {
            InitializeComponent();
        }

        private void btnCpu_Click(object sender, EventArgs e)
        {
            FrmCpu newCpu = new FrmCpu();
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
            frmNhaCungCap.Show();
        }

        private void btnDongLaptop_Click(object sender, EventArgs e)
        {
            FrmDongLaptop frmDongLaptop = new FrmDongLaptop();
            frmDongLaptop.Show();
        }

        private void btnHangSanXuat_Click(object sender, EventArgs e)
        {
            FrmHangLaptop frmHangLaptop = new FrmHangLaptop();
            frmHangLaptop.Show();
        }

        private void btnRam_Click(object sender, EventArgs e)
        {
            FrmRam frmRam = new FrmRam();
            frmRam.Show();
        }

        private void btnOCung_Click(object sender, EventArgs e)
        {
            FrmOCung frmOCung = new FrmOCung();
            frmOCung.Show();
        }

        private void btnManHinh_Click(object sender, EventArgs e)
        {
            FrmManHinh frmManHinh = new FrmManHinh();
            frmManHinh.Show();
        }

        private void btnMauSac_Click(object sender, EventArgs e)
        {
            FrmMauSac frmMauSac = new FrmMauSac();
            //frmMauSac.Show();
            // Lấy vị trí của nút thêm nhanh
            Point buttonPosition = btnMauSac.PointToScreen(Point.Empty);

            // Tính toán vị trí của form con
            int x = buttonPosition.X + btnMauSac.Width;
            int y = buttonPosition.Y;

            // Hiển thị form con
            frmMauSac.Location = new Point(x, y);
            frmMauSac.Show();
        }
    }
}
