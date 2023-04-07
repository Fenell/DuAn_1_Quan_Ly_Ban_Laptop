namespace _3_GUI_PresentationLayer.View
{
    partial class FrmDangNhap
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
            txtEmail = new CustomControl.TextBoxCustom2_0();
            txtMatKhau = new CustomControl.TextBoxCustom2_0();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            nhoMatKhau = new CheckBox();
            LbQuenMatKhau = new LinkLabel();
            buttonCustom1 = new CustomControl.ButtonCustom();
            btnExit = new FontAwesome.Sharp.IconButton();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 204, 204);
            txtEmail.BorderColor = Color.FromArgb(79, 175, 156);
            txtEmail.BorderFocusColor = Color.HotPink;
            txtEmail.BorderRadius = 0;
            txtEmail.BorderSize = 2;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(77, 195);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(42, 7, 7, 7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.DarkGray;
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(245, 36);
            txtEmail.TabIndex = 1;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = true;
            txtEmail.Load += txtEmail_Load;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.FromArgb(204, 204, 204);
            txtMatKhau.BorderColor = Color.FromArgb(79, 175, 156);
            txtMatKhau.BorderFocusColor = Color.SlateBlue;
            txtMatKhau.BorderRadius = 0;
            txtMatKhau.BorderSize = 2;
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(76, 263);
            txtMatKhau.Multiline = false;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Padding = new Padding(42, 7, 7, 7);
            txtMatKhau.PasswordChar = false;
            txtMatKhau.PlaceholderColor = Color.DarkGray;
            txtMatKhau.PlaceholderText = "Mật khẩu";
            txtMatKhau.Size = new Size(246, 36);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.Texts = "";
            txtMatKhau.UnderlinedStyle = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(75, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pasword;
            pictureBox2.Location = new Point(74, 261);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // nhoMatKhau
            // 
            nhoMatKhau.AutoSize = true;
            nhoMatKhau.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nhoMatKhau.Location = new Point(61, 325);
            nhoMatKhau.Name = "nhoMatKhau";
            nhoMatKhau.Size = new Size(109, 21);
            nhoMatKhau.TabIndex = 3;
            nhoMatKhau.Text = "Nhớ mật khẩu";
            nhoMatKhau.UseVisualStyleBackColor = true;
            nhoMatKhau.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LbQuenMatKhau
            // 
            LbQuenMatKhau.AutoSize = true;
            LbQuenMatKhau.DisabledLinkColor = Color.Black;
            LbQuenMatKhau.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LbQuenMatKhau.ForeColor = Color.Coral;
            LbQuenMatKhau.LinkColor = Color.Crimson;
            LbQuenMatKhau.Location = new Point(243, 329);
            LbQuenMatKhau.Name = "LbQuenMatKhau";
            LbQuenMatKhau.Size = new Size(96, 17);
            LbQuenMatKhau.TabIndex = 4;
            LbQuenMatKhau.TabStop = true;
            LbQuenMatKhau.Text = "Quên mật khẩu";
            LbQuenMatKhau.LinkClicked += linkLabel1_LinkClicked;
            // 
            // buttonCustom1
            // 
            buttonCustom1.BackColor = Color.FromArgb(255, 192, 128);
            buttonCustom1.BackgroundColor = Color.FromArgb(255, 192, 128);
            buttonCustom1.BorderColor = Color.PaleVioletRed;
            buttonCustom1.BorderRadius = 10;
            buttonCustom1.BorderSize = 0;
            buttonCustom1.FlatAppearance.BorderSize = 0;
            buttonCustom1.FlatStyle = FlatStyle.Flat;
            buttonCustom1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCustom1.ForeColor = Color.FromArgb(64, 0, 0);
            buttonCustom1.Location = new Point(122, 369);
            buttonCustom1.Name = "buttonCustom1";
            buttonCustom1.Size = new Size(150, 40);
            buttonCustom1.TabIndex = 5;
            buttonCustom1.Text = "Đăng nhập";
            buttonCustom1.TextColor = Color.FromArgb(64, 0, 0);
            buttonCustom1.UseVisualStyleBackColor = false;
            buttonCustom1.Click += buttonCustom1_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(204, 204, 204);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = SystemColors.InfoText;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 30;
            btnExit.Location = new Point(347, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(35, 26);
            btnExit.TabIndex = 6;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.airplane;
            pictureBox3.Location = new Point(142, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 119);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(204, 204, 204);
            ClientSize = new Size(378, 432);
            Controls.Add(pictureBox3);
            Controls.Add(btnExit);
            Controls.Add(buttonCustom1);
            Controls.Add(LbQuenMatKhau);
            Controls.Add(nhoMatKhau);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDangNhap";
            Text = "FrmDangNhap";
            Load += FrmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControl.TextBoxCustom2_0 txtEmail;
        private CustomControl.TextBoxCustom2_0 txtMatKhau;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox nhoMatKhau;
        private LinkLabel LbQuenMatKhau;
        private CustomControl.ButtonCustom buttonCustom1;
        private FontAwesome.Sharp.IconButton btnExit;
        private PictureBox pictureBox3;
    }
}