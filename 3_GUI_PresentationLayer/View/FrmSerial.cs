using _1_DAL_DataAccessLayer.IRepositories;
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
    public partial class FrmSerial : Form
    {
        ISerialLaptopService _serialLaptopService;
        Guid _idLaptop;
        public FrmSerial(List<SerialLaptop> _lstserialLaptops)
        {
            InitializeComponent();
            _serialLaptopService = new SerialLaptopService();
            txtSerial.Enabled = false;
            btnThem.Enabled = false;
            LoadDgv();
        }
        private void LoadDgv()
        {
            dgvLaptop.ColumnCount = 2;
            dgvLaptop.Columns[0].Visible = false;
            dgvLaptop.Columns[1].Name = "Tên";
            dgvLaptop.Rows.Clear();
            foreach (var x in _serialLaptopService.GetAllLaptopView())
            {
                dgvLaptop.Rows.Add(x.Id, $"{x.HangLaptop} {x.DongLaptop} {x.Ten}");
            }
        }
        private bool checkNhap()
        {
            if (txtSerial.Texts == "") return true;
            return false;
        }
        private bool Validate()
        {
            string serial = txtSerial.Texts;

            if (serial.Length == 15) return true;
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkNhap())
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            if (!Validate())
            {
                MessageBox.Show("Phải nhập đủ 15 ký tự");
                return;
            }
            SerialLaptop serialLaptop = new SerialLaptop()
            {
                IdLaptop = _idLaptop,
                Serial = txtSerial.Texts,
                TrangThai = true,
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_serialLaptopService.AddSerialLaptop(serialLaptop));
            }
        }

        private void dgvLaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _serialLaptopService.GetAllLaptopView().Count) return;
            _idLaptop = Guid.Parse(dgvLaptop.Rows[rowindex].Cells[0].Value.ToString());
            btnThem.Enabled = true;
            txtSerial.Enabled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvLaptop.ColumnCount = 2;
            dgvLaptop.Columns[0].Visible = false;
            dgvLaptop.Columns[1].Name = "Tên";
            dgvLaptop.Rows.Clear();
            foreach (var x in _serialLaptopService.GetAllLaptopView().Where(c => String.Concat(c.HangLaptop, c.DongLaptop, c.Ten).ToLower().Contains(txtTimKiem.Text.ToLower())))
            {
                dgvLaptop.Rows.Add(x.Id, $"{x.HangLaptop}{x.DongLaptop}{x.Ten}");
            }
        }
    }
}
