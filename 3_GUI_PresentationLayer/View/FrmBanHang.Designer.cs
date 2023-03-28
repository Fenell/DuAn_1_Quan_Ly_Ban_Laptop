namespace _3_GUI_PresentationLayer.View
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
            btnRefresh = new FontAwesome.Sharp.IconButton();
            txtDiaChi = new CustomControl.TextBoxCustom2_0();
            panel5 = new Panel();
            rbtnShip = new CustomControl.RadioButtonCustom();
            rbtnTrucTiep = new CustomControl.RadioButtonCustom();
            label1 = new Label();
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
            txtGhiChu = new CustomControl.TextBoxCustom2_0();
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
            tCamera = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            dgcDHCho = new DataGridView();
            menuStrip = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbCamera).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgcDHCho).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaHD);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(lblTongTien);
            panel1.Controls.Add(btnHuyHD);
            panel1.Controls.Add(btnSuaHD);
            panel1.Controls.Add(btnLuuHD);
            panel1.Controls.Add(btnThanhToan);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(rbtnCash);
            panel1.Controls.Add(rbtnTransfer);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(1052, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 661);
            panel1.TabIndex = 19;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnRefresh.IconColor = Color.FromArgb(148, 105, 215);
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 45;
            btnRefresh.Location = new Point(372, 608);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(53, 37);
            btnRefresh.TabIndex = 56;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderColor = Color.MediumSlateBlue;
            txtDiaChi.BorderFocusColor = Color.HotPink;
            txtDiaChi.BorderRadius = 10;
            txtDiaChi.BorderSize = 1;
            txtDiaChi.Location = new Point(177, 237);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Padding = new Padding(7);
            txtDiaChi.PasswordChar = false;
            txtDiaChi.PlaceholderColor = Color.DarkGray;
            txtDiaChi.PlaceholderText = "";
            txtDiaChi.Size = new Size(241, 86);
            txtDiaChi.TabIndex = 55;
            txtDiaChi.Texts = "";
            txtDiaChi.UnderlinedStyle = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(rbtnShip);
            panel5.Controls.Add(rbtnTrucTiep);
            panel5.Location = new Point(177, 177);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 47);
            panel5.TabIndex = 54;
            // 
            // rbtnShip
            // 
            rbtnShip.AutoSize = true;
            rbtnShip.CheckedColor = Color.MediumSlateBlue;
            rbtnShip.Location = new Point(155, 18);
            rbtnShip.MinimumSize = new Size(0, 21);
            rbtnShip.Name = "rbtnShip";
            rbtnShip.Padding = new Padding(10, 0, 0, 0);
            rbtnShip.Size = new Size(73, 21);
            rbtnShip.TabIndex = 1;
            rbtnShip.TabStop = true;
            rbtnShip.Text = "Tại nhà";
            rbtnShip.UnCheckedColor = Color.Gray;
            rbtnShip.UseVisualStyleBackColor = true;
            rbtnShip.CheckedChanged += rbtnShip_CheckedChanged;
            // 
            // rbtnTrucTiep
            // 
            rbtnTrucTiep.AutoSize = true;
            rbtnTrucTiep.CheckedColor = Color.MediumSlateBlue;
            rbtnTrucTiep.Location = new Point(13, 18);
            rbtnTrucTiep.MinimumSize = new Size(0, 21);
            rbtnTrucTiep.Name = "rbtnTrucTiep";
            rbtnTrucTiep.Padding = new Padding(10, 0, 0, 0);
            rbtnTrucTiep.Size = new Size(102, 21);
            rbtnTrucTiep.TabIndex = 0;
            rbtnTrucTiep.TabStop = true;
            rbtnTrucTiep.Text = "Tại cửa hàng";
            rbtnTrucTiep.UnCheckedColor = Color.Gray;
            rbtnTrucTiep.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(4, 204);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 53;
            label1.Text = "Địa chỉ  nhận hàng";
            // 
            // txtMaHD
            // 
            txtMaHD.BorderColor = Color.MediumSlateBlue;
            txtMaHD.BorderFocusColor = Color.HotPink;
            txtMaHD.BorderRadius = 0;
            txtMaHD.BorderSize = 2;
            txtMaHD.Location = new Point(177, 126);
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
            label10.Location = new Point(41, 136);
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
            groupBox3.Size = new Size(420, 100);
            groupBox3.TabIndex = 51;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách hàng";
            // 
            // cbbSdtKH
            // 
            cbbSdtKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbSdtKH.FormattingEnabled = true;
            cbbSdtKH.Location = new Point(157, 27);
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
            lblHoTen.Location = new Point(157, 63);
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
            label5.Location = new Point(75, 63);
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
            label6.Location = new Point(31, 30);
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
            iconButton3.Location = new Point(361, 14);
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
            lblTongTien.Location = new Point(177, 518);
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
            btnHuyHD.Location = new Point(292, 599);
            btnHuyHD.Name = "btnHuyHD";
            btnHuyHD.Size = new Size(63, 55);
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
            btnSuaHD.Location = new Point(212, 599);
            btnSuaHD.Name = "btnSuaHD";
            btnSuaHD.Size = new Size(63, 55);
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
            btnLuuHD.Location = new Point(116, 599);
            btnLuuHD.Name = "btnLuuHD";
            btnLuuHD.Size = new Size(67, 55);
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
            btnThanhToan.Location = new Point(42, 599);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(68, 55);
            btnThanhToan.TabIndex = 49;
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.BorderColor = Color.MediumSlateBlue;
            txtGhiChu.BorderFocusColor = Color.HotPink;
            txtGhiChu.BorderRadius = 10;
            txtGhiChu.BorderSize = 1;
            txtGhiChu.Location = new Point(178, 385);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Padding = new Padding(7);
            txtGhiChu.PasswordChar = false;
            txtGhiChu.PlaceholderColor = Color.DarkGray;
            txtGhiChu.PlaceholderText = "";
            txtGhiChu.Size = new Size(241, 97);
            txtGhiChu.TabIndex = 47;
            txtGhiChu.Texts = "";
            txtGhiChu.UnderlinedStyle = false;
            // 
            // rbtnCash
            // 
            rbtnCash.AutoSize = true;
            rbtnCash.BackColor = Color.White;
            rbtnCash.CheckedColor = Color.Blue;
            rbtnCash.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnCash.Location = new Point(319, 340);
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
            rbtnTransfer.Location = new Point(177, 340);
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
            label3.Location = new Point(23, 341);
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
            label4.Location = new Point(62, 394);
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
            label11.Location = new Point(30, 518);
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
            panel2.Size = new Size(1000, 140);
            panel2.TabIndex = 42;
            // 
            // cbbCamera
            // 
            cbbCamera.FormattingEnabled = true;
            cbbCamera.Location = new Point(661, 6);
            cbbCamera.Name = "cbbCamera";
            cbbCamera.Size = new Size(102, 23);
            cbbCamera.TabIndex = 50;
            // 
            // panel4
            // 
            panel4.Controls.Add(ptbCamera);
            panel4.Location = new Point(769, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 132);
            panel4.TabIndex = 24;
            // 
            // ptbCamera
            // 
            ptbCamera.Location = new Point(3, 3);
            ptbCamera.Name = "ptbCamera";
            ptbCamera.Size = new Size(222, 126);
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
            activeCamera.Location = new Point(658, 37);
            activeCamera.Name = "activeCamera";
            activeCamera.Size = new Size(105, 36);
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
            panel3.Size = new Size(1000, 268);
            panel3.TabIndex = 43;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToResizeRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(1, 3);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowTemplate.Height = 25;
            dgvSanPham.Size = new Size(993, 262);
            dgvSanPham.TabIndex = 23;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            dgvSanPham.CellContentClick += dgvSanPham_CellContentClick;
            dgvSanPham.EditingControlShowing += dgvSanPham_EditingControlShowing;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvGioHang);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 452);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(702, 223);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ Hàng";
            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AllowUserToResizeRows = false;
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Dock = DockStyle.Fill;
            dgvGioHang.Location = new Point(3, 23);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersVisible = false;
            dgvGioHang.RowHeadersWidth = 50;
            dgvGioHang.RowTemplate.Height = 25;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGioHang.Size = new Size(696, 197);
            dgvGioHang.TabIndex = 12;
            dgvGioHang.CellContentClick += dgvGioHang_CellContentClick;
            dgvGioHang.CellMouseUp += dgvGioHang_CellMouseUp;
            // 
            // tCamera
            // 
            tCamera.Interval = 500;
            tCamera.Tick += tCamera_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgcDHCho);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(728, 452);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 226);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đơn hàng chờ";
            // 
            // dgcDHCho
            // 
            dgcDHCho.AllowUserToAddRows = false;
            dgcDHCho.AllowUserToDeleteRows = false;
            dgcDHCho.AllowUserToResizeRows = false;
            dgcDHCho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgcDHCho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgcDHCho.Dock = DockStyle.Fill;
            dgcDHCho.Location = new Point(3, 21);
            dgcDHCho.Name = "dgcDHCho";
            dgcDHCho.RowHeadersVisible = false;
            dgcDHCho.RowTemplate.Height = 25;
            dgcDHCho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgcDHCho.Size = new Size(284, 202);
            dgcDHCho.TabIndex = 0;
            dgcDHCho.CellClick += dgcDHCho_CellClick;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(173, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(172, 22);
            toolStripMenuItem1.Text = "Chọn mã giảm giá";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Location = new Point(1422, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(87, 667);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // FrmBanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(1521, 690);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBanHang";
            Text = "Bán hàng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgcDHCho).EndInit();
            menuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label4;
        private Label label11;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton3;
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
        private CustomControl.TextBoxCustom2_0 txtGhiChu;
        private FontAwesome.Sharp.IconButton btnThanhToan;
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
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgcDHCho;
        private CustomControl.TextBoxCustom2_0 txtDiaChi;
        private Panel panel5;
        private CustomControl.RadioButtonCustom rbtnShip;
        private CustomControl.RadioButtonCustom rbtnTrucTiep;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private ContextMenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}