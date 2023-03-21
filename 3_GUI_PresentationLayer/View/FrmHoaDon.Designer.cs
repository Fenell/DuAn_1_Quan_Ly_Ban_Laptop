namespace _3_GUI_PresentationLayer.View
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
            label1 = new Label();
            textBoxCustom1 = new CustomControl.TextBoxCustom();
            label2 = new Label();
            comboBoxCustom1 = new CustomControl.ComboBoxCustom();
            panel1 = new Panel();
            buttonCustom1 = new CustomControl.ButtonCustom();
            dateTimePickerCustom2 = new CustomControl.DateTimePickerCustom();
            label5 = new Label();
            dateTimePickerCustom1 = new CustomControl.DateTimePickerCustom();
            label4 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(6, 17);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 0;
            label1.Text = "Tìm Kiếm";
            // 
            // textBoxCustom1
            // 
            textBoxCustom1.BackColor = SystemColors.Control;
            textBoxCustom1.BorderColor = Color.Gray;
            textBoxCustom1.BorderFocusColor = Color.HotPink;
            textBoxCustom1.BorderSize = 2;
            textBoxCustom1.Location = new Point(117, 4);
            textBoxCustom1.Multiline = false;
            textBoxCustom1.Name = "textBoxCustom1";
            textBoxCustom1.Padding = new Padding(7);
            textBoxCustom1.PasswordChar = false;
            textBoxCustom1.Size = new Size(281, 40);
            textBoxCustom1.TabIndex = 1;
            textBoxCustom1.Texts = "";
            textBoxCustom1.UnderlinedStyle = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(415, 17);
            label2.Name = "label2";
            label2.Size = new Size(209, 30);
            label2.TabIndex = 2;
            label2.Text = "Trạng Thái Hóa Đơn";
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
            comboBoxCustom1.Location = new Point(630, 13);
            comboBoxCustom1.MinimumSize = new Size(200, 30);
            comboBoxCustom1.Name = "comboBoxCustom1";
            comboBoxCustom1.Padding = new Padding(1);
            comboBoxCustom1.Size = new Size(200, 35);
            comboBoxCustom1.TabIndex = 3;
            comboBoxCustom1.Texts = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCustom1);
            panel1.Controls.Add(dateTimePickerCustom2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePickerCustom1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(873, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 46);
            panel1.TabIndex = 4;
            // 
            // buttonCustom1
            // 
            buttonCustom1.BackColor = Color.FromArgb(192, 64, 0);
            buttonCustom1.BackgroundColor = Color.FromArgb(192, 64, 0);
            buttonCustom1.BorderColor = Color.PaleVioletRed;
            buttonCustom1.BorderRadius = 20;
            buttonCustom1.BorderSize = 0;
            buttonCustom1.FlatAppearance.BorderSize = 0;
            buttonCustom1.FlatStyle = FlatStyle.Flat;
            buttonCustom1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCustom1.ForeColor = Color.White;
            buttonCustom1.Location = new Point(4, 5);
            buttonCustom1.Name = "buttonCustom1";
            buttonCustom1.Size = new Size(150, 34);
            buttonCustom1.TabIndex = 8;
            buttonCustom1.Text = "Xuất Excel";
            buttonCustom1.TextColor = Color.White;
            buttonCustom1.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerCustom2
            // 
            dateTimePickerCustom2.BorderColor = Color.PaleVioletRed;
            dateTimePickerCustom2.BorderSize = 0;
            dateTimePickerCustom2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCustom2.Location = new Point(443, 5);
            dateTimePickerCustom2.MinimumSize = new Size(0, 35);
            dateTimePickerCustom2.Name = "dateTimePickerCustom2";
            dateTimePickerCustom2.Size = new Size(186, 35);
            dateTimePickerCustom2.SkinColor = Color.MediumSlateBlue;
            dateTimePickerCustom2.TabIndex = 8;
            dateTimePickerCustom2.TextColor = Color.White;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(396, 15);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 7;
            label5.Text = "Đến";
            // 
            // dateTimePickerCustom1
            // 
            dateTimePickerCustom1.BorderColor = Color.PaleVioletRed;
            dateTimePickerCustom1.BorderSize = 0;
            dateTimePickerCustom1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCustom1.Location = new Point(204, 5);
            dateTimePickerCustom1.MinimumSize = new Size(0, 35);
            dateTimePickerCustom1.Name = "dateTimePickerCustom1";
            dateTimePickerCustom1.Size = new Size(186, 35);
            dateTimePickerCustom1.SkinColor = Color.MediumSlateBlue;
            dateTimePickerCustom1.TabIndex = 5;
            dateTimePickerCustom1.TextColor = Color.White;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(168, 15);
            label4.Name = "label4";
            label4.Size = new Size(30, 21);
            label4.TabIndex = 6;
            label4.Text = "Từ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1497, 334);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1491, 302);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 405);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1494, 283);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa Đơn Chi Tiết";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 29);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1488, 251);
            dataGridView2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBoxCustom1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxCustom1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(15, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(851, 55);
            panel2.TabIndex = 1;
            // 
            // FrmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1521, 690);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FrmHoaDon";
            Text = "FrmHoaDon";
            Load += FrmHoaDon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private CustomControl.TextBoxCustom textBoxCustom1;
        private Label label2;
        private CustomControl.ComboBoxCustom comboBoxCustom1;
        private Panel panel1;
        private Label label4;
        private CustomControl.DateTimePickerCustom dateTimePickerCustom2;
        private Label label5;
        private CustomControl.DateTimePickerCustom dateTimePickerCustom1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private CustomControl.ButtonCustom buttonCustom1;
        private Panel panel2;
    }
}