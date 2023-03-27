﻿namespace _3_GUI_PresentationLayer.View
{
    partial class FrmDongLaptop
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
            dgvDong = new DataGridView();
            panel2 = new Panel();
            btnLamMoi = new FontAwesome.Sharp.IconButton();
            btnSua = new FontAwesome.Sharp.IconButton();
            btnThem = new FontAwesome.Sharp.IconButton();
            txtDong = new CustomControl.TextBoxCustom2_0();
            lbMa = new Label();
            label2 = new Label();
            label1 = new Label();
            cbbHang = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDong).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDong
            // 
            dgvDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDong.Location = new Point(12, 12);
            dgvDong.Name = "dgvDong";
            dgvDong.RowHeadersVisible = false;
            dgvDong.RowTemplate.Height = 25;
            dgvDong.Size = new Size(265, 232);
            dgvDong.TabIndex = 4;
            dgvDong.CellClick += dgvDong_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(cbbHang);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtDong);
            panel2.Controls.Add(lbMa);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(292, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 232);
            panel2.TabIndex = 5;
            // 
            // btnLamMoi
            // 
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnLamMoi.IconColor = Color.FromArgb(61, 39, 76);
            btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLamMoi.IconSize = 45;
            btnLamMoi.Location = new Point(171, 177);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(53, 37);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnSua.IconColor = Color.FromArgb(61, 39, 76);
            btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSua.IconSize = 45;
            btnSua.Location = new Point(86, 177);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(53, 37);
            btnSua.TabIndex = 18;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnThem.IconColor = Color.FromArgb(61, 39, 76);
            btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThem.IconSize = 45;
            btnThem.Location = new Point(7, 177);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(53, 37);
            btnThem.TabIndex = 17;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDong
            // 
            txtDong.BorderColor = Color.MediumSlateBlue;
            txtDong.BorderFocusColor = Color.HotPink;
            txtDong.BorderRadius = 10;
            txtDong.BorderSize = 1;
            txtDong.Location = new Point(13, 112);
            txtDong.Multiline = false;
            txtDong.Name = "txtDong";
            txtDong.Padding = new Padding(7);
            txtDong.PasswordChar = false;
            txtDong.PlaceholderColor = Color.DarkGray;
            txtDong.PlaceholderText = "";
            txtDong.Size = new Size(211, 30);
            txtDong.TabIndex = 1;
            txtDong.Texts = "";
            txtDong.UnderlinedStyle = false;
            // 
            // lbMa
            // 
            lbMa.AutoSize = true;
            lbMa.BackColor = Color.White;
            lbMa.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbMa.Location = new Point(66, 13);
            lbMa.Name = "lbMa";
            lbMa.Size = new Size(40, 20);
            lbMa.TabIndex = 0;
            lbMa.Text = "1234";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 13);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 72);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Dòng Laptop";
            // 
            // cbbHang
            // 
            cbbHang.FormattingEnabled = true;
            cbbHang.Location = new Point(66, 46);
            cbbHang.Name = "cbbHang";
            cbbHang.Size = new Size(121, 23);
            cbbHang.TabIndex = 20;
            // 
            // FrmDongLaptop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 248);
            Controls.Add(dgvDong);
            Controls.Add(panel2);
            Name = "FrmDongLaptop";
            Text = "FrmDongLaptop";
            ((System.ComponentModel.ISupportInitialize)dgvDong).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDong;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private CustomControl.TextBoxCustom2_0 txtDong;
        private Label lbMa;
        private Label label2;
        private Label label1;
        private ComboBox cbbHang;
    }
}