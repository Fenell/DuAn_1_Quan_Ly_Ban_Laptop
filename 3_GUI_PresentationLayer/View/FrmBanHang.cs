using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmBanHang : Form
    {
        private ILaptopService _laptopService;
        private ISerialLaptopService _serialLaptopService;
        public FrmBanHang()
        {
            InitializeComponent();
            _laptopService = new LaptopService();
            _serialLaptopService = new SerialLaptopService();
            LoadData();
        }

        private void LoadData()
        {
            dgvSanPham.ColumnCount = 3;
            dgvSanPham.Columns[0].Name = "Ten";
            dgvSanPham.Columns[1].Name = "Gia";
            dgvSanPham.Columns[2].Name = "So luong";

            DataGridViewComboBoxColumn cbbSerial = new DataGridViewComboBoxColumn();
            cbbSerial.HeaderText = "Serial";




            dgvSanPham.Rows.Clear();
            foreach (var a in _laptopService.GetAllLaptop())
            {
                dgvSanPham.Rows.Add(a.Ten, a.GiaBan, a.SoLuongTon);
                var lstIdLaptop = _laptopService.GetLaptopFromDb().Where(c => c.Ten == a.Ten);
                //foreach (var x in lstIdLaptop)
                //{
                //    var serial = _serialLaptopService.GetSerialLaptopList().FirstOrDefault(c => c.IdLaptop == x.Id);
                //}

                // dgvSanPham.Columns.Add(cbbSerial);

            }
        }
    }
}
