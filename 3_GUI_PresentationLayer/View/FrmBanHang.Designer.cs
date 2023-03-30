﻿namespace _3_GUI_PresentationLayer.View
{
    partial class FrmBanHang
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            txtMaHD = new CustomControl.TextBoxCustom2_0();
            label10 = new Label();
            groupBox3 = new GroupBox();
            cbbSdtKH = new ComboBox();
            lblHoTen = new Label();
            label5 = new Label();
            label6 = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            lblTongTien = new Label();
            btnHuyHD = new FontAwesome.Sharp.IconButton();
            btnSuaHD = new FontAwesome.Sharp.IconButton();
            btnLuuHD = new FontAwesome.Sharp.IconButton();
            btnThanhToan = new FontAwesome.Sharp.IconButton();
            txtKhachDua = new CustomControl.TextBoxCustom2_0();
            txtGhiChu = new CustomControl.TextBoxCustom2_0();
            lblTienThua = new Label();
            label9 = new Label();
            label12 = new Label();
            label8 = new Label();
            rbtnCash = new CustomControl.RadioButtonCustom();
            rbtnTransfer = new CustomControl.RadioButtonCustom();
            label3 = new Label();
            label4 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            cbbCamera = new ComboBox();
            panel4 = new Panel();
            ptbCamera = new PictureBox();
            activeCamera = new CustomControl.ButtonCustom();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new CustomControl.TextBoxCustom2_0();
            btnDesc = new FontAwesome.Sharp.IconButton();
            btnAsc = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            panel3 = new Panel();
            dgvSanPham = new DataGridView();
            groupBox2 = new GroupBox();
            dgvGioHang = new DataGridView();
            grbCart = new GroupBox();
            tCamera = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbCamera).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtMaHD);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(lblTongTien);
            panel1.Controls.Add(btnHuyHD);
            panel1.Controls.Add(btnSuaHD);
            panel1.Controls.Add(btnLuuHD);
            panel1.Controls.Add(btnThanhToan);
            panel1.Controls.Add(txtKhachDua);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(lblTienThua);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(rbtnCash);
            panel1.Controls.Add(rbtnTransfer);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(1011, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 655);
            panel1.TabIndex = 19;
            // 
            // txtMaHD
            // 
            txtMaHD.BorderColor = Color.MediumSlateBlue;
            txtMaHD.BorderFocusColor = Color.HotPink;
            txtMaHD.BorderRadius = 0;
            txtMaHD.BorderSize = 2;
            txtMaHD.Location = new Point(125, 152);
            txtMaHD.Multiline = false;
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Padding = new Padding(7);
            txtMaHD.PasswordChar = false;
            txtMaHD.PlaceholderColor = Color.DarkGray;
            txtMaHD.PlaceholderText = "";
            txtMaHD.Size = new Size(241, 30);
            txtMaHD.TabIndex = 52;
            txtMaHD.Texts = "";
            txtMaHD.UnderlinedStyle = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(8, 162);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 17;
            label10.Text = "Mã hóa đơn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbbSdtKH);
            groupBox3.Controls.Add(lblHoTen);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(iconButton3);
            groupBox3.Location = new Point(11, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(391, 121);
            groupBox3.TabIndex = 51;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách hàng";
            // 
            // cbbSdtKH
            // 
            cbbSdtKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbSdtKH.FormattingEnabled = true;
            cbbSdtKH.Location = new Point(127, 24);
            cbbSdtKH.Name = "cbbSdtKH";
            cbbSdtKH.Size = new Size(198, 23);
            cbbSdtKH.TabIndex = 51;
            cbbSdtKH.TextChanged += cbbSdtKH_TextChanged;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoTen.ForeColor = SystemColors.HotTrack;
            lblHoTen.Location = new Point(127, 79);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(56, 20);
            lblHoTen.TabIndex = 16;
            lblHoTen.Text = "Họ tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(46, 79);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 15;
            label5.Text = "Họ tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(3, 30);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 13;
            label6.Text = "Số điện thoại";
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.White;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            iconButton3.IconColor = Color.FromArgb(86, 122, 228);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 35;
            iconButton3.Location = new Point(331, 11);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(46, 46);
            iconButton3.TabIndex = 13;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTien.ForeColor = Color.Red;
            lblTongTien.Location = new Point(125, 564);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(0, 25);
            lblTongTien.TabIndex = 50;
            lblTongTien.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnHuyHD
            // 
            btnHuyHD.FlatAppearance.BorderSize = 0;
            btnHuyHD.FlatAppearance.MouseDownBackColor = Color.FromArgb(232, 225, 197);
            btnHuyHD.FlatAppearance.MouseOverBackColor = Color.White;
            btnHuyHD.FlatStyle = FlatStyle.Flat;
            btnHuyHD.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            btnHuyHD.IconColor = Color.FromArgb(148, 105, 215);
            btnHuyHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHuyHD.IconSize = 38;
            btnHuyHD.Location = new Point(289, 599);
            btnHuyHD.Name = "btnHuyHD";
            btnHuyHD.Size = new Size(66, 55);
            btnHuyHD.TabIndex = 49;
            btnHuyHD.UseVisualStyleBackColor = true;
            btnHuyHD.Click += btnHuyHD_Click;
            // 
            // btnSuaHD
            // 
            btnSuaHD.FlatAppearance.BorderSize = 0;
            btnSuaHD.FlatAppearance.MouseDownBackColor = Color.FromArgb(232, 225, 197);
            btnSuaHD.FlatAppearance.MouseOverBackColor = Color.White;
            btnSuaHD.FlatStyle = FlatStyle.Flat;
            btnSuaHD.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            btnSuaHD.IconColor = Color.FromArgb(148, 105, 215);
            btnSuaHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSuaHD.IconSize = 38;
            btnSuaHD.Location = new Point(208, 599);
            btnSuaHD.Name = "btnSuaHD";
            btnSuaHD.Size = new Size(66, 55);
            btnSuaHD.TabIndex = 49;
            btnSuaHD.UseVisualStyleBackColor = true;
            btnSuaHD.Click += btnSuaHD_Click;
            // 
            // btnLuuHD
            // 
            btnLuuHD.FlatAppearance.BorderSize = 0;
            btnLuuHD.FlatAppearance.MouseDownBackColor = Color.FromArgb(232, 225, 197);
            btnLuuHD.FlatAppearance.MouseOverBackColor = Color.White;
            btnLuuHD.FlatStyle = FlatStyle.Flat;
            btnLuuHD.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnLuuHD.IconColor = Color.FromArgb(148, 105, 215);
            btnLuuHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLuuHD.IconSize = 38;
            btnLuuHD.Location = new Point(127, 599);
            btnLuuHD.Name = "btnLuuHD";
            btnLuuHD.Size = new Size(66, 55);
            btnLuuHD.TabIndex = 49;
            btnLuuHD.UseVisualStyleBackColor = true;
            btnLuuHD.Click += btnLuuHD_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatAppearance.MouseDownBackColor = Color.FromArgb(232, 225, 197);
            btnThanhToan.FlatAppearance.MouseOverBackColor = Color.White;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            btnThanhToan.IconColor = Color.FromArgb(148, 105, 215);
            btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThanhToan.IconSize = 38;
            btnThanhToan.Location = new Point(34, 599);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(66, 55);
            btnThanhToan.TabIndex = 49;
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtKhachDua
            // 
            txtKhachDua.BorderColor = Color.MediumSlateBlue;
            txtKhachDua.BorderFocusColor = Color.HotPink;
            txtKhachDua.BorderRadius = 0;
            txtKhachDua.BorderSize = 2;
            txtKhachDua.Location = new Point(126, 471);
            txtKhachDua.Multiline = false;
            txtKhachDua.Name = "txtKhachDua";
            txtKhachDua.Padding = new Padding(7);
            txtKhachDua.PasswordChar = false;
            txtKhachDua.PlaceholderColor = Color.DarkGray;
            txtKhachDua.PlaceholderText = "";
            txtKhachDua.Size = new Size(240, 30);
            txtKhachDua.TabIndex = 48;
            txtKhachDua.Texts = "";
            txtKhachDua.UnderlinedStyle = true;
            // 
            // txtGhiChu
            // 
            txtGhiChu.BorderColor = Color.MediumSlateBlue;
            txtGhiChu.BorderFocusColor = Color.HotPink;
            txtGhiChu.BorderRadius = 10;
            txtGhiChu.BorderSize = 1;
            txtGhiChu.Location = new Point(125, 231);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Padding = new Padding(7);
            txtGhiChu.PasswordChar = false;
            txtGhiChu.PlaceholderColor = Color.DarkGray;
            txtGhiChu.PlaceholderText = "";
            txtGhiChu.Size = new Size(241, 70);
            txtGhiChu.TabIndex = 47;
            txtGhiChu.Texts = "";
            txtGhiChu.UnderlinedStyle = false;
            // 
            // lblTienThua
            // 
            lblTienThua.AutoSize = true;
            lblTienThua.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTienThua.ForeColor = SystemColors.HotTrack;
            lblTienThua.Location = new Point(138, 530);
            lblTienThua.Name = "lblTienThua";
            lblTienThua.Size = new Size(46, 20);
            lblTienThua.TabIndex = 46;
            lblTienThua.Text = "Label";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(23, 530);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 46;
            label9.Text = "Tiền Thừa";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(7, 420);
            label12.Name = "label12";
            label12.Size = new Size(95, 20);
            label12.TabIndex = 44;
            label12.Text = "Mã giảm giá";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(19, 481);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 44;
            label8.Text = "Khách đưa";
            // 
            // rbtnCash
            // 
            rbtnCash.AutoSize = true;
            rbtnCash.BackColor = Color.White;
            rbtnCash.CheckedColor = Color.Blue;
            rbtnCash.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnCash.Location = new Point(280, 363);
            rbtnCash.MinimumSize = new Size(0, 21);
            rbtnCash.Name = "rbtnCash";
            rbtnCash.Padding = new Padding(10, 0, 0, 0);
            rbtnCash.Size = new Size(86, 21);
            rbtnCash.TabIndex = 43;
            rbtnCash.TabStop = true;
            rbtnCash.Text = "Tiền mặt";
            rbtnCash.UnCheckedColor = Color.Black;
            rbtnCash.UseVisualStyleBackColor = false;
            // 
            // rbtnTransfer
            // 
            rbtnTransfer.AutoSize = true;
            rbtnTransfer.BackColor = Color.White;
            rbtnTransfer.CheckedColor = Color.Blue;
            rbtnTransfer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnTransfer.Location = new Point(138, 363);
            rbtnTransfer.MinimumSize = new Size(0, 21);
            rbtnTransfer.Name = "rbtnTransfer";
            rbtnTransfer.Padding = new Padding(10, 0, 0, 0);
            rbtnTransfer.Size = new Size(117, 21);
            rbtnTransfer.TabIndex = 42;
            rbtnTransfer.TabStop = true;
            rbtnTransfer.Text = "Chuyển khoản";
            rbtnTransfer.UnCheckedColor = Color.Black;
            rbtnTransfer.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(3, 363);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 41;
            label3.Text = "HT thanh toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(23, 258);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 36;
            label4.Text = "Ghi chú";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(11, 564);
            label11.Name = "label11";
            label11.Size = new Size(112, 25);
            label11.TabIndex = 33;
            label11.Text = "Tổng Tiền: ";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(cbbCamera);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(activeCamera);
            panel2.Controls.Add(iconButton8);
            panel2.Controls.Add(txtTimKiem);
            panel2.Controls.Add(btnDesc);
            panel2.Controls.Add(btnAsc);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(18, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(972, 140);
            panel2.TabIndex = 42;
            // 
            // cbbCamera
            // 
            cbbCamera.FormattingEnabled = true;
            cbbCamera.Location = new Point(644, 11);
            cbbCamera.Name = "cbbCamera";
            cbbCamera.Size = new Size(102, 23);
            cbbCamera.TabIndex = 50;
            // 
            // panel4
            // 
            panel4.Controls.Add(ptbCamera);
            panel4.Location = new Point(752, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(217, 132);
            panel4.TabIndex = 24;
            // 
            // ptbCamera
            // 
            ptbCamera.Location = new Point(3, 3);
            ptbCamera.Name = "ptbCamera";
            ptbCamera.Size = new Size(211, 126);
            ptbCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCamera.TabIndex = 45;
            ptbCamera.TabStop = false;
            // 
            // activeCamera
            // 
            activeCamera.BackColor = Color.MediumSlateBlue;
            activeCamera.BackgroundColor = Color.MediumSlateBlue;
            activeCamera.BorderColor = Color.PaleVioletRed;
            activeCamera.BorderRadius = 10;
            activeCamera.BorderSize = 0;
            activeCamera.FlatAppearance.BorderSize = 0;
            activeCamera.FlatStyle = FlatStyle.Flat;
            activeCamera.ForeColor = Color.White;
            activeCamera.Location = new Point(644, 45);
            activeCamera.Name = "activeCamera";
            activeCamera.Size = new Size(105, 40);
            activeCamera.TabIndex = 49;
            activeCamera.Text = "Bật camera";
            activeCamera.TextColor = Color.White;
            activeCamera.UseVisualStyleBackColor = false;
            activeCamera.Click += activeCamera_Click;
            // 
            // iconButton8
            // 
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 23;
            iconButton8.Location = new Point(12, 37);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(32, 25);
            iconButton8.TabIndex = 47;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderColor = Color.MediumSlateBlue;
            txtTimKiem.BorderFocusColor = Color.HotPink;
            txtTimKiem.BorderRadius = 10;
            txtTimKiem.BorderSize = 1;
            txtTimKiem.Location = new Point(6, 33);
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Padding = new Padding(42, 7, 7, 7);
            txtTimKiem.PasswordChar = false;
            txtTimKiem.PlaceholderColor = Color.DarkGray;
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.Size = new Size(250, 30);
            txtTimKiem.TabIndex = 46;
            txtTimKiem.Texts = "";
            txtTimKiem.UnderlinedStyle = false;
            // 
            // btnDesc
            // 
            btnDesc.BackColor = Color.White;
            btnDesc.FlatAppearance.BorderSize = 0;
            btnDesc.FlatStyle = FlatStyle.Flat;
            btnDesc.IconChar = FontAwesome.Sharp.IconChar.SortAmountDown;
            btnDesc.IconColor = Color.FromArgb(187, 92, 119);
            btnDesc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDesc.Location = new Point(471, 38);
            btnDesc.Name = "btnDesc";
            btnDesc.Size = new Size(56, 46);
            btnDesc.TabIndex = 45;
            btnDesc.UseVisualStyleBackColor = false;
            // 
            // btnAsc
            // 
            btnAsc.BackColor = Color.White;
            btnAsc.FlatAppearance.BorderSize = 0;
            btnAsc.FlatStyle = FlatStyle.Flat;
            btnAsc.IconChar = FontAwesome.Sharp.IconChar.ArrowUpShortWide;
            btnAsc.IconColor = Color.FromArgb(187, 92, 119);
            btnAsc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAsc.Location = new Point(406, 38);
            btnAsc.Name = "btnAsc";
            btnAsc.Size = new Size(59, 47);
            btnAsc.TabIndex = 44;
            btnAsc.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(6, -2);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 41;
            label2.Text = "Tìm Kiếm";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvSanPham);
            panel3.Location = new Point(18, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(975, 268);
            panel3.TabIndex = 43;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToResizeRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(1, 3);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowTemplate.Height = 25;
            dgvSanPham.Size = new Size(971, 262);
            dgvSanPham.TabIndex = 23;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            dgvSanPham.CellContentClick += dgvSanPham_CellContentClick;
            dgvSanPham.EditingControlShowing += dgvSanPham_EditingControlShowing;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvGioHang);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 437);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(975, 238);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ Hàng";
            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AllowUserToResizeColumns = false;
            dgvGioHang.AllowUserToResizeRows = false;
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Dock = DockStyle.Fill;
            dgvGioHang.Location = new Point(3, 23);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersVisible = false;
            dgvGioHang.RowHeadersWidth = 50;
            dgvGioHang.RowTemplate.Height = 25;
            dgvGioHang.Size = new Size(969, 212);
            dgvGioHang.TabIndex = 12;
            dgvGioHang.CellContentClick += dgvGioHang_CellContentClick;
            // 
            // grbCart
            // 
            grbCart.BackColor = Color.White;
            grbCart.Location = new Point(1433, 11);
            grbCart.Name = "grbCart";
            grbCart.Size = new Size(76, 664);
            grbCart.TabIndex = 44;
            grbCart.TabStop = false;
            grbCart.Text = "Đơn hàng chờ";
            // 
            // tCamera
            // 
            tCamera.Interval = 500;
            tCamera.Tick += tCamera_Tick;
            // 
            // FrmBanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(1521, 690);
            Controls.Add(groupBox2);
            Controls.Add(grbCart);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBanHang";
            Text = "Bán hàng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbCamera).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label4;
        private Label label11;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label9;
        private Label label8;
        private CustomControl.RadioButtonCustom rbtnCash;
        private CustomControl.RadioButtonCustom rbtnTransfer;
        private Label label3;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnDesc;
        private Label label2;
        private Panel panel3;
        private GroupBox groupBox2;
        private DataGridView dgvGioHang;
        private DataGridView dgvSanPham;
        private CustomControl.TextBoxCustom2_0 txtKhachDua;
        private CustomControl.TextBoxCustom2_0 txtGhiChu;
        private GroupBox grbCart;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private Label lblTienThua;
        private Label label12;
        private FontAwesome.Sharp.IconButton btnHuyHD;
        private FontAwesome.Sharp.IconButton btnSuaHD;
        private FontAwesome.Sharp.IconButton btnLuuHD;
        private FontAwesome.Sharp.IconButton iconButton8;
        private CustomControl.TextBoxCustom2_0 txtTimKiem;
        private FontAwesome.Sharp.IconButton btnAsc;
        private CustomControl.ButtonCustom activeCamera;
        private PictureBox ptbCamera;
        private Label lblTongTien;
        private Panel panel4;
        private System.Windows.Forms.Timer tCamera;
        private ComboBox cbbCamera;
        private Label label10;
        private GroupBox groupBox3;
        private Label lblHoTen;
        private Label label5;
        private ComboBox cbbSdtKH;
        private CustomControl.TextBoxCustom2_0 txtMaHD;
    }
}