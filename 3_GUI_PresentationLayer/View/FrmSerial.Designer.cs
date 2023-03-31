namespace _3_GUI_PresentationLayer.View
{
    partial class FrmSerial
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
            pcbCamera = new PictureBox();
            btnBatCamera = new CustomControl.ButtonCustom();
            txtSerial = new CustomControl.TextBoxCustom2_0();
            btnThem = new FontAwesome.Sharp.IconButton();
            dgvLaptop = new DataGridView();
            txtTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbCamera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLaptop).BeginInit();
            SuspendLayout();
            // 
            // pcbCamera
            // 
            pcbCamera.Location = new Point(290, 12);
            pcbCamera.Name = "pcbCamera";
            pcbCamera.Size = new Size(231, 154);
            pcbCamera.TabIndex = 51;
            pcbCamera.TabStop = false;
            // 
            // btnBatCamera
            // 
            btnBatCamera.BackColor = Color.MediumSlateBlue;
            btnBatCamera.BackgroundColor = Color.MediumSlateBlue;
            btnBatCamera.BorderColor = Color.PaleVioletRed;
            btnBatCamera.BorderRadius = 10;
            btnBatCamera.BorderSize = 0;
            btnBatCamera.FlatAppearance.BorderSize = 0;
            btnBatCamera.FlatStyle = FlatStyle.Flat;
            btnBatCamera.ForeColor = Color.White;
            btnBatCamera.Location = new Point(345, 172);
            btnBatCamera.Name = "btnBatCamera";
            btnBatCamera.Size = new Size(117, 33);
            btnBatCamera.TabIndex = 52;
            btnBatCamera.Text = "Bật camera";
            btnBatCamera.TextColor = Color.White;
            btnBatCamera.UseVisualStyleBackColor = false;
            // 
            // txtSerial
            // 
            txtSerial.BackColor = Color.FromArgb(244, 245, 255);
            txtSerial.BorderColor = Color.MediumSlateBlue;
            txtSerial.BorderFocusColor = Color.HotPink;
            txtSerial.BorderRadius = 0;
            txtSerial.BorderSize = 2;
            txtSerial.Location = new Point(290, 211);
            txtSerial.Multiline = false;
            txtSerial.Name = "txtSerial";
            txtSerial.Padding = new Padding(7);
            txtSerial.PasswordChar = false;
            txtSerial.PlaceholderColor = Color.DarkGray;
            txtSerial.PlaceholderText = "";
            txtSerial.Size = new Size(199, 30);
            txtSerial.TabIndex = 53;
            txtSerial.Texts = "";
            txtSerial.UnderlinedStyle = true;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(244, 245, 255);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnThem.IconColor = Color.FromArgb(115, 176, 244);
            btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThem.IconSize = 28;
            btnThem.Location = new Point(495, 211);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(0, 4, 0, 0);
            btnThem.Size = new Size(43, 36);
            btnThem.TabIndex = 54;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvLaptop
            // 
            dgvLaptop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaptop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaptop.Location = new Point(6, 55);
            dgvLaptop.Name = "dgvLaptop";
            dgvLaptop.RowHeadersVisible = false;
            dgvLaptop.RowTemplate.Height = 25;
            dgvLaptop.Size = new Size(250, 186);
            dgvLaptop.TabIndex = 55;
            dgvLaptop.CellClick += dgvLaptop_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(6, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(250, 23);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.Text = "Tìm Kiếm ......";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // FrmSerial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(550, 257);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvLaptop);
            Controls.Add(btnThem);
            Controls.Add(txtSerial);
            Controls.Add(btnBatCamera);
            Controls.Add(pcbCamera);
            Name = "FrmSerial";
            Text = "Nhập Imei";
            ((System.ComponentModel.ISupportInitialize)pcbCamera).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLaptop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcbCamera;
        private CustomControl.ButtonCustom btnBatCamera;
        private CustomControl.TextBoxCustom2_0 txtSerial;
        private FontAwesome.Sharp.IconButton btnThem;
        private DataGridView dgvLaptop;
        private TextBox txtTimKiem;
    }
}