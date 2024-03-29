﻿namespace _3_GUI_PresentationLayer.View
{
    partial class FrmHoaDon
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
            comboBoxCustom1 = new CustomControl.ComboBoxCustom();
            dateTimePickerCustom2 = new CustomControl.DateTimePickerCustom();
            label5 = new Label();
            dateTimePickerCustom1 = new CustomControl.DateTimePickerCustom();
            label4 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            panel2 = new Panel();
            radioButtonCustom3 = new CustomControl.RadioButtonCustom();
            radioButtonCustom2 = new CustomControl.RadioButtonCustom();
            radioButtonCustom1 = new CustomControl.RadioButtonCustom();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            textBoxCustom2_04 = new CustomControl.TextBoxCustom2_0();
            label2 = new Label();
            label1 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxCustom1
            // 
            comboBoxCustom1.BackColor = Color.WhiteSmoke;
            comboBoxCustom1.BorderColor = Color.Black;
            comboBoxCustom1.BorderSize = 1;
            comboBoxCustom1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxCustom1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCustom1.ForeColor = Color.DimGray;
            comboBoxCustom1.IconColor = Color.Black;
            comboBoxCustom1.ListBackColor = Color.FromArgb(230, 228, 245);
            comboBoxCustom1.ListTextColor = Color.DimGray;
            comboBoxCustom1.Location = new Point(709, 23);
            comboBoxCustom1.MinimumSize = new Size(200, 30);
            comboBoxCustom1.Name = "comboBoxCustom1";
            comboBoxCustom1.Padding = new Padding(1);
            comboBoxCustom1.Size = new Size(200, 30);
            comboBoxCustom1.TabIndex = 3;
            comboBoxCustom1.Texts = "";
            // 
            // dateTimePickerCustom2
            // 
            dateTimePickerCustom2.BorderColor = Color.PaleVioletRed;
            dateTimePickerCustom2.BorderSize = 0;
            dateTimePickerCustom2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCustom2.Format = DateTimePickerFormat.Short;
            dateTimePickerCustom2.Location = new Point(497, 18);
            dateTimePickerCustom2.MinimumSize = new Size(0, 35);
            dateTimePickerCustom2.Name = "dateTimePickerCustom2";
            dateTimePickerCustom2.Size = new Size(141, 35);
            dateTimePickerCustom2.SkinColor = Color.MediumSlateBlue;
            dateTimePickerCustom2.TabIndex = 8;
            dateTimePickerCustom2.TextColor = Color.White;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(454, 27);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 7;
            label5.Text = "Đến";
            // 
            // dateTimePickerCustom1
            // 
            dateTimePickerCustom1.BorderColor = Color.PaleVioletRed;
            dateTimePickerCustom1.BorderSize = 0;
            dateTimePickerCustom1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCustom1.Format = DateTimePickerFormat.Short;
            dateTimePickerCustom1.Location = new Point(317, 17);
            dateTimePickerCustom1.MinimumSize = new Size(0, 35);
            dateTimePickerCustom1.Name = "dateTimePickerCustom1";
            dateTimePickerCustom1.Size = new Size(131, 35);
            dateTimePickerCustom1.SkinColor = Color.MediumSlateBlue;
            dateTimePickerCustom1.TabIndex = 5;
            dateTimePickerCustom1.TextColor = Color.White;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(285, 27);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 6;
            label4.Text = "Từ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(27, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1472, 300);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1466, 272);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(24, 433);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1478, 243);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa Đơn Chi Tiết";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 25);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1472, 215);
            dataGridView2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(radioButtonCustom3);
            panel2.Controls.Add(radioButtonCustom2);
            panel2.Controls.Add(radioButtonCustom1);
            panel2.Controls.Add(iconButton8);
            panel2.Controls.Add(textBoxCustom2_04);
            panel2.Controls.Add(comboBoxCustom1);
            panel2.Controls.Add(dateTimePickerCustom2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dateTimePickerCustom1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(30, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(1306, 70);
            panel2.TabIndex = 1;
            // 
            // radioButtonCustom3
            // 
            radioButtonCustom3.AutoSize = true;
            radioButtonCustom3.CheckedColor = Color.MediumSlateBlue;
            radioButtonCustom3.Location = new Point(1207, 28);
            radioButtonCustom3.MinimumSize = new Size(0, 21);
            radioButtonCustom3.Name = "radioButtonCustom3";
            radioButtonCustom3.Padding = new Padding(10, 0, 0, 0);
            radioButtonCustom3.Size = new Size(57, 21);
            radioButtonCustom3.TabIndex = 50;
            radioButtonCustom3.TabStop = true;
            radioButtonCustom3.Text = "Hủy";
            radioButtonCustom3.UnCheckedColor = Color.Gray;
            radioButtonCustom3.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustom2
            // 
            radioButtonCustom2.AutoSize = true;
            radioButtonCustom2.CheckedColor = Color.MediumSlateBlue;
            radioButtonCustom2.Location = new Point(1077, 27);
            radioButtonCustom2.MinimumSize = new Size(0, 21);
            radioButtonCustom2.Name = "radioButtonCustom2";
            radioButtonCustom2.Padding = new Padding(10, 0, 0, 0);
            radioButtonCustom2.Size = new Size(124, 21);
            radioButtonCustom2.TabIndex = 50;
            radioButtonCustom2.TabStop = true;
            radioButtonCustom2.Text = "Chưa thanh toán";
            radioButtonCustom2.UnCheckedColor = Color.Gray;
            radioButtonCustom2.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustom1
            // 
            radioButtonCustom1.AutoSize = true;
            radioButtonCustom1.CheckedColor = Color.MediumSlateBlue;
            radioButtonCustom1.Location = new Point(961, 28);
            radioButtonCustom1.MinimumSize = new Size(0, 21);
            radioButtonCustom1.Name = "radioButtonCustom1";
            radioButtonCustom1.Padding = new Padding(10, 0, 0, 0);
            radioButtonCustom1.Size = new Size(110, 21);
            radioButtonCustom1.TabIndex = 50;
            radioButtonCustom1.TabStop = true;
            radioButtonCustom1.Text = "Đã thanh toán";
            radioButtonCustom1.UnCheckedColor = Color.Gray;
            radioButtonCustom1.UseVisualStyleBackColor = true;
            // 
            // iconButton8
            // 
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 23;
            iconButton8.Location = new Point(17, 23);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(32, 25);
            iconButton8.TabIndex = 49;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // textBoxCustom2_04
            // 
            textBoxCustom2_04.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2_04.BorderFocusColor = Color.HotPink;
            textBoxCustom2_04.BorderRadius = 10;
            textBoxCustom2_04.BorderSize = 1;
            textBoxCustom2_04.Location = new Point(11, 19);
            textBoxCustom2_04.Multiline = false;
            textBoxCustom2_04.Name = "textBoxCustom2_04";
            textBoxCustom2_04.Padding = new Padding(42, 7, 7, 7);
            textBoxCustom2_04.PasswordChar = false;
            textBoxCustom2_04.PlaceholderColor = Color.DarkGray;
            textBoxCustom2_04.PlaceholderText = "Tìm kiếm";
            textBoxCustom2_04.Size = new Size(250, 30);
            textBoxCustom2_04.TabIndex = 48;
            textBoxCustom2_04.Texts = "";
            textBoxCustom2_04.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(975, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 17);
            label2.TabIndex = 6;
            label2.Text = "Trạng thái hóa đơn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(709, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 6;
            label1.Text = "Loại sản phẩm";
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(2, 135, 127);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(1421, 26);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(75, 70);
            iconButton2.TabIndex = 7;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(2, 135, 127);
            pictureBox1.Image = Properties.Resources.icons8_microsoft_excel_80;
            pictureBox1.Location = new Point(1342, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FrmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(1521, 690);
            Controls.Add(pictureBox1);
            Controls.Add(iconButton2);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHoaDon";
            Text = "Hóa  đơn";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CustomControl.ComboBoxCustom comboBoxCustom1;
        private Label label4;
        private CustomControl.DateTimePickerCustom dateTimePickerCustom2;
        private Label label5;
        private CustomControl.DateTimePickerCustom dateTimePickerCustom1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Panel panel2;
        private CustomControl.RadioButtonCustom radioButtonCustom3;
        private CustomControl.RadioButtonCustom radioButtonCustom2;
        private CustomControl.RadioButtonCustom radioButtonCustom1;
        private FontAwesome.Sharp.IconButton iconButton8;
        private CustomControl.TextBoxCustom2_0 textBoxCustom2_04;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private PictureBox pictureBox1;
    }
}