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
            this.txtEmail = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom2_0();
            this.txtMatKhau = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom2_0();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cb_nhoMatKhau = new System.Windows.Forms.CheckBox();
            this.LbQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.buttonCustom1 = new _3_GUI_PresentationLayer.CustomControl.ButtonCustom();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
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
            // cb_nhoMatKhau
            // 
            this.cb_nhoMatKhau.AutoSize = true;
            this.cb_nhoMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_nhoMatKhau.Location = new System.Drawing.Point(61, 325);
            this.cb_nhoMatKhau.Name = "cb_nhoMatKhau";
            this.cb_nhoMatKhau.Size = new System.Drawing.Size(109, 21);
            this.cb_nhoMatKhau.TabIndex = 3;
            this.cb_nhoMatKhau.Text = "Nhớ mật khẩu";
            this.cb_nhoMatKhau.UseVisualStyleBackColor = true;
            this.cb_nhoMatKhau.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(378, 432);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.buttonCustom1);
            this.Controls.Add(this.LbQuenMatKhau);
            this.Controls.Add(this.cb_nhoMatKhau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.TextBoxCustom2_0 txtEmail;
        private CustomControl.TextBoxCustom2_0 txtMatKhau;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox cb_nhoMatKhau;
        private LinkLabel LbQuenMatKhau;
        private CustomControl.ButtonCustom buttonCustom1;
        private FontAwesome.Sharp.IconButton btnExit;
        private PictureBox pictureBox3;
    }
}