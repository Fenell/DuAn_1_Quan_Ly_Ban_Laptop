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
            radioButtonCustom2 = new CustomControl.RadioButtonCustom();
            radioButtonCustom1 = new CustomControl.RadioButtonCustom();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            textBoxCustom2_05 = new CustomControl.TextBoxCustom2_0();
            label19 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            textBoxCustom2_04 = new CustomControl.TextBoxCustom2_0();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBoxCustom2_03 = new CustomControl.TextBoxCustom2_0();
            textBoxCustom2_02 = new CustomControl.TextBoxCustom2_0();
            textBoxCustom2_06 = new CustomControl.TextBoxCustom2_0();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            btnTenLaptop = new FontAwesome.Sharp.IconButton();
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
            cbbHangSanXuat = new ComboBox();
            cbbDong = new ComboBox();
            cbbNhaCungCap = new ComboBox();
            cbbCpu = new ComboBox();
            cbbVga = new ComboBox();
            cbbRam = new ComboBox();
            cbbOCung = new ComboBox();
            cbbManHinh = new ComboBox();
            cbbMauSac = new ComboBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Controls.Add(radioButtonCustom2);
            panel1.Controls.Add(radioButtonCustom1);
            panel1.Controls.Add(iconButton6);
            panel1.Controls.Add(textBoxCustom2_05);
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
            // radioButtonCustom2
            // 
            radioButtonCustom2.AutoSize = true;
            radioButtonCustom2.CheckedColor = Color.MediumSlateBlue;
            radioButtonCustom2.ForeColor = Color.FromArgb(3, 22, 73);
            radioButtonCustom2.Location = new Point(436, 29);
            radioButtonCustom2.MinimumSize = new Size(0, 21);
            radioButtonCustom2.Name = "radioButtonCustom2";
            radioButtonCustom2.Padding = new Padding(10, 0, 0, 0);
            radioButtonCustom2.Size = new Size(95, 21);
            radioButtonCustom2.TabIndex = 20;
            radioButtonCustom2.TabStop = true;
            radioButtonCustom2.Text = "Ngừng bán";
            radioButtonCustom2.UnCheckedColor = Color.FromArgb(79, 175, 156);
            radioButtonCustom2.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustom1
            // 
            radioButtonCustom1.AutoSize = true;
            radioButtonCustom1.CheckedColor = Color.MediumSlateBlue;
            radioButtonCustom1.ForeColor = Color.FromArgb(3, 22, 73);
            radioButtonCustom1.Location = new Point(326, 29);
            radioButtonCustom1.MinimumSize = new Size(0, 21);
            radioButtonCustom1.Name = "radioButtonCustom1";
            radioButtonCustom1.Padding = new Padding(10, 0, 0, 0);
            radioButtonCustom1.Size = new Size(86, 21);
            radioButtonCustom1.TabIndex = 20;
            radioButtonCustom1.TabStop = true;
            radioButtonCustom1.Text = "Đang bán";
            radioButtonCustom1.UnCheckedColor = Color.FromArgb(79, 175, 156);
            radioButtonCustom1.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton6.IconColor = Color.Black;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 20;
            iconButton6.Location = new Point(24, 27);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(30, 26);
            iconButton6.TabIndex = 19;
            iconButton6.UseVisualStyleBackColor = true;
            // 
            // textBoxCustom2_05
            // 
            textBoxCustom2_05.BackColor = Color.White;
            textBoxCustom2_05.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2_05.BorderFocusColor = Color.FromArgb(255, 128, 0);
            textBoxCustom2_05.BorderRadius = 10;
            textBoxCustom2_05.BorderSize = 1;
            textBoxCustom2_05.Location = new Point(17, 24);
            textBoxCustom2_05.Multiline = false;
            textBoxCustom2_05.Name = "textBoxCustom2_05";
            textBoxCustom2_05.Padding = new Padding(40, 7, 7, 7);
            textBoxCustom2_05.PasswordChar = false;
            textBoxCustom2_05.PlaceholderColor = Color.FromArgb(3, 22, 73);
            textBoxCustom2_05.PlaceholderText = "Tìm kiếm...";
            textBoxCustom2_05.Size = new Size(254, 30);
            textBoxCustom2_05.TabIndex = 18;
            textBoxCustom2_05.Texts = "";
            textBoxCustom2_05.UnderlinedStyle = false;
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
            panel2.Controls.Add(textBoxCustom2_04);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(iconButton5);
            panel2.Controls.Add(iconButton4);
            panel2.Controls.Add(iconButton3);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBoxCustom2_03);
            panel2.Controls.Add(textBoxCustom2_02);
            panel2.Controls.Add(textBoxCustom2_06);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1110, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 630);
            panel2.TabIndex = 1;
            // 
            // textBoxCustom2_04
            // 
            textBoxCustom2_04.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2_04.BorderFocusColor = Color.HotPink;
            textBoxCustom2_04.BorderRadius = 10;
            textBoxCustom2_04.BorderSize = 1;
            textBoxCustom2_04.Location = new Point(25, 463);
            textBoxCustom2_04.Multiline = true;
            textBoxCustom2_04.Name = "textBoxCustom2_04";
            textBoxCustom2_04.Padding = new Padding(7);
            textBoxCustom2_04.PasswordChar = false;
            textBoxCustom2_04.PlaceholderColor = Color.DarkGray;
            textBoxCustom2_04.PlaceholderText = "";
            textBoxCustom2_04.Size = new Size(319, 103);
            textBoxCustom2_04.TabIndex = 17;
            textBoxCustom2_04.Texts = "";
            textBoxCustom2_04.UnderlinedStyle = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            iconButton1.IconColor = Color.FromArgb(61, 39, 76);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 45;
            iconButton1.Location = new Point(291, 577);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(53, 37);
            iconButton1.TabIndex = 16;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.White;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconButton5.IconColor = Color.FromArgb(61, 39, 76);
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 45;
            iconButton5.Location = new Point(227, 577);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(53, 37);
            iconButton5.TabIndex = 16;
            iconButton5.UseVisualStyleBackColor = false;
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
            // iconButton3
            // 
            iconButton3.BackColor = Color.White;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Pen;
            iconButton3.IconColor = Color.FromArgb(61, 39, 76);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 45;
            iconButton3.Location = new Point(92, 577);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(53, 37);
            iconButton3.TabIndex = 14;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.White;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton2.IconColor = Color.FromArgb(61, 39, 76);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 45;
            iconButton2.Location = new Point(36, 577);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(53, 37);
            iconButton2.TabIndex = 13;
            iconButton2.UseVisualStyleBackColor = false;
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
            label6.Location = new Point(219, 367);
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
            label5.Location = new Point(20, 367);
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
            // textBoxCustom2_03
            // 
            textBoxCustom2_03.BackColor = Color.White;
            textBoxCustom2_03.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2_03.BorderFocusColor = Color.HotPink;
            textBoxCustom2_03.BorderRadius = 5;
            textBoxCustom2_03.BorderSize = 2;
            textBoxCustom2_03.Location = new Point(219, 394);
            textBoxCustom2_03.Multiline = false;
            textBoxCustom2_03.Name = "textBoxCustom2_03";
            textBoxCustom2_03.Padding = new Padding(7);
            textBoxCustom2_03.PasswordChar = false;
            textBoxCustom2_03.PlaceholderColor = Color.DarkGray;
            textBoxCustom2_03.PlaceholderText = "";
            textBoxCustom2_03.Size = new Size(122, 30);
            textBoxCustom2_03.TabIndex = 6;
            textBoxCustom2_03.Texts = "";
            textBoxCustom2_03.UnderlinedStyle = true;
            // 
            // textBoxCustom2_02
            // 
            textBoxCustom2_02.BackColor = Color.White;
            textBoxCustom2_02.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2_02.BorderFocusColor = Color.HotPink;
            textBoxCustom2_02.BorderRadius = 5;
            textBoxCustom2_02.BorderSize = 2;
            textBoxCustom2_02.Location = new Point(20, 394);
            textBoxCustom2_02.Multiline = false;
            textBoxCustom2_02.Name = "textBoxCustom2_02";
            textBoxCustom2_02.Padding = new Padding(7);
            textBoxCustom2_02.PasswordChar = false;
            textBoxCustom2_02.PlaceholderColor = Color.DarkGray;
            textBoxCustom2_02.PlaceholderText = "";
            textBoxCustom2_02.Size = new Size(122, 30);
            textBoxCustom2_02.TabIndex = 5;
            textBoxCustom2_02.Texts = "";
            textBoxCustom2_02.UnderlinedStyle = true;
            // 
            // textBoxCustom2_06
            // 
            textBoxCustom2_06.BackColor = Color.White;
            textBoxCustom2_06.BorderColor = Color.CornflowerBlue;
            textBoxCustom2_06.BorderFocusColor = Color.HotPink;
            textBoxCustom2_06.BorderRadius = 5;
            textBoxCustom2_06.BorderSize = 2;
            textBoxCustom2_06.Location = new Point(112, 302);
            textBoxCustom2_06.Multiline = false;
            textBoxCustom2_06.Name = "textBoxCustom2_06";
            textBoxCustom2_06.Padding = new Padding(7);
            textBoxCustom2_06.PasswordChar = false;
            textBoxCustom2_06.PlaceholderColor = Color.DarkGray;
            textBoxCustom2_06.PlaceholderText = "";
            textBoxCustom2_06.Size = new Size(208, 30);
            textBoxCustom2_06.TabIndex = 4;
            textBoxCustom2_06.Texts = "";
            textBoxCustom2_06.UnderlinedStyle = true;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(3, 22, 73);
            label1.Location = new Point(36, 311);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 1;
            label1.Text = "Imei";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(112, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 198);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(12, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(1078, 286);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1078, 286);
            dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(cbbMauSac);
            panel4.Controls.Add(cbbManHinh);
            panel4.Controls.Add(cbbOCung);
            panel4.Controls.Add(cbbRam);
            panel4.Controls.Add(cbbVga);
            panel4.Controls.Add(cbbCpu);
            panel4.Controls.Add(cbbNhaCungCap);
            panel4.Controls.Add(cbbDong);
            panel4.Controls.Add(cbbHangSanXuat);
            panel4.Controls.Add(btnTenLaptop);
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
            // btnTenLaptop
            // 
            btnTenLaptop.BackColor = Color.FromArgb(86, 103, 204);
            btnTenLaptop.FlatStyle = FlatStyle.Flat;
            btnTenLaptop.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnTenLaptop.IconColor = Color.Black;
            btnTenLaptop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTenLaptop.IconSize = 28;
            btnTenLaptop.Location = new Point(915, 182);
            btnTenLaptop.Name = "btnTenLaptop";
            btnTenLaptop.Padding = new Padding(0, 4, 0, 0);
            btnTenLaptop.Size = new Size(150, 36);
            btnTenLaptop.TabIndex = 20;
            btnTenLaptop.UseVisualStyleBackColor = false;
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
            label18.Size = new Size(81, 20);
            label18.TabIndex = 17;
            label18.Text = "Tên laptop";
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
            // cbbHangSanXuat
            // 
            cbbHangSanXuat.FormattingEnabled = true;
            cbbHangSanXuat.Location = new Point(17, 35);
            cbbHangSanXuat.Name = "cbbHangSanXuat";
            cbbHangSanXuat.Size = new Size(150, 23);
            cbbHangSanXuat.TabIndex = 22;
            // 
            // cbbDong
            // 
            cbbDong.FormattingEnabled = true;
            cbbDong.Location = new Point(235, 35);
            cbbDong.Name = "cbbDong";
            cbbDong.Size = new Size(150, 23);
            cbbDong.TabIndex = 23;
            // 
            // cbbNhaCungCap
            // 
            cbbNhaCungCap.FormattingEnabled = true;
            cbbNhaCungCap.Location = new Point(456, 35);
            cbbNhaCungCap.Name = "cbbNhaCungCap";
            cbbNhaCungCap.Size = new Size(150, 23);
            cbbNhaCungCap.TabIndex = 24;
            // 
            // cbbCpu
            // 
            cbbCpu.FormattingEnabled = true;
            cbbCpu.Location = new Point(699, 35);
            cbbCpu.Name = "cbbCpu";
            cbbCpu.Size = new Size(150, 23);
            cbbCpu.TabIndex = 25;
            // 
            // cbbVga
            // 
            cbbVga.FormattingEnabled = true;
            cbbVga.Location = new Point(915, 35);
            cbbVga.Name = "cbbVga";
            cbbVga.Size = new Size(150, 23);
            cbbVga.TabIndex = 26;
            // 
            // cbbRam
            // 
            cbbRam.FormattingEnabled = true;
            cbbRam.Location = new Point(17, 149);
            cbbRam.Name = "cbbRam";
            cbbRam.Size = new Size(150, 23);
            cbbRam.TabIndex = 27;
            // 
            // cbbOCung
            // 
            cbbOCung.FormattingEnabled = true;
            cbbOCung.Location = new Point(235, 149);
            cbbOCung.Name = "cbbOCung";
            cbbOCung.Size = new Size(150, 23);
            cbbOCung.TabIndex = 28;
            // 
            // cbbManHinh
            // 
            cbbManHinh.FormattingEnabled = true;
            cbbManHinh.Location = new Point(456, 149);
            cbbManHinh.Name = "cbbManHinh";
            cbbManHinh.Size = new Size(150, 23);
            cbbManHinh.TabIndex = 29;
            // 
            // cbbMauSac
            // 
            cbbMauSac.FormattingEnabled = true;
            cbbMauSac.Location = new Point(699, 149);
            cbbMauSac.Name = "cbbMauSac";
            cbbMauSac.Size = new Size(150, 23);
            cbbMauSac.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(915, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 31;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private CustomControl.TextBoxCustom2_0 textBoxCustom2_03;
        private CustomControl.TextBoxCustom2_0 textBoxCustom2_02;
        private Label label3;
        private Label label9;
        private Panel panel5;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton iconButton6;
        private CustomControl.TextBoxCustom2_0 textBoxCustom2_05;
        private CustomControl.RadioButtonCustom radioButtonCustom2;
        private CustomControl.RadioButtonCustom radioButtonCustom1;
        private DataGridView dataGridView1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnHangSanXuat;
        private Label label14;
        private FontAwesome.Sharp.IconButton btnTenLaptop;
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
        private CustomControl.TextBoxCustom2_0 textBoxCustom2_06;
        private CustomControl.TextBoxCustom2_0 textBoxCustom2_04;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox1;
        private ComboBox cbbMauSac;
        private ComboBox cbbManHinh;
        private ComboBox cbbOCung;
        private ComboBox cbbRam;
        private ComboBox cbbVga;
        private ComboBox cbbCpu;
        private ComboBox cbbNhaCungCap;
        private ComboBox cbbDong;
        private ComboBox cbbHangSanXuat;
    }
}