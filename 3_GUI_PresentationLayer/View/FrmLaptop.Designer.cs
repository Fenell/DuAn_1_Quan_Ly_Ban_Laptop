using _3_GUI_PresentationLayer.Utilities;
using System.Windows.Media.Media3D;

namespace _3_GUI_PresentationLayer.View
{
    partial class FrmLaptop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            iconButton18 = new FontAwesome.Sharp.IconButton();
            iconButton17 = new FontAwesome.Sharp.IconButton();
            rdbtnNgungBan = new CustomControl.RadioButtonCustom();
            rdbtnDangBan = new CustomControl.RadioButtonCustom();
            btnTimKiem = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new CustomControl.TextBoxCustom2_0();
            label19 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            txtTrongLuong = new CustomControl.TextBoxCustom2_0();
            label2 = new Label();
            txtNamBh = new CustomControl.TextBoxCustom2_0();
            label1 = new Label();
            txtMoTa = new CustomControl.TextBoxCustom2_0();
            btnClearForm = new FontAwesome.Sharp.IconButton();
            btnDoiTT = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            btnSua = new FontAwesome.Sharp.IconButton();
            btnThem = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtGiaBan = new CustomControl.TextBoxCustom2_0();
            txtGiaNhap = new CustomControl.TextBoxCustom2_0();
            txtTen = new CustomControl.TextBoxCustom2_0();
            label3 = new Label();
            lb = new Label();
            pcbHinhAnh = new PictureBox();
            panel3 = new Panel();
            dgvLaptop = new DataGridView();
            panel4 = new Panel();
            cbbImei = new ComboBox();
            cbbMauSac = new ComboBox();
            cbbManHinh = new ComboBox();
            cbbOCung = new ComboBox();
            cbbRam = new ComboBox();
            cbbVga = new ComboBox();
            cbbCpu = new ComboBox();
            cbbNhaCungCap = new ComboBox();
            cbbDong = new ComboBox();
            cbbHangSanXuat = new ComboBox();
            btnImei = new FontAwesome.Sharp.IconButton();
            btnMauSac = new FontAwesome.Sharp.IconButton();
            btnManHinh = new FontAwesome.Sharp.IconButton();
            btnOCung = new FontAwesome.Sharp.IconButton();
            btnRam = new FontAwesome.Sharp.IconButton();
            btnVga = new FontAwesome.Sharp.IconButton();
            btnCpu = new FontAwesome.Sharp.IconButton();
            btnNhaCungCap = new FontAwesome.Sharp.IconButton();
            btnDongLaptop = new FontAwesome.Sharp.IconButton();
            btnHangSanXuat = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbHinhAnh).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaptop).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(iconButton18);
            panel1.Controls.Add(iconButton17);
            panel1.Controls.Add(rdbtnNgungBan);
            panel1.Controls.Add(rdbtnDangBan);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(label19);
            panel1.Location = new Point(12, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 69);
            panel1.TabIndex = 0;
            // 
            // iconButton18
            // 
            iconButton18.FlatAppearance.BorderSize = 0;
            iconButton18.FlatStyle = FlatStyle.Flat;
            iconButton18.IconChar = FontAwesome.Sharp.IconChar.SortAmountDown;
            iconButton18.IconColor = Color.FromArgb(255, 181, 174);
            iconButton18.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton18.Location = new Point(998, 6);
            iconButton18.Name = "iconButton18";
            iconButton18.Padding = new Padding(0, 5, 0, 0);
            iconButton18.Size = new Size(63, 55);
            iconButton18.TabIndex = 21;
            iconButton18.UseVisualStyleBackColor = true;
            // 
            // iconButton17
            // 
            iconButton17.FlatAppearance.BorderSize = 0;
            iconButton17.FlatStyle = FlatStyle.Flat;
            iconButton17.IconChar = FontAwesome.Sharp.IconChar.ArrowUpWideShort;
            iconButton17.IconColor = Color.FromArgb(255, 181, 174);
            iconButton17.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton17.Location = new Point(929, 7);
            iconButton17.Name = "iconButton17";
            iconButton17.Padding = new Padding(0, 5, 0, 0);
            iconButton17.Size = new Size(63, 55);
            iconButton17.TabIndex = 21;
            iconButton17.UseVisualStyleBackColor = true;
            // 
            // rdbtnNgungBan
            // 
            rdbtnNgungBan.AutoSize = true;
            rdbtnNgungBan.CheckedColor = Color.MediumSlateBlue;
            rdbtnNgungBan.ForeColor = Color.FromArgb(3, 22, 73);
            rdbtnNgungBan.Location = new Point(436, 29);
            rdbtnNgungBan.MinimumSize = new Size(0, 21);
            rdbtnNgungBan.Name = "rdbtnNgungBan";
            rdbtnNgungBan.Padding = new Padding(10, 0, 0, 0);
            rdbtnNgungBan.Size = new Size(95, 21);
            rdbtnNgungBan.TabIndex = 20;
            rdbtnNgungBan.TabStop = true;
            rdbtnNgungBan.Text = "Ngừng bán";
            rdbtnNgungBan.UnCheckedColor = Color.FromArgb(79, 175, 156);
            rdbtnNgungBan.UseVisualStyleBackColor = true;
            // 
            // rdbtnDangBan
            // 
            rdbtnDangBan.AutoSize = true;
            rdbtnDangBan.CheckedColor = Color.MediumSlateBlue;
            rdbtnDangBan.ForeColor = Color.FromArgb(3, 22, 73);
            rdbtnDangBan.Location = new Point(326, 29);
            rdbtnDangBan.MinimumSize = new Size(0, 21);
            rdbtnDangBan.Name = "rdbtnDangBan";
            rdbtnDangBan.Padding = new Padding(10, 0, 0, 0);
            rdbtnDangBan.Size = new Size(86, 21);
            rdbtnDangBan.TabIndex = 20;
            rdbtnDangBan.TabStop = true;
            rdbtnDangBan.Text = "Đang bán";
            rdbtnDangBan.UnCheckedColor = Color.FromArgb(79, 175, 156);
            rdbtnDangBan.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnTimKiem.IconColor = Color.Black;
            btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTimKiem.IconSize = 20;
            btnTimKiem.Location = new Point(24, 27);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(30, 26);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = Color.White;
            txtTimKiem.BorderColor = Color.MediumSlateBlue;
            txtTimKiem.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtTimKiem.BorderRadius = 10;
            txtTimKiem.BorderSize = 1;
            txtTimKiem.Location = new Point(17, 24);
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Padding = new Padding(40, 7, 7, 7);
            txtTimKiem.PasswordChar = false;
            txtTimKiem.PlaceholderColor = Color.FromArgb(3, 22, 73);
            txtTimKiem.PlaceholderText = "Tìm kiếm...";
            txtTimKiem.Size = new Size(254, 30);
            txtTimKiem.TabIndex = 18;
            txtTimKiem.Texts = "";
            txtTimKiem.UnderlinedStyle = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(3, 22, 73);
            label19.Location = new Point(3, 2);
            label19.Name = "label19";
            label19.Size = new Size(71, 20);
            label19.TabIndex = 17;
            label19.Text = "Tìm kiếm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(3, 22, 73);
            label9.Location = new Point(17, 6);
            label9.Name = "label9";
            label9.Size = new Size(107, 20);
            label9.TabIndex = 17;
            label9.Text = "Hãng sản xuất";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtTrongLuong);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNamBh);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtMoTa);
            panel2.Controls.Add(btnClearForm);
            panel2.Controls.Add(btnDoiTT);
            panel2.Controls.Add(iconButton4);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtGiaBan);
            panel2.Controls.Add(txtGiaNhap);
            panel2.Controls.Add(txtTen);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lb);
            panel2.Controls.Add(pcbHinhAnh);
            panel2.Location = new Point(1110, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 630);
            panel2.TabIndex = 1;
            // 
            // txtTrongLuong
            // 
            txtTrongLuong.BackColor = Color.White;
            txtTrongLuong.BorderColor = Color.CornflowerBlue;
            txtTrongLuong.BorderFocusColor = Color.HotPink;
            txtTrongLuong.BorderRadius = 5;
            txtTrongLuong.BorderSize = 2;
            txtTrongLuong.Location = new Point(20, 320);
            txtTrongLuong.Multiline = false;
            txtTrongLuong.Name = "txtTrongLuong";
            txtTrongLuong.Padding = new Padding(7);
            txtTrongLuong.PasswordChar = false;
            txtTrongLuong.PlaceholderColor = Color.DarkGray;
            txtTrongLuong.PlaceholderText = "";
            txtTrongLuong.Size = new Size(122, 30);
            txtTrongLuong.TabIndex = 21;
            txtTrongLuong.Texts = "";
            txtTrongLuong.UnderlinedStyle = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(3, 22, 73);
            label2.Location = new Point(19, 295);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 20;
            label2.Text = "Trọng lượng";
            // 
            // txtNamBh
            // 
            txtNamBh.BackColor = Color.White;
            txtNamBh.BorderColor = Color.CornflowerBlue;
            txtNamBh.BorderFocusColor = Color.HotPink;
            txtNamBh.BorderRadius = 5;
            txtNamBh.BorderSize = 2;
            txtNamBh.Location = new Point(219, 320);
            txtNamBh.Multiline = false;
            txtNamBh.Name = "txtNamBh";
            txtNamBh.Padding = new Padding(7);
            txtNamBh.PasswordChar = false;
            txtNamBh.PlaceholderColor = Color.DarkGray;
            txtNamBh.PlaceholderText = "";
            txtNamBh.Size = new Size(122, 30);
            txtNamBh.TabIndex = 19;
            txtNamBh.Texts = "";
            txtNamBh.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(3, 22, 73);
            label1.Location = new Point(227, 295);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 18;
            label1.Text = "Năm Bh";
            // 
            // txtMoTa
            // 
            txtMoTa.BorderColor = Color.MediumSlateBlue;
            txtMoTa.BorderFocusColor = Color.HotPink;
            txtMoTa.BorderRadius = 10;
            txtMoTa.BorderSize = 1;
            txtMoTa.Location = new Point(25, 463);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Padding = new Padding(7);
            txtMoTa.PasswordChar = false;
            txtMoTa.PlaceholderColor = Color.DarkGray;
            txtMoTa.PlaceholderText = "";
            txtMoTa.Size = new Size(319, 103);
            txtMoTa.TabIndex = 17;
            txtMoTa.Texts = "";
            txtMoTa.UnderlinedStyle = false;
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.White;
            btnClearForm.FlatAppearance.BorderSize = 0;
            btnClearForm.FlatStyle = FlatStyle.Flat;
            btnClearForm.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            btnClearForm.IconColor = Color.FromArgb(61, 39, 76);
            btnClearForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClearForm.IconSize = 45;
            btnClearForm.Location = new Point(291, 577);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(53, 37);
            btnClearForm.TabIndex = 16;
            btnClearForm.UseVisualStyleBackColor = false;
            // 
            // btnDoiTT
            // 
            btnDoiTT.BackColor = Color.White;
            btnDoiTT.FlatAppearance.BorderSize = 0;
            btnDoiTT.FlatStyle = FlatStyle.Flat;
            btnDoiTT.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnDoiTT.IconColor = Color.FromArgb(61, 39, 76);
            btnDoiTT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDoiTT.IconSize = 45;
            btnDoiTT.Location = new Point(227, 577);
            btnDoiTT.Name = "btnDoiTT";
            btnDoiTT.Size = new Size(53, 37);
            btnDoiTT.TabIndex = 16;
            btnDoiTT.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.White;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            iconButton4.IconColor = Color.FromArgb(61, 39, 76);
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 45;
            iconButton4.Location = new Point(158, 577);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(53, 37);
            iconButton4.TabIndex = 15;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnSua.IconColor = Color.FromArgb(61, 39, 76);
            btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSua.IconSize = 45;
            btnSua.Location = new Point(92, 577);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(53, 37);
            btnSua.TabIndex = 14;
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnThem.IconColor = Color.FromArgb(61, 39, 76);
            btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThem.IconSize = 45;
            btnThem.Location = new Point(36, 577);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(53, 37);
            btnThem.TabIndex = 13;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(3, 22, 73);
            label8.Location = new Point(19, 436);
            label8.Name = "label8";
            label8.Size = new Size(107, 21);
            label8.TabIndex = 11;
            label8.Text = "Mô tả chi tiết";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(22, 24, 63);
            label7.Location = new Point(192, 403);
            label7.Name = "label7";
            label7.Size = new Size(16, 21);
            label7.TabIndex = 10;
            label7.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(3, 22, 73);
            label6.Location = new Point(219, 369);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 9;
            label6.Text = "Giá bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(3, 22, 73);
            label5.Location = new Point(20, 369);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 8;
            label5.Text = "Giá nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(3, 22, 73);
            label4.Location = new Point(347, 403);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 7;
            label4.Text = "VND";
            // 
            // txtGiaBan
            // 
            txtGiaBan.BackColor = Color.White;
            txtGiaBan.BorderColor = Color.MediumSlateBlue;
            txtGiaBan.BorderFocusColor = Color.HotPink;
            txtGiaBan.BorderRadius = 5;
            txtGiaBan.BorderSize = 2;
            txtGiaBan.Location = new Point(219, 394);
            txtGiaBan.Multiline = false;
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Padding = new Padding(7);
            txtGiaBan.PasswordChar = false;
            txtGiaBan.PlaceholderColor = Color.DarkGray;
            txtGiaBan.PlaceholderText = "";
            txtGiaBan.Size = new Size(122, 30);
            txtGiaBan.TabIndex = 6;
            txtGiaBan.Texts = "";
            txtGiaBan.UnderlinedStyle = true;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.BackColor = Color.White;
            txtGiaNhap.BorderColor = Color.MediumSlateBlue;
            txtGiaNhap.BorderFocusColor = Color.HotPink;
            txtGiaNhap.BorderRadius = 5;
            txtGiaNhap.BorderSize = 2;
            txtGiaNhap.Location = new Point(20, 394);
            txtGiaNhap.Multiline = false;
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Padding = new Padding(7);
            txtGiaNhap.PasswordChar = false;
            txtGiaNhap.PlaceholderColor = Color.DarkGray;
            txtGiaNhap.PlaceholderText = "";
            txtGiaNhap.Size = new Size(122, 30);
            txtGiaNhap.TabIndex = 5;
            txtGiaNhap.Texts = "";
            txtGiaNhap.UnderlinedStyle = true;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.White;
            txtTen.BorderColor = Color.CornflowerBlue;
            txtTen.BorderFocusColor = Color.HotPink;
            txtTen.BorderRadius = 5;
            txtTen.BorderSize = 2;
            txtTen.Location = new Point(126, 232);
            txtTen.Multiline = false;
            txtTen.Name = "txtTen";
            txtTen.Padding = new Padding(7);
            txtTen.PasswordChar = false;
            txtTen.PlaceholderColor = Color.DarkGray;
            txtTen.PlaceholderText = "";
            txtTen.Size = new Size(215, 30);
            txtTen.TabIndex = 4;
            txtTen.Texts = "";
            txtTen.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(3, 22, 73);
            label3.Location = new Point(148, 403);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 1;
            label3.Text = "VND";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb.ForeColor = Color.FromArgb(3, 22, 73);
            lb.Location = new Point(19, 243);
            lb.Name = "lb";
            lb.Size = new Size(91, 21);
            lb.TabIndex = 1;
            lb.Text = "Tên Laptop";
            // 
            // pcbHinhAnh
            // 
            pcbHinhAnh.Location = new Point(112, 24);
            pcbHinhAnh.Name = "pcbHinhAnh";
            pcbHinhAnh.Size = new Size(195, 190);
            pcbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbHinhAnh.TabIndex = 0;
            pcbHinhAnh.TabStop = false;
            pcbHinhAnh.DoubleClick += pcbHinhAnh_DoubleClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvLaptop);
            panel3.Location = new Point(12, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(1078, 286);
            panel3.TabIndex = 2;
            // 
            // dgvLaptop
            // 
            dgvLaptop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaptop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaptop.Dock = DockStyle.Fill;
            dgvLaptop.Location = new Point(0, 0);
            dgvLaptop.Name = "dgvLaptop";
            dgvLaptop.RowHeadersVisible = false;
            dgvLaptop.RowTemplate.Height = 25;
            dgvLaptop.Size = new Size(1078, 286);
            dgvLaptop.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(cbbImei);
            panel4.Controls.Add(cbbMauSac);
            panel4.Controls.Add(cbbManHinh);
            panel4.Controls.Add(cbbOCung);
            panel4.Controls.Add(cbbRam);
            panel4.Controls.Add(cbbVga);
            panel4.Controls.Add(cbbCpu);
            panel4.Controls.Add(cbbNhaCungCap);
            panel4.Controls.Add(cbbDong);
            panel4.Controls.Add(cbbHangSanXuat);
            panel4.Controls.Add(btnImei);
            panel4.Controls.Add(btnMauSac);
            panel4.Controls.Add(btnManHinh);
            panel4.Controls.Add(btnOCung);
            panel4.Controls.Add(btnRam);
            panel4.Controls.Add(btnVga);
            panel4.Controls.Add(btnCpu);
            panel4.Controls.Add(btnNhaCungCap);
            panel4.Controls.Add(btnDongLaptop);
            panel4.Controls.Add(btnHangSanXuat);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(12, 408);
            panel4.Name = "panel4";
            panel4.Size = new Size(1078, 236);
            panel4.TabIndex = 3;
            // 
            // cbbImei
            // 
            cbbImei.FormattingEnabled = true;
            cbbImei.Location = new Point(915, 149);
            cbbImei.Name = "cbbImei";
            cbbImei.Size = new Size(150, 23);
            cbbImei.TabIndex = 31;
            // 
            // cbbMauSac
            // 
            cbbMauSac.FormattingEnabled = true;
            cbbMauSac.Location = new Point(699, 149);
            cbbMauSac.Name = "cbbMauSac";
            cbbMauSac.Size = new Size(150, 23);
            cbbMauSac.TabIndex = 30;
            // 
            // cbbManHinh
            // 
            cbbManHinh.FormattingEnabled = true;
            cbbManHinh.Location = new Point(456, 149);
            cbbManHinh.Name = "cbbManHinh";
            cbbManHinh.Size = new Size(150, 23);
            cbbManHinh.TabIndex = 29;
            // 
            // cbbOCung
            // 
            cbbOCung.FormattingEnabled = true;
            cbbOCung.Location = new Point(235, 149);
            cbbOCung.Name = "cbbOCung";
            cbbOCung.Size = new Size(150, 23);
            cbbOCung.TabIndex = 28;
            // 
            // cbbRam
            // 
            cbbRam.FormattingEnabled = true;
            cbbRam.Location = new Point(17, 149);
            cbbRam.Name = "cbbRam";
            cbbRam.Size = new Size(150, 23);
            cbbRam.TabIndex = 27;
            // 
            // cbbVga
            // 
            cbbVga.FormattingEnabled = true;
            cbbVga.Location = new Point(915, 35);
            cbbVga.Name = "cbbVga";
            cbbVga.Size = new Size(150, 23);
            cbbVga.TabIndex = 26;
            // 
            // cbbCpu
            // 
            cbbCpu.FormattingEnabled = true;
            cbbCpu.Location = new Point(699, 35);
            cbbCpu.Name = "cbbCpu";
            cbbCpu.Size = new Size(150, 23);
            cbbCpu.TabIndex = 25;
            // 
            // cbbNhaCungCap
            // 
            cbbNhaCungCap.FormattingEnabled = true;
            cbbNhaCungCap.Location = new Point(456, 35);
            cbbNhaCungCap.Name = "cbbNhaCungCap";
            cbbNhaCungCap.Size = new Size(150, 23);
            cbbNhaCungCap.TabIndex = 24;
            // 
            // cbbDong
            // 
            cbbDong.FormattingEnabled = true;
            cbbDong.Location = new Point(235, 35);
            cbbDong.Name = "cbbDong";
            cbbDong.Size = new Size(150, 23);
            cbbDong.TabIndex = 23;
            // 
            // cbbHangSanXuat
            // 
            cbbHangSanXuat.FormattingEnabled = true;
            cbbHangSanXuat.Location = new Point(17, 35);
            cbbHangSanXuat.Name = "cbbHangSanXuat";
            cbbHangSanXuat.Size = new Size(150, 23);
            cbbHangSanXuat.TabIndex = 22;
            // 
            // btnImei
            // 
            btnImei.BackColor = Color.FromArgb(86, 103, 204);
            btnImei.FlatStyle = FlatStyle.Flat;
            btnImei.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnImei.IconColor = Color.Black;
            btnImei.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImei.IconSize = 28;
            btnImei.Location = new Point(915, 182);
            btnImei.Name = "btnImei";
            btnImei.Padding = new Padding(0, 4, 0, 0);
            btnImei.Size = new Size(150, 36);
            btnImei.TabIndex = 20;
            btnImei.UseVisualStyleBackColor = false;
            // 
            // btnMauSac
            // 
            btnMauSac.BackColor = Color.FromArgb(86, 103, 204);
            btnMauSac.FlatStyle = FlatStyle.Flat;
            btnMauSac.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnMauSac.IconColor = Color.Black;
            btnMauSac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMauSac.IconSize = 28;
            btnMauSac.Location = new Point(699, 182);
            btnMauSac.Name = "btnMauSac";
            btnMauSac.Padding = new Padding(0, 4, 0, 0);
            btnMauSac.Size = new Size(150, 36);
            btnMauSac.TabIndex = 20;
            btnMauSac.UseVisualStyleBackColor = false;
            btnMauSac.Click += btnMauSac_Click;
            // 
            // btnManHinh
            // 
            btnManHinh.BackColor = Color.FromArgb(86, 103, 204);
            btnManHinh.FlatStyle = FlatStyle.Flat;
            btnManHinh.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnManHinh.IconColor = Color.Black;
            btnManHinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnManHinh.IconSize = 28;
            btnManHinh.Location = new Point(456, 182);
            btnManHinh.Name = "btnManHinh";
            btnManHinh.Padding = new Padding(0, 4, 0, 0);
            btnManHinh.Size = new Size(150, 36);
            btnManHinh.TabIndex = 20;
            btnManHinh.UseVisualStyleBackColor = false;
            btnManHinh.Click += btnManHinh_Click;
            // 
            // btnOCung
            // 
            btnOCung.BackColor = Color.FromArgb(86, 103, 204);
            btnOCung.FlatStyle = FlatStyle.Flat;
            btnOCung.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnOCung.IconColor = Color.Black;
            btnOCung.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOCung.IconSize = 28;
            btnOCung.Location = new Point(235, 182);
            btnOCung.Name = "btnOCung";
            btnOCung.Padding = new Padding(0, 4, 0, 0);
            btnOCung.Size = new Size(150, 36);
            btnOCung.TabIndex = 20;
            btnOCung.UseVisualStyleBackColor = false;
            btnOCung.Click += btnOCung_Click;
            // 
            // btnRam
            // 
            btnRam.BackColor = Color.FromArgb(86, 103, 204);
            btnRam.FlatStyle = FlatStyle.Flat;
            btnRam.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnRam.IconColor = Color.Black;
            btnRam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRam.IconSize = 28;
            btnRam.Location = new Point(17, 182);
            btnRam.Name = "btnRam";
            btnRam.Padding = new Padding(0, 4, 0, 0);
            btnRam.Size = new Size(150, 36);
            btnRam.TabIndex = 20;
            btnRam.UseVisualStyleBackColor = false;
            btnRam.Click += btnRam_Click;
            // 
            // btnVga
            // 
            btnVga.BackColor = Color.FromArgb(86, 103, 204);
            btnVga.FlatStyle = FlatStyle.Flat;
            btnVga.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnVga.IconColor = Color.Black;
            btnVga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVga.IconSize = 28;
            btnVga.Location = new Point(915, 67);
            btnVga.Name = "btnVga";
            btnVga.Padding = new Padding(0, 4, 0, 0);
            btnVga.Size = new Size(150, 36);
            btnVga.TabIndex = 20;
            btnVga.UseVisualStyleBackColor = false;
            btnVga.Click += btnVga_Click;
            // 
            // btnCpu
            // 
            btnCpu.BackColor = Color.FromArgb(86, 103, 204);
            btnCpu.FlatStyle = FlatStyle.Flat;
            btnCpu.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnCpu.IconColor = Color.Black;
            btnCpu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCpu.IconSize = 28;
            btnCpu.Location = new Point(699, 67);
            btnCpu.Name = "btnCpu";
            btnCpu.Padding = new Padding(0, 4, 0, 0);
            btnCpu.Size = new Size(150, 36);
            btnCpu.TabIndex = 20;
            btnCpu.UseVisualStyleBackColor = false;
            btnCpu.Click += btnCpu_Click;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.BackColor = Color.FromArgb(86, 103, 204);
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNhaCungCap.IconColor = Color.Black;
            btnNhaCungCap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhaCungCap.IconSize = 28;
            btnNhaCungCap.Location = new Point(456, 67);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Padding = new Padding(0, 4, 0, 0);
            btnNhaCungCap.Size = new Size(150, 36);
            btnNhaCungCap.TabIndex = 20;
            btnNhaCungCap.UseVisualStyleBackColor = false;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // btnDongLaptop
            // 
            btnDongLaptop.BackColor = Color.FromArgb(86, 103, 204);
            btnDongLaptop.FlatStyle = FlatStyle.Flat;
            btnDongLaptop.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnDongLaptop.IconColor = Color.Black;
            btnDongLaptop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDongLaptop.IconSize = 28;
            btnDongLaptop.Location = new Point(235, 67);
            btnDongLaptop.Name = "btnDongLaptop";
            btnDongLaptop.Padding = new Padding(0, 4, 0, 0);
            btnDongLaptop.Size = new Size(150, 36);
            btnDongLaptop.TabIndex = 20;
            btnDongLaptop.UseVisualStyleBackColor = false;
            btnDongLaptop.Click += btnDongLaptop_Click;
            // 
            // btnHangSanXuat
            // 
            btnHangSanXuat.BackColor = Color.FromArgb(86, 103, 204);
            btnHangSanXuat.FlatStyle = FlatStyle.Flat;
            btnHangSanXuat.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnHangSanXuat.IconColor = Color.Black;
            btnHangSanXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHangSanXuat.IconSize = 28;
            btnHangSanXuat.Location = new Point(17, 67);
            btnHangSanXuat.Name = "btnHangSanXuat";
            btnHangSanXuat.Padding = new Padding(0, 4, 0, 0);
            btnHangSanXuat.Size = new Size(150, 36);
            btnHangSanXuat.TabIndex = 20;
            btnHangSanXuat.UseVisualStyleBackColor = false;
            btnHangSanXuat.Click += btnHangSanXuat_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(3, 22, 73);
            label13.Location = new Point(915, 6);
            label13.Name = "label13";
            label13.Size = new Size(39, 20);
            label13.TabIndex = 17;
            label13.Text = "VGA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(3, 22, 73);
            label12.Location = new Point(699, 6);
            label12.Name = "label12";
            label12.Size = new Size(38, 20);
            label12.TabIndex = 17;
            label12.Text = "CPU";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(3, 22, 73);
            label11.Location = new Point(456, 6);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 17;
            label11.Text = "Nhà cung cấp";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(3, 22, 73);
            label10.Location = new Point(235, 6);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 17;
            label10.Text = "Dòng laptop";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(3, 22, 73);
            label18.Location = new Point(915, 121);
            label18.Name = "label18";
            label18.Size = new Size(38, 20);
            label18.TabIndex = 17;
            label18.Text = "Imei";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(3, 22, 73);
            label17.Location = new Point(699, 121);
            label17.Name = "label17";
            label17.Size = new Size(65, 20);
            label17.TabIndex = 17;
            label17.Text = "Màu sắc";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(3, 22, 73);
            label16.Location = new Point(456, 121);
            label16.Name = "label16";
            label16.Size = new Size(75, 20);
            label16.TabIndex = 17;
            label16.Text = "Màn hình";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(3, 22, 73);
            label15.Location = new Point(235, 121);
            label15.Name = "label15";
            label15.Size = new Size(142, 20);
            label15.TabIndex = 17;
            label15.Text = "Dung lượng ổ cứng";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(3, 22, 73);
            label14.Location = new Point(17, 121);
            label14.Name = "label14";
            label14.Size = new Size(39, 20);
            label14.TabIndex = 17;
            label14.Text = "Ram";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1521, 647);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(244, 245, 255);
            panel6.Controls.Add(panel3);
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(panel1);
            panel6.Controls.Add(panel4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1521, 647);
            panel6.TabIndex = 0;
            // 
            // FrmLaptop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 247, 255);
            ClientSize = new Size(1521, 647);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1521, 647);
            Name = "FrmLaptop";
            Text = "FrmLaptop";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbHinhAnh).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLaptop).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lb;
        private PictureBox pcbHinhAnh;
        private FontAwesome.Sharp.IconButton btnDoiTT;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private CustomControl.TextBoxCustom2_0 txtGiaBan;
        private CustomControl.TextBoxCustom2_0 txtGiaNhap;
        private Label label3;
        private Label label9;
        private Panel panel5;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private CustomControl.TextBoxCustom2_0 txtTimKiem;
        private CustomControl.RadioButtonCustom rdbtnNgungBan;
        private CustomControl.RadioButtonCustom rdbtnDangBan;
        private DataGridView dgvLaptop;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnHangSanXuat;
        private Label label14;
        private FontAwesome.Sharp.IconButton btnImei;
        private FontAwesome.Sharp.IconButton btnMauSac;
        private FontAwesome.Sharp.IconButton btnManHinh;
        private FontAwesome.Sharp.IconButton btnOCung;
        private FontAwesome.Sharp.IconButton btnRam;
        private FontAwesome.Sharp.IconButton btnVga;
        private FontAwesome.Sharp.IconButton btnCpu;
        private FontAwesome.Sharp.IconButton btnNhaCungCap;
        private FontAwesome.Sharp.IconButton btnDongLaptop;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private FontAwesome.Sharp.IconButton iconButton17;
        private Label label19;
        private FontAwesome.Sharp.IconButton iconButton18;
        private CustomControl.TextBoxCustom2_0 txtTen;
        private CustomControl.TextBoxCustom2_0 txtMoTa;
        private FontAwesome.Sharp.IconButton btnClearForm;
        private ComboBox cbbMauSac;
        private ComboBox cbbManHinh;
        private ComboBox cbbOCung;
        private ComboBox cbbRam;
        private ComboBox cbbVga;
        private ComboBox cbbCpu;
        private ComboBox cbbNhaCungCap;
        private ComboBox cbbDong;
        private ComboBox cbbHangSanXuat;
        private CustomControl.TextBoxCustom2_0 txtNamBh;
        private Label label1;
        private ComboBox cbbImei;
        private CustomControl.TextBoxCustom2_0 txtTrongLuong;
        private Label label2;
    }
}