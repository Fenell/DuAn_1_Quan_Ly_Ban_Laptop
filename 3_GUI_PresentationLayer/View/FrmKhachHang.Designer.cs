namespace _3_GUI_PresentationLayer.View
{
    partial class FrmKhachHang
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonClear = new FontAwesome.Sharp.IconButton();
            this.txtDiaChi = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom2_0();
            this.iconButtonSua = new FontAwesome.Sharp.IconButton();
            this.iconButtonThem = new FontAwesome.Sharp.IconButton();
            this.rbtNu = new _3_GUI_PresentationLayer.CustomControl.RadioButtonCustom();
            this.txtMa = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom();
            this.rbtNam = new _3_GUI_PresentationLayer.CustomControl.RadioButtonCustom();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom2_0();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvKhachHang.Location = new System.Drawing.Point(3, 3);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowTemplate.Height = 25;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(992, 494);
            this.dgvKhachHang.TabIndex = 8;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconButtonClear);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.iconButtonSua);
            this.panel1.Controls.Add(this.iconButtonThem);
            this.panel1.Controls.Add(this.rbtNu);
            this.panel1.Controls.Add(this.txtMa);
            this.panel1.Controls.Add(this.rbtNam);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSoDienThoai);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(1063, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 624);
            this.panel1.TabIndex = 9;
            // 
            // iconButtonClear
            // 
            this.iconButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(220)))), ((int)(((byte)(204)))));
            this.iconButtonClear.FlatAppearance.BorderSize = 0;
            this.iconButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClear.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.iconButtonClear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.iconButtonClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClear.IconSize = 45;
            this.iconButtonClear.Location = new System.Drawing.Point(286, 533);
            this.iconButtonClear.Name = "iconButtonClear";
            this.iconButtonClear.Size = new System.Drawing.Size(97, 43);
            this.iconButtonClear.TabIndex = 53;
            this.iconButtonClear.UseVisualStyleBackColor = false;
            this.iconButtonClear.Click += new System.EventHandler(this.iconButtonClear_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiaChi.BorderRadius = 10;
            this.txtDiaChi.BorderSize = 1;
            this.txtDiaChi.Location = new System.Drawing.Point(154, 360);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(7);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(229, 132);
            this.txtDiaChi.TabIndex = 44;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // iconButtonSua
            // 
            this.iconButtonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(220)))), ((int)(((byte)(204)))));
            this.iconButtonSua.FlatAppearance.BorderSize = 0;
            this.iconButtonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSua.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconButtonSua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.iconButtonSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSua.IconSize = 40;
            this.iconButtonSua.Location = new System.Drawing.Point(154, 533);
            this.iconButtonSua.Name = "iconButtonSua";
            this.iconButtonSua.Size = new System.Drawing.Size(97, 43);
            this.iconButtonSua.TabIndex = 43;
            this.iconButtonSua.UseVisualStyleBackColor = false;
            this.iconButtonSua.Click += new System.EventHandler(this.iconButtonSua_Click);
            // 
            // iconButtonThem
            // 
            this.iconButtonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(220)))), ((int)(((byte)(204)))));
            this.iconButtonThem.FlatAppearance.BorderSize = 0;
            this.iconButtonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThem.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButtonThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.iconButtonThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThem.IconSize = 40;
            this.iconButtonThem.Location = new System.Drawing.Point(18, 533);
            this.iconButtonThem.Name = "iconButtonThem";
            this.iconButtonThem.Size = new System.Drawing.Size(97, 43);
            this.iconButtonThem.TabIndex = 42;
            this.iconButtonThem.UseVisualStyleBackColor = false;
            this.iconButtonThem.Click += new System.EventHandler(this.iconButtonThem_Click);
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtNu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtNu.Location = new System.Drawing.Point(303, 278);
            this.rbtNu.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtNu.Size = new System.Drawing.Size(62, 25);
            this.rbtNu.TabIndex = 41;
            this.rbtNu.TabStop = true;
            this.rbtNu.Text = "Nữ";
            this.rbtNu.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtNu.UseVisualStyleBackColor = true;
            // 
            // txtMa
            // 
            this.txtMa.BackColor = System.Drawing.Color.White;
            this.txtMa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMa.BorderSize = 2;
            this.txtMa.Location = new System.Drawing.Point(154, 25);
            this.txtMa.Multiline = false;
            this.txtMa.Name = "txtMa";
            this.txtMa.Padding = new System.Windows.Forms.Padding(7);
            this.txtMa.PasswordChar = false;
            this.txtMa.Size = new System.Drawing.Size(229, 30);
            this.txtMa.TabIndex = 29;
            this.txtMa.Texts = "";
            this.txtMa.UnderlinedStyle = true;
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtNam.Location = new System.Drawing.Point(160, 278);
            this.rbtNam.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtNam.Size = new System.Drawing.Size(75, 25);
            this.rbtNam.TabIndex = 40;
            this.rbtNam.TabStop = true;
            this.rbtNam.Text = "Nam";
            this.rbtNam.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtNam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mã khách hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(53, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 21);
            this.label12.TabIndex = 39;
            this.label12.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(68, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHoTen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHoTen.BorderSize = 2;
            this.txtHoTen.Location = new System.Drawing.Point(154, 99);
            this.txtHoTen.Multiline = false;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(7);
            this.txtHoTen.PasswordChar = false;
            this.txtHoTen.Size = new System.Drawing.Size(229, 30);
            this.txtHoTen.TabIndex = 31;
            this.txtHoTen.Texts = "";
            this.txtHoTen.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(18, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Số điện thoại";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BackColor = System.Drawing.Color.White;
            this.txtSoDienThoai.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoDienThoai.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoDienThoai.BorderSize = 2;
            this.txtSoDienThoai.Location = new System.Drawing.Point(154, 182);
            this.txtSoDienThoai.Multiline = false;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoDienThoai.PasswordChar = false;
            this.txtSoDienThoai.Size = new System.Drawing.Size(229, 30);
            this.txtSoDienThoai.TabIndex = 33;
            this.txtSoDienThoai.Texts = "";
            this.txtSoDienThoai.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(64, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "Địa Chỉ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvKhachHang);
            this.panel2.Location = new System.Drawing.Point(26, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 500);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconButton8);
            this.panel3.Controls.Add(this.txtTimKiem);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(29, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 87);
            this.panel3.TabIndex = 11;
            // 
            // iconButton8
            // 
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 23;
            this.iconButton8.Location = new System.Drawing.Point(21, 44);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(32, 25);
            this.iconButton8.TabIndex = 51;
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTimKiem.BorderRadius = 10;
            this.txtTimKiem.BorderSize = 1;
            this.txtTimKiem.Location = new System.Drawing.Point(15, 40);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(42, 7, 7, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 30);
            this.txtTimKiem.TabIndex = 50;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            this.txtTimKiem._TextChanged += new System.EventHandler(this.txtTimKiem__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tìm kiếm";
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1521, 690);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgvKhachHang;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonSua;
        private FontAwesome.Sharp.IconButton iconButtonThem;
        private CustomControl.RadioButtonCustom rbtNu;
        private CustomControl.TextBoxCustom txtMa;
        private CustomControl.RadioButtonCustom rbtNam;
        private Label label3;
        private Label label12;
        private Label label4;
        private CustomControl.TextBoxCustom txtHoTen;
        private Label label5;
        private CustomControl.TextBoxCustom txtSoDienThoai;
        private Label label6;
        private Panel panel2;
        private CustomControl.TextBoxCustom2_0 txtDiaChi;
        private Panel panel3;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton8;
        private CustomControl.TextBoxCustom2_0 txtTimKiem;
        private FontAwesome.Sharp.IconButton iconButtonClear;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}