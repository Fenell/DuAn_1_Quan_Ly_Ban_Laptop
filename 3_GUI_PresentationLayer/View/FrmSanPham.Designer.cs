namespace _3_GUI_PresentationLayer.View
{
    partial class FrmSanPham
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
            btnLaptop = new CustomControl.ButtonCustom();
            btnLinhKien = new CustomControl.ButtonCustom();
            panelUnderline1 = new Panel();
            panelUnderline2 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panelSanPham = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLaptop
            // 
            btnLaptop.BackColor = Color.White;
            btnLaptop.BackgroundColor = Color.White;
            btnLaptop.BorderColor = Color.White;
            btnLaptop.BorderRadius = 0;
            btnLaptop.BorderSize = 0;
            btnLaptop.FlatAppearance.BorderSize = 0;
            btnLaptop.FlatAppearance.MouseDownBackColor = Color.White;
            btnLaptop.FlatAppearance.MouseOverBackColor = Color.White;
            btnLaptop.FlatStyle = FlatStyle.Flat;
            btnLaptop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLaptop.ForeColor = Color.DeepPink;
            btnLaptop.Location = new Point(7, 4);
            btnLaptop.Name = "btnLaptop";
            btnLaptop.Size = new Size(76, 28);
            btnLaptop.TabIndex = 0;
            btnLaptop.Text = "Laptop";
            btnLaptop.TextColor = Color.DeepPink;
            btnLaptop.UseVisualStyleBackColor = false;
            btnLaptop.Click += btnLaptop_Click;
            // 
            // btnLinhKien
            // 
            btnLinhKien.BackColor = Color.White;
            btnLinhKien.BackgroundColor = Color.White;
            btnLinhKien.BorderColor = Color.PaleVioletRed;
            btnLinhKien.BorderRadius = 0;
            btnLinhKien.BorderSize = 0;
            btnLinhKien.FlatAppearance.BorderSize = 0;
            btnLinhKien.FlatAppearance.MouseDownBackColor = Color.White;
            btnLinhKien.FlatAppearance.MouseOverBackColor = Color.White;
            btnLinhKien.FlatStyle = FlatStyle.Flat;
            btnLinhKien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLinhKien.ForeColor = Color.DeepPink;
            btnLinhKien.Location = new Point(93, 4);
            btnLinhKien.Name = "btnLinhKien";
            btnLinhKien.Size = new Size(92, 28);
            btnLinhKien.TabIndex = 1;
            btnLinhKien.Text = "Linh kiện";
            btnLinhKien.TextColor = Color.DeepPink;
            btnLinhKien.UseVisualStyleBackColor = false;
            btnLinhKien.Click += btnLinhKien_Click;
            // 
            // panelUnderline1
            // 
            panelUnderline1.BackColor = SystemColors.Control;
            panelUnderline1.Location = new Point(3, 34);
            panelUnderline1.Name = "panelUnderline1";
            panelUnderline1.Size = new Size(82, 2);
            panelUnderline1.TabIndex = 2;
            // 
            // panelUnderline2
            // 
            panelUnderline2.BackColor = SystemColors.Control;
            panelUnderline2.Location = new Point(89, 34);
            panelUnderline2.Name = "panelUnderline2";
            panelUnderline2.Size = new Size(100, 2);
            panelUnderline2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(218, 218, 218);
            panel1.Location = new Point(3, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(1506, 2);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btnLaptop);
            panel2.Controls.Add(panelUnderline2);
            panel2.Controls.Add(btnLinhKien);
            panel2.Controls.Add(panelUnderline1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1521, 43);
            panel2.TabIndex = 5;
            // 
            // panelSanPham
            // 
            panelSanPham.Dock = DockStyle.Fill;
            panelSanPham.Location = new Point(0, 43);
            panelSanPham.Name = "panelSanPham";
            panelSanPham.Size = new Size(1521, 647);
            panelSanPham.TabIndex = 6;
            // 
            // FrmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1521, 690);
            Controls.Add(panelSanPham);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSanPham";
            Text = "Sản phẩm";
            Load += FrmSanPham_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomControl.ButtonCustom btnLaptop;
        private CustomControl.ButtonCustom btnLinhKien;
        private Panel panelUnderline1;
        private Panel panelUnderline2;
        private Panel panel1;
        private Panel panel2;
        private Panel panelSanPham;
    }
}