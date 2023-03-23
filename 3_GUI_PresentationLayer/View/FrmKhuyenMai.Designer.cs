namespace _3_GUI_PresentationLayer.View
{
    partial class FrmKhuyenMai
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBoxCustom2_01 = new CustomControl.TextBoxCustom2_0();
            radioButtonCustom2 = new CustomControl.RadioButtonCustom();
            radioButtonCustom1 = new CustomControl.RadioButtonCustom();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            buttonCustom2 = new CustomControl.ButtonCustom();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            textBoxCustom2_04 = new CustomControl.TextBoxCustom2_0();
            buttonCustom1 = new CustomControl.ButtonCustom();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            dataGridView2 = new DataGridView();
            comboBoxCustom4 = new CustomControl.ComboBoxCustom();
            label3 = new Label();
            comboBoxCustom2 = new CustomControl.ComboBoxCustom();
            comboBoxCustom3 = new CustomControl.ComboBoxCustom();
            dateTimePickerCustom2 = new CustomControl.DateTimePickerCustom();
            dateTimePickerCustom1 = new CustomControl.DateTimePickerCustom();
            label10 = new Label();
            textBoxCustom3 = new CustomControl.TextBoxCustom();
            textBoxCustom1 = new CustomControl.TextBoxCustom();
            textBoxCustom2 = new CustomControl.TextBoxCustom();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(textBoxCustom2_01);
            panel1.Controls.Add(radioButtonCustom2);
            panel1.Controls.Add(radioButtonCustom1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 93);
            panel1.TabIndex = 3;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 23;
            iconButton1.Location = new Point(34, 38);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(32, 25);
            iconButton1.TabIndex = 54;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // textBoxCustom2_01
            // 
            textBoxCustom2_01.BackColor = Color.White;
            textBoxCustom2_01.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2_01.BorderFocusColor = Color.HotPink;
            textBoxCustom2_01.BorderRadius = 10;
            textBoxCustom2_01.BorderSize = 1;
            textBoxCustom2_01.Location = new Point(28, 34);
            textBoxCustom2_01.Multiline = false;
            textBoxCustom2_01.Name = "textBoxCustom2_01";
            textBoxCustom2_01.Padding = new Padding(42, 7, 7, 7);
            textBoxCustom2_01.PasswordChar = false;
            textBoxCustom2_01.PlaceholderColor = Color.DarkGray;
            textBoxCustom2_01.PlaceholderText = "Tìm kiếm";
            textBoxCustom2_01.Size = new Size(247, 30);
            textBoxCustom2_01.TabIndex = 53;
            textBoxCustom2_01.Texts = "";
            textBoxCustom2_01.UnderlinedStyle = false;
            // 
            // radioButtonCustom2
            // 
            radioButtonCustom2.AutoSize = true;
            radioButtonCustom2.CheckedColor = Color.MediumSlateBlue;
            radioButtonCustom2.Location = new Point(526, 43);
            radioButtonCustom2.MinimumSize = new Size(0, 21);
            radioButtonCustom2.Name = "radioButtonCustom2";
            radioButtonCustom2.Padding = new Padding(10, 0, 0, 0);
            radioButtonCustom2.Size = new Size(128, 21);
            radioButtonCustom2.TabIndex = 52;
            radioButtonCustom2.TabStop = true;
            radioButtonCustom2.Text = "Đang khuyến mại";
            radioButtonCustom2.UnCheckedColor = Color.Gray;
            radioButtonCustom2.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustom1
            // 
            radioButtonCustom1.AutoSize = true;
            radioButtonCustom1.CheckedColor = Color.MediumSlateBlue;
            radioButtonCustom1.Location = new Point(702, 43);
            radioButtonCustom1.MinimumSize = new Size(0, 21);
            radioButtonCustom1.Name = "radioButtonCustom1";
            radioButtonCustom1.Padding = new Padding(10, 0, 0, 0);
            radioButtonCustom1.Size = new Size(119, 21);
            radioButtonCustom1.TabIndex = 52;
            radioButtonCustom1.TabStop = true;
            radioButtonCustom1.Text = "Sắp khuyến mại";
            radioButtonCustom1.UnCheckedColor = Color.Gray;
            radioButtonCustom1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(512, 4);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Trạng Thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(23, 5);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "Tìm Kiếm";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(957, 291);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(iconButton5);
            panel2.Controls.Add(buttonCustom2);
            panel2.Controls.Add(iconButton8);
            panel2.Controls.Add(textBoxCustom2_04);
            panel2.Controls.Add(buttonCustom1);
            panel2.Controls.Add(iconButton3);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(comboBoxCustom4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBoxCustom2);
            panel2.Controls.Add(comboBoxCustom3);
            panel2.Controls.Add(dateTimePickerCustom2);
            panel2.Controls.Add(dateTimePickerCustom1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBoxCustom3);
            panel2.Controls.Add(textBoxCustom1);
            panel2.Controls.Add(textBoxCustom2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(996, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 639);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.FromArgb(254, 197, 230);
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 45;
            iconButton5.Location = new Point(343, 589);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(91, 37);
            iconButton5.TabIndex = 52;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // buttonCustom2
            // 
            buttonCustom2.BackColor = Color.MediumSlateBlue;
            buttonCustom2.BackgroundColor = Color.MediumSlateBlue;
            buttonCustom2.BorderColor = Color.PaleVioletRed;
            buttonCustom2.BorderRadius = 10;
            buttonCustom2.BorderSize = 0;
            buttonCustom2.FlatAppearance.BorderSize = 0;
            buttonCustom2.FlatStyle = FlatStyle.Flat;
            buttonCustom2.ForeColor = Color.White;
            buttonCustom2.Location = new Point(136, 379);
            buttonCustom2.Name = "buttonCustom2";
            buttonCustom2.Size = new Size(121, 32);
            buttonCustom2.TabIndex = 23;
            buttonCustom2.Text = "Chọn lại";
            buttonCustom2.TextColor = Color.White;
            buttonCustom2.UseVisualStyleBackColor = false;
            // 
            // iconButton8
            // 
            iconButton8.BackColor = Color.White;
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 23;
            iconButton8.Location = new Point(283, 386);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(32, 25);
            iconButton8.TabIndex = 51;
            iconButton8.UseVisualStyleBackColor = false;
            // 
            // textBoxCustom2_04
            // 
            textBoxCustom2_04.BackColor = Color.White;
            textBoxCustom2_04.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2_04.BorderFocusColor = Color.HotPink;
            textBoxCustom2_04.BorderRadius = 10;
            textBoxCustom2_04.BorderSize = 1;
            textBoxCustom2_04.Location = new Point(277, 382);
            textBoxCustom2_04.Multiline = false;
            textBoxCustom2_04.Name = "textBoxCustom2_04";
            textBoxCustom2_04.Padding = new Padding(42, 7, 7, 7);
            textBoxCustom2_04.PasswordChar = false;
            textBoxCustom2_04.PlaceholderColor = Color.DarkGray;
            textBoxCustom2_04.PlaceholderText = "Tìm kiếm";
            textBoxCustom2_04.Size = new Size(186, 30);
            textBoxCustom2_04.TabIndex = 50;
            textBoxCustom2_04.Texts = "";
            textBoxCustom2_04.UnderlinedStyle = false;
            // 
            // buttonCustom1
            // 
            buttonCustom1.BackColor = Color.MediumSlateBlue;
            buttonCustom1.BackgroundColor = Color.MediumSlateBlue;
            buttonCustom1.BorderColor = Color.PaleVioletRed;
            buttonCustom1.BorderRadius = 10;
            buttonCustom1.BorderSize = 0;
            buttonCustom1.FlatAppearance.BorderSize = 0;
            buttonCustom1.FlatStyle = FlatStyle.Flat;
            buttonCustom1.ForeColor = Color.White;
            buttonCustom1.Location = new Point(17, 379);
            buttonCustom1.Name = "buttonCustom1";
            buttonCustom1.Size = new Size(113, 32);
            buttonCustom1.TabIndex = 23;
            buttonCustom1.Text = "Chọn tất cả";
            buttonCustom1.TextColor = Color.White;
            buttonCustom1.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(254, 197, 230);
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 37;
            iconButton3.Location = new Point(226, 589);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(89, 36);
            iconButton3.TabIndex = 22;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(254, 197, 230);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 37;
            iconButton2.Location = new Point(104, 589);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(82, 36);
            iconButton2.TabIndex = 21;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(17, 423);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(454, 159);
            dataGridView2.TabIndex = 20;
            // 
            // comboBoxCustom4
            // 
            comboBoxCustom4.BackColor = Color.White;
            comboBoxCustom4.BorderColor = Color.MediumSlateBlue;
            comboBoxCustom4.BorderSize = 1;
            comboBoxCustom4.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxCustom4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCustom4.ForeColor = Color.DimGray;
            comboBoxCustom4.IconColor = Color.MediumSlateBlue;
            comboBoxCustom4.ListBackColor = Color.FromArgb(230, 228, 245);
            comboBoxCustom4.ListTextColor = Color.DimGray;
            comboBoxCustom4.Location = new Point(183, 330);
            comboBoxCustom4.MinimumSize = new Size(200, 30);
            comboBoxCustom4.Name = "comboBoxCustom4";
            comboBoxCustom4.Padding = new Padding(1);
            comboBoxCustom4.Size = new Size(280, 30);
            comboBoxCustom4.TabIndex = 18;
            comboBoxCustom4.Texts = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(25, 118);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 5;
            label3.Text = "Loại Khuyến Mãi";
            label3.Click += label3_Click;
            // 
            // comboBoxCustom2
            // 
            comboBoxCustom2.BackColor = Color.White;
            comboBoxCustom2.BorderColor = Color.MediumSlateBlue;
            comboBoxCustom2.BorderSize = 1;
            comboBoxCustom2.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxCustom2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCustom2.ForeColor = Color.DimGray;
            comboBoxCustom2.IconColor = Color.MediumSlateBlue;
            comboBoxCustom2.ListBackColor = Color.FromArgb(230, 228, 245);
            comboBoxCustom2.ListTextColor = Color.DimGray;
            comboBoxCustom2.Location = new Point(183, 108);
            comboBoxCustom2.MinimumSize = new Size(200, 30);
            comboBoxCustom2.Name = "comboBoxCustom2";
            comboBoxCustom2.Padding = new Padding(1);
            comboBoxCustom2.Size = new Size(280, 30);
            comboBoxCustom2.TabIndex = 5;
            comboBoxCustom2.Texts = "";
            // 
            // comboBoxCustom3
            // 
            comboBoxCustom3.BackColor = Color.White;
            comboBoxCustom3.BorderColor = Color.MediumSlateBlue;
            comboBoxCustom3.BorderSize = 1;
            comboBoxCustom3.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxCustom3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCustom3.ForeColor = Color.DimGray;
            comboBoxCustom3.IconColor = Color.MediumSlateBlue;
            comboBoxCustom3.ListBackColor = Color.FromArgb(230, 228, 245);
            comboBoxCustom3.ListTextColor = Color.DimGray;
            comboBoxCustom3.Location = new Point(183, 289);
            comboBoxCustom3.MinimumSize = new Size(200, 30);
            comboBoxCustom3.Name = "comboBoxCustom3";
            comboBoxCustom3.Padding = new Padding(1);
            comboBoxCustom3.Size = new Size(280, 30);
            comboBoxCustom3.TabIndex = 17;
            comboBoxCustom3.Texts = "";
            // 
            // dateTimePickerCustom2
            // 
            dateTimePickerCustom2.BorderColor = Color.PaleVioletRed;
            dateTimePickerCustom2.BorderSize = 0;
            dateTimePickerCustom2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCustom2.Location = new Point(183, 244);
            dateTimePickerCustom2.MinimumSize = new Size(0, 35);
            dateTimePickerCustom2.Name = "dateTimePickerCustom2";
            dateTimePickerCustom2.Size = new Size(280, 35);
            dateTimePickerCustom2.SkinColor = Color.MediumSlateBlue;
            dateTimePickerCustom2.TabIndex = 16;
            dateTimePickerCustom2.TextColor = Color.White;
            // 
            // dateTimePickerCustom1
            // 
            dateTimePickerCustom1.BorderColor = Color.PaleVioletRed;
            dateTimePickerCustom1.BorderSize = 0;
            dateTimePickerCustom1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCustom1.Location = new Point(183, 199);
            dateTimePickerCustom1.MinimumSize = new Size(0, 35);
            dateTimePickerCustom1.Name = "dateTimePickerCustom1";
            dateTimePickerCustom1.Size = new Size(280, 35);
            dateTimePickerCustom1.SkinColor = Color.MediumSlateBlue;
            dateTimePickerCustom1.TabIndex = 15;
            dateTimePickerCustom1.TextColor = Color.White;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(104, 341);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 14;
            label10.Text = "Hãng";
            // 
            // textBoxCustom3
            // 
            textBoxCustom3.BackColor = Color.White;
            textBoxCustom3.BorderColor = Color.MediumSlateBlue;
            textBoxCustom3.BorderFocusColor = Color.HotPink;
            textBoxCustom3.BorderSize = 2;
            textBoxCustom3.Location = new Point(183, 11);
            textBoxCustom3.Multiline = false;
            textBoxCustom3.Name = "textBoxCustom3";
            textBoxCustom3.Padding = new Padding(7);
            textBoxCustom3.PasswordChar = false;
            textBoxCustom3.Size = new Size(280, 30);
            textBoxCustom3.TabIndex = 12;
            textBoxCustom3.Texts = "";
            textBoxCustom3.UnderlinedStyle = true;
            // 
            // textBoxCustom1
            // 
            textBoxCustom1.BackColor = Color.White;
            textBoxCustom1.BorderColor = Color.MediumSlateBlue;
            textBoxCustom1.BorderFocusColor = Color.HotPink;
            textBoxCustom1.BorderSize = 2;
            textBoxCustom1.Location = new Point(183, 154);
            textBoxCustom1.Multiline = false;
            textBoxCustom1.Name = "textBoxCustom1";
            textBoxCustom1.Padding = new Padding(7);
            textBoxCustom1.PasswordChar = false;
            textBoxCustom1.Size = new Size(280, 30);
            textBoxCustom1.TabIndex = 5;
            textBoxCustom1.Texts = "";
            textBoxCustom1.UnderlinedStyle = true;
            textBoxCustom1.Load += textBoxCustom2_Load;
            // 
            // textBoxCustom2
            // 
            textBoxCustom2.BackColor = Color.White;
            textBoxCustom2.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2.BorderFocusColor = Color.HotPink;
            textBoxCustom2.BorderSize = 2;
            textBoxCustom2.Location = new Point(183, 57);
            textBoxCustom2.Multiline = false;
            textBoxCustom2.Name = "textBoxCustom2";
            textBoxCustom2.Padding = new Padding(7);
            textBoxCustom2.PasswordChar = false;
            textBoxCustom2.Size = new Size(280, 30);
            textBoxCustom2.TabIndex = 5;
            textBoxCustom2.Texts = "";
            textBoxCustom2.UnderlinedStyle = true;
            textBoxCustom2.Load += textBoxCustom2_Load;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(40, 299);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 11;
            label9.Text = "Loại sản phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(75, 253);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 10;
            label6.Text = "Đến ngày";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(75, 208);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 9;
            label7.Text = "Từ ngày";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(46, 164);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 8;
            label8.Text = "Mức giảm giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(55, 21);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 7;
            label5.Text = "Mã giảm giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(9, 67);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 6;
            label4.Text = "Tên CT khuyến mại";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(12, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(963, 521);
            panel3.TabIndex = 6;
            // 
            // FrmKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(1521, 690);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmKhuyenMai";
            Text = "Khuyến mại";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private CustomControl.ComboBoxCustom comboBoxCustom2;
        private Label label3;
        private CustomControl.TextBoxCustom textBoxCustom3;
        private CustomControl.TextBoxCustom textBoxCustom2;
        private Label label9;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView2;
        private CustomControl.ComboBoxCustom comboBoxCustom4;
        private CustomControl.ComboBoxCustom comboBoxCustom3;
        private CustomControl.DateTimePickerCustom dateTimePickerCustom2;
        private CustomControl.DateTimePickerCustom dateTimePickerCustom1;
        private Label label10;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private CustomControl.RadioButtonCustom radioButtonCustom1;
        private FontAwesome.Sharp.IconButton iconButton8;
        private CustomControl.TextBoxCustom2_0 textBoxCustom2_04;
        private Panel panel3;
        private CustomControl.ButtonCustom buttonCustom2;
        private CustomControl.ButtonCustom buttonCustom1;
        private CustomControl.TextBoxCustom textBoxCustom1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private CustomControl.TextBoxCustom2_0 textBoxCustom2_01;
        private CustomControl.RadioButtonCustom radioButtonCustom2;
        private FontAwesome.Sharp.IconButton iconButton5;
    }
}