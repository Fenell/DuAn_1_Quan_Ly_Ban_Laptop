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
            this.nhoMatKhau = new System.Windows.Forms.CheckBox();
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
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(156)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(77, 195);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(42, 7, 7, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(245, 36);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            this.txtEmail.Load += new System.EventHandler(this.txtEmail_Load);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(156)))));
            this.txtMatKhau.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.txtMatKhau.BorderRadius = 0;
            this.txtMatKhau.BorderSize = 2;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatKhau.Location = new System.Drawing.Point(76, 263);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(42, 7, 7, 7);
            this.txtMatKhau.PasswordChar = false;
            this.txtMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.PlaceholderText = "Mật khẩu";
            this.txtMatKhau.Size = new System.Drawing.Size(246, 36);
            this.txtMatKhau.TabIndex = 0;
            this.txtMatKhau.Texts = "";
            this.txtMatKhau.UnderlinedStyle = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3_GUI_PresentationLayer.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(75, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_3_GUI_PresentationLayer.Properties.Resources.pasword;
            this.pictureBox2.Location = new System.Drawing.Point(74, 261);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // nhoMatKhau
            // 
            this.nhoMatKhau.AutoSize = true;
            this.nhoMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nhoMatKhau.Location = new System.Drawing.Point(61, 325);
            this.nhoMatKhau.Name = "nhoMatKhau";
            this.nhoMatKhau.Size = new System.Drawing.Size(109, 21);
            this.nhoMatKhau.TabIndex = 3;
            this.nhoMatKhau.Text = "Nhớ mật khẩu";
            this.nhoMatKhau.UseVisualStyleBackColor = true;
            this.nhoMatKhau.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LbQuenMatKhau
            // 
            this.LbQuenMatKhau.AutoSize = true;
            this.LbQuenMatKhau.DisabledLinkColor = System.Drawing.Color.Black;
            this.LbQuenMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbQuenMatKhau.ForeColor = System.Drawing.Color.Coral;
            this.LbQuenMatKhau.LinkColor = System.Drawing.Color.Crimson;
            this.LbQuenMatKhau.Location = new System.Drawing.Point(243, 329);
            this.LbQuenMatKhau.Name = "LbQuenMatKhau";
            this.LbQuenMatKhau.Size = new System.Drawing.Size(96, 17);
            this.LbQuenMatKhau.TabIndex = 4;
            this.LbQuenMatKhau.TabStop = true;
            this.LbQuenMatKhau.Text = "Quên mật khẩu";
            this.LbQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonCustom1
            // 
            this.buttonCustom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonCustom1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonCustom1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom1.BorderRadius = 10;
            this.buttonCustom1.BorderSize = 0;
            this.buttonCustom1.FlatAppearance.BorderSize = 0;
            this.buttonCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustom1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCustom1.Location = new System.Drawing.Point(122, 369);
            this.buttonCustom1.Name = "buttonCustom1";
            this.buttonCustom1.Size = new System.Drawing.Size(150, 40);
            this.buttonCustom1.TabIndex = 5;
            this.buttonCustom1.Text = "Đăng nhập";
            this.buttonCustom1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCustom1.UseVisualStyleBackColor = false;
            this.buttonCustom1.Click += new System.EventHandler(this.buttonCustom1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.SystemColors.InfoText;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(347, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 26);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_3_GUI_PresentationLayer.Properties.Resources.airplane;
            this.pictureBox3.Location = new System.Drawing.Point(142, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
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
            this.Controls.Add(this.nhoMatKhau);
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
        private CheckBox nhoMatKhau;
        private LinkLabel LbQuenMatKhau;
        private CustomControl.ButtonCustom buttonCustom1;
        private FontAwesome.Sharp.IconButton btnExit;
        private PictureBox pictureBox3;
    }
}