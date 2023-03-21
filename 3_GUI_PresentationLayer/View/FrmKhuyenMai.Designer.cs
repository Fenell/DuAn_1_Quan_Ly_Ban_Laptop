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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            comboBoxCustom1 = new CustomControl.ComboBoxCustom();
            textBoxCustom1 = new CustomControl.TextBoxCustom();
            panel2 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            comboBoxCustom4 = new CustomControl.ComboBoxCustom();
            comboBoxCustom3 = new CustomControl.ComboBoxCustom();
            dateTimePickerCustom2 = new CustomControl.DateTimePickerCustom();
            dateTimePickerCustom1 = new CustomControl.DateTimePickerCustom();
            label10 = new Label();
            textBoxCustom4 = new CustomControl.TextBoxCustom();
            textBoxCustom3 = new CustomControl.TextBoxCustom();
            textBoxCustom2 = new CustomControl.TextBoxCustom();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBoxCustom2 = new CustomControl.ComboBoxCustom();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxCustom1);
            panel1.Controls.Add(textBoxCustom1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 586);
            panel1.TabIndex = 3;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = SystemColors.ButtonHighlight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(350, 21);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(50, 49);
            iconButton1.TabIndex = 4;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(995, 497);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(639, 11);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 3;
            label2.Text = "Trạng Thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(53, 11);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 2;
            label1.Text = "Tìm Kiếm";
            // 
            // comboBoxCustom1
            // 
            comboBoxCustom1.BackColor = Color.WhiteSmoke;
            comboBoxCustom1.BorderColor = Color.MediumSlateBlue;
            comboBoxCustom1.BorderSize = 1;
            comboBoxCustom1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxCustom1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCustom1.ForeColor = Color.DimGray;
            comboBoxCustom1.IconColor = Color.MediumSlateBlue;
            comboBoxCustom1.ListBackColor = Color.FromArgb(230, 228, 245);
            comboBoxCustom1.ListTextColor = Color.DimGray;
            comboBoxCustom1.Location = new Point(635, 40);
            comboBoxCustom1.MinimumSize = new Size(200, 30);
            comboBoxCustom1.Name = "comboBoxCustom1";
            comboBoxCustom1.Padding = new Padding(1);
            comboBoxCustom1.Size = new Size(278, 30);
            comboBoxCustom1.TabIndex = 1;
            comboBoxCustom1.Texts = "";
            // 
            // textBoxCustom1
            // 
            textBoxCustom1.BackColor = SystemColors.Control;
            textBoxCustom1.BorderColor = Color.MediumSlateBlue;
            textBoxCustom1.BorderFocusColor = Color.HotPink;
            textBoxCustom1.BorderSize = 2;
            textBoxCustom1.Location = new Point(40, 40);
            textBoxCustom1.Multiline = false;
            textBoxCustom1.Name = "textBoxCustom1";
            textBoxCustom1.Padding = new Padding(7);
            textBoxCustom1.PasswordChar = false;
            textBoxCustom1.Size = new Size(304, 30);
            textBoxCustom1.TabIndex = 0;
            textBoxCustom1.Texts = "";
            textBoxCustom1.UnderlinedStyle = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButton3);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBoxCustom4);
            panel2.Controls.Add(comboBoxCustom3);
            panel2.Controls.Add(dateTimePickerCustom2);
            panel2.Controls.Add(dateTimePickerCustom1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBoxCustom4);
            panel2.Controls.Add(textBoxCustom3);
            panel2.Controls.Add(textBoxCustom2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBoxCustom2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(1013, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 586);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(314, 533);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(63, 50);
            iconButton3.TabIndex = 22;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(121, 533);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(63, 51);
            iconButton2.TabIndex = 21;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(9, 368);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(474, 159);
            dataGridView2.TabIndex = 20;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(399, 330);
            button1.Name = "button1";
            button1.Size = new Size(84, 31);
            button1.TabIndex = 19;
            button1.Text = "GetAlL";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxCustom4
            // 
            comboBoxCustom4.BackColor = Color.WhiteSmoke;
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
            comboBoxCustom4.Size = new Size(200, 30);
            comboBoxCustom4.TabIndex = 18;
            comboBoxCustom4.Texts = "";
            // 
            // comboBoxCustom3
            // 
            comboBoxCustom3.BackColor = Color.WhiteSmoke;
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
            comboBoxCustom3.Size = new Size(300, 30);
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
            dateTimePickerCustom2.Size = new Size(300, 35);
            dateTimePickerCustom2.SkinColor = Color.MediumSlateBlue;
            dateTimePickerCustom2.TabIndex = 16;
            dateTimePickerCustom2.TextColor = Color.White;
            // 
            // dateTimePickerCustom1
            // 
            dateTimePickerCustom1.BorderColor = Color.PaleVioletRed;
            dateTimePickerCustom1.BorderSize = 0;
            dateTimePickerCustom1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCustom1.Location = new Point(183, 203);
            dateTimePickerCustom1.MinimumSize = new Size(0, 35);
            dateTimePickerCustom1.Name = "dateTimePickerCustom1";
            dateTimePickerCustom1.Size = new Size(300, 35);
            dateTimePickerCustom1.SkinColor = Color.MediumSlateBlue;
            dateTimePickerCustom1.TabIndex = 15;
            dateTimePickerCustom1.TextColor = Color.White;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(9, 338);
            label10.Name = "label10";
            label10.Size = new Size(61, 25);
            label10.TabIndex = 14;
            label10.Text = "Hãng";
            // 
            // textBoxCustom4
            // 
            textBoxCustom4.BackColor = SystemColors.Control;
            textBoxCustom4.BorderColor = Color.MediumSlateBlue;
            textBoxCustom4.BorderFocusColor = Color.HotPink;
            textBoxCustom4.BorderSize = 1;
            textBoxCustom4.Location = new Point(183, 132);
            textBoxCustom4.Multiline = true;
            textBoxCustom4.Name = "textBoxCustom4";
            textBoxCustom4.Padding = new Padding(7);
            textBoxCustom4.PasswordChar = false;
            textBoxCustom4.Size = new Size(300, 62);
            textBoxCustom4.TabIndex = 13;
            textBoxCustom4.Texts = "";
            textBoxCustom4.UnderlinedStyle = false;
            // 
            // textBoxCustom3
            // 
            textBoxCustom3.BackColor = SystemColors.Control;
            textBoxCustom3.BorderColor = Color.MediumSlateBlue;
            textBoxCustom3.BorderFocusColor = Color.HotPink;
            textBoxCustom3.BorderSize = 2;
            textBoxCustom3.Location = new Point(183, 87);
            textBoxCustom3.Multiline = false;
            textBoxCustom3.Name = "textBoxCustom3";
            textBoxCustom3.Padding = new Padding(7);
            textBoxCustom3.PasswordChar = false;
            textBoxCustom3.Size = new Size(300, 30);
            textBoxCustom3.TabIndex = 12;
            textBoxCustom3.Texts = "";
            textBoxCustom3.UnderlinedStyle = true;
            // 
            // textBoxCustom2
            // 
            textBoxCustom2.BackColor = SystemColors.Control;
            textBoxCustom2.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2.BorderFocusColor = Color.HotPink;
            textBoxCustom2.BorderSize = 2;
            textBoxCustom2.Location = new Point(183, 47);
            textBoxCustom2.Multiline = false;
            textBoxCustom2.Name = "textBoxCustom2";
            textBoxCustom2.Padding = new Padding(7);
            textBoxCustom2.PasswordChar = false;
            textBoxCustom2.Size = new Size(300, 30);
            textBoxCustom2.TabIndex = 5;
            textBoxCustom2.Texts = "";
            textBoxCustom2.UnderlinedStyle = true;
            textBoxCustom2.Load += textBoxCustom2_Load;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(9, 294);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 11;
            label9.Text = "Loại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(9, 256);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 10;
            label6.Text = "Ngày Kết Thúc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(9, 208);
            label7.Name = "label7";
            label7.Size = new Size(134, 25);
            label7.TabIndex = 9;
            label7.Text = "Ngày Bắt Đầu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(9, 137);
            label8.Name = "label8";
            label8.Size = new Size(165, 25);
            label8.TabIndex = 8;
            label8.Text = "Giá Trị, Quà Tặng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(9, 92);
            label5.Name = "label5";
            label5.Size = new Size(168, 25);
            label5.TabIndex = 7;
            label5.Text = "Mã Chương Trình";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(9, 52);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 6;
            label4.Text = "Tên Chương Trình";
            // 
            // comboBoxCustom2
            // 
            comboBoxCustom2.BackColor = Color.WhiteSmoke;
            comboBoxCustom2.BorderColor = Color.MediumSlateBlue;
            comboBoxCustom2.BorderSize = 1;
            comboBoxCustom2.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxCustom2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCustom2.ForeColor = Color.DimGray;
            comboBoxCustom2.IconColor = Color.MediumSlateBlue;
            comboBoxCustom2.ListBackColor = Color.FromArgb(230, 228, 245);
            comboBoxCustom2.ListTextColor = Color.DimGray;
            comboBoxCustom2.Location = new Point(183, 7);
            comboBoxCustom2.MinimumSize = new Size(200, 30);
            comboBoxCustom2.Name = "comboBoxCustom2";
            comboBoxCustom2.Padding = new Padding(1);
            comboBoxCustom2.Size = new Size(300, 30);
            comboBoxCustom2.TabIndex = 5;
            comboBoxCustom2.Texts = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(9, 12);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 5;
            label3.Text = "Loại Khuyến Mãi";
            label3.Click += label3_Click;
            // 
            // FrmKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1521, 601);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmKhuyenMai";
            Text = "FrmKhuyenMai";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
        private Label label1;
        private CustomControl.ComboBoxCustom comboBoxCustom1;
        private CustomControl.TextBoxCustom textBoxCustom1;
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
        private Button button1;
        private CustomControl.ComboBoxCustom comboBoxCustom4;
        private CustomControl.ComboBoxCustom comboBoxCustom3;
        private CustomControl.DateTimePickerCustom dateTimePickerCustom2;
        private CustomControl.DateTimePickerCustom dateTimePickerCustom1;
        private Label label10;
        private CustomControl.TextBoxCustom textBoxCustom4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}