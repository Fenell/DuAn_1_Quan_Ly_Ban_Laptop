using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _3_GUI_PresentationLayer.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmNhanVien : Form
    {
        private NhanVien _nhanVien;
        private NhanvienService _nhanvienService;
        Guid _idNhanvien;

        public FrmNhanVien()
        {
            InitializeComponent();
            _nhanvienService= new NhanvienService();
            
            loaddata();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void FrmNhanVien_Load_1(object sender, EventArgs e)
        {

        }

        public void loaddata()
        {
            dgv.Rows.Clear();
            foreach (var item in _nhanvienService.GetAllNhanViens())
            {
                if (item.TrangThai == true)
                {
                    dgv.Rows.Add(item.Ma, item.Hoten, item.SoDienThoai, item.Email, item.CCCD, item.GioiTinh == false ? "Nam" : "Nữ", item.ChucVu, item.DiaChi, item.MatKhau, item.Id);
                }
            }
            rbtDangLam.Checked= true;

        }



        private void rbtDangLam_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            if (rbtDangLam.Checked == true)
            {
                foreach (var item in _nhanvienService.GetAllNhanViens())
                {
                    if (item.TrangThai == true)
                    {
                        dgv.Rows.Add(item.Ma, item.Hoten, item.SoDienThoai, item.Email, item.CCCD, item.GioiTinh == false ? "Nam" : "Nữ", item.ChucVu, item.DiaChi, item.MatKhau, item.Id);
                    }
                }
            }
        }

        private void rbtDaNghiViec_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            if (rbtDaNghiViec.Checked == true)
            {
                foreach (var item in _nhanvienService.GetAllNhanViens())
                {
                    if (item.TrangThai == false)
                    {
                        dgv.Rows.Add(item.Ma, item.Hoten, item.SoDienThoai, item.Email, item.CCCD, item.GioiTinh == false ? "Nam" : "Nữ", item.ChucVu, item.DiaChi, item.MatKhau, item.Id);
                    }
                }
            }
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            
            _nhanVien = new NhanVien();
            if (txtMaNhanVien.Texts == null || txtHoTen.Texts == null || txtSoDienThoai.Texts == null || txtEmail.Texts == null || txtSoCanCuoc.Texts == null 
                || txtMatKhau.Texts == null || rbtNam.Checked == false && rbtNu.Checked == false || rbtNhanVien.Checked == false && rbtQuanLy.Checked == false || txtDiaChi.Texts == null)
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ các trường dữ liệu!");
                return;
            }

            if (!Validation.checkMaSV(txtMaNhanVien.Texts))
            {
                MessageBox.Show("Mã nhân viên phải theo đúng định dạng! VD: ph1 ", "Thông báo");
                return;
            }
            if (!Validation.checkSDT(txtSoDienThoai.Texts))
            {
                MessageBox.Show("Mời bạn kiểm tra lại số điện thoại", "Thông báo");
                return;
            }
            if (!Validation.checkEmail(txtEmail.Texts))
            {
                MessageBox.Show("Eamil phải theo đúng định dang! VD: long@gmail.com ", "Thông báo");
                return;
            }
            if (!Validation.checkCCCD(txtSoCanCuoc.Texts))
            {
                MessageBox.Show("Mời bạn kiểm tra lại số căn cước", "Thông báo");
                return;
            }

            _nhanVien.Ma = txtMaNhanVien.Texts;
            _nhanVien.Hoten = txtHoTen.Texts;
            _nhanVien.SoDienThoai = txtSoDienThoai.Texts;
            _nhanVien.Email = txtEmail.Texts;
            _nhanVien.CCCD = txtSoCanCuoc.Texts;
            _nhanVien.MatKhau = txtMatKhau.Texts;
            _nhanVien.DiaChi = txtDiaChi.Texts;
            _nhanVien.TrangThai = true;
            _nhanVien.HinhAnh = Extension.ImageToArrBytes(ptbAnh.Image);

            if (rbtNam.Checked == true)
            {
                _nhanVien.GioiTinh = false;
            }
            else if(rbtNu.Checked == true)
            {
                _nhanVien.GioiTinh = true;
            }

            if (rbtNhanVien.Checked == true)
            {
                _nhanVien.ChucVu = "Nhân viên";
            }
            else if(rbtQuanLy.Checked == true)
            {
                _nhanVien.ChucVu = "Quản lý";
            }
            var nn = _nhanvienService.GetAllNhanViens().Any(c => c.Ma == txtMaNhanVien.Texts);
            if (nn == true)
            {
                MessageBox.Show("Nhân viên đã tồn tại!");
                return;
            }

            
            if (MessageBox.Show("Có muốn thêm hay ko ?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _nhanvienService.AddNhanVien(_nhanVien);
                loaddata();
            }
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            var nv = _nhanvienService.GetAllNhanViens().FirstOrDefault(c => c.Id == _idNhanvien);
            if (txtMaNhanVien.Texts == null || txtHoTen.Texts == null || txtSoDienThoai.Texts == null || txtEmail.Texts == null || txtSoCanCuoc.Texts == null
                || txtMatKhau.Texts == null || rbtNam.Checked == false && rbtNu.Checked == false || rbtNhanVien.Checked == false && rbtQuanLy.Checked == false || txtDiaChi.Texts == null)
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ các trường dữ liệu!");
                return;
            }

            if (!Validation.checkMaSV(txtMaNhanVien.Texts))
            {
                MessageBox.Show("Mã nhân viên phải theo đúng định dạng! VD: ph1 ", "Thông báo");
                return;
            }
            if (!Validation.checkSDT(txtSoDienThoai.Texts))
            {
                MessageBox.Show("Mời bạn kiểm tra lại số điện thoại", "Thông báo");
                return;
            }
            if (!Validation.checkEmail(txtEmail.Texts))
            {
                MessageBox.Show("Eamil phải theo đúng định dang! VD: long@gmail.com ", "Thông báo");
                return;
            }
            if (!Validation.checkCCCD(txtSoCanCuoc.Texts))
            {
                MessageBox.Show("Mời bạn kiểm tra lại số căn cước", "Thông báo");
                return;
            }

            nv.Ma = txtMaNhanVien.Texts;
            nv.Hoten = txtHoTen.Texts;
            nv.SoDienThoai = txtSoDienThoai.Texts;
            nv.Email = txtEmail.Texts;
            nv.CCCD = txtSoCanCuoc.Texts;
            nv.MatKhau = txtMatKhau.Texts;
            nv.DiaChi = txtDiaChi.Texts;
            nv.HinhAnh = Extension.ImageToArrBytes(ptbAnh.Image);

            if (rbtNam.Checked == true)
            {
                nv.GioiTinh = false;
            }
            else if (rbtNu.Checked == true)
            {
                nv.GioiTinh = true;
            }

            if (rbtNhanVien.Checked == true )
            {
                nv.ChucVu = "Nhân viên";
            }
            else if(rbtQuanLy.Checked == true)
            {
                nv.ChucVu = "Quản lý";
            }
            

            if (MessageBox.Show("Có muốn sửa hay ko ?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _nhanvienService.UpdateNhanVien(_idNhanvien,nv);
                MessageBox.Show("Sửa thành công");
                loaddata();
            }
        }

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            var nv = _nhanvienService.GetAllNhanViens().FirstOrDefault(c=>c.Id == _idNhanvien);
            if (MessageBox.Show("Có xóa hay ko", "hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nv.TrangThai = false;
                rbtDangLam.Checked = false;
                rbtDaNghiViec.Checked = true;
                MessageBox.Show("Xóa thành công");
                loaddata();
            }
        }

        private void iconButtonLoad_Click(object sender, EventArgs e)
        {
            txtHoTen.Texts = "";
            txtMaNhanVien.Texts = "";
            txtEmail.Texts = "";
            txtDiaChi.Texts = "";
            txtSoCanCuoc.Texts = "";
            txtSoDienThoai.Texts = "";
            rbtDaNghiViec.Checked = false;
            rbtDangLam.Checked=false;
            rbtNam.Checked = false;
            rbtNu.Checked = false;
            rbtNhanVien.Checked = false;
            rbtQuanLy.Checked = false;
            loaddata();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            txtMaNhanVien.Texts = dgv.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Texts = dgv.Rows[i].Cells[1].Value.ToString();
            txtSoDienThoai.Texts = dgv.Rows[i].Cells[2].Value.ToString();
            txtEmail.Texts = dgv.Rows[i].Cells[3].Value.ToString();
            txtSoCanCuoc.Texts = dgv.Rows[i].Cells[4].Value.ToString();

            if (dgv.Rows[i].Cells[5].Value.ToString() == "Nam")
            {
                rbtNam.Checked= true;
                rbtNu.Checked = false;
            }
            else if (dgv.Rows[i].Cells[5].Value.ToString() == "Nữ")
            {
                rbtNam.Checked = false;
                rbtNu.Checked = true;
            }

            if (dgv.Rows[i].Cells[6].Value.ToString() == "Nhân viên")
            {
                rbtNhanVien.Checked = true;
                rbtQuanLy.Checked = false;
            }
            else if (dgv.Rows[i].Cells[6].Value.ToString() == "Quản lý")
            {
                rbtNhanVien.Checked = false;
                rbtQuanLy.Checked = true;
                
            }
            txtDiaChi.Texts = dgv.Rows[i].Cells[7].Value.ToString();
            txtMatKhau.Texts = dgv.Rows[i].Cells[8].Value.ToString();
            _idNhanvien = Guid.Parse(dgv.Rows[i].Cells[9].Value.ToString());
            var la = _nhanvienService.GetAllNhanViens().FirstOrDefault(c=>c.Id == _idNhanvien);
            var img = Extension.ArrBytesToImage(la.HinhAnh);
            if (img != null)
            {
                ptbAnh.Image = img;
            }
            else
            {
                ptbAnh.Image = null;
            }
        }

        private void ptbAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "*.PNG, *.JPG, *JPEG | *.PNG; *.JPG; *.JPEG | All file (*.*) | *.*";
            dlg.Title = "Chọn ảnh đại diện";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filelocation = dlg.FileName;
                ptbAnh.Image = Image.FromFile(filelocation);
            }
        }

        
    }
}
