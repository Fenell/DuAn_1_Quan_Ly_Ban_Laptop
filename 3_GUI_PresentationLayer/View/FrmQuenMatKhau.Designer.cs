namespace _3_GUI_PresentationLayer.View
{
    partial class FrmQuenMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Email = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom2_0();
            this.txt_OTP = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom2_0();
            this.txt_MK_New = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom2_0();
            this.txt_XacNhan_MK = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom2_0();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCustom1 = new _3_GUI_PresentationLayer.CustomControl.ButtonCustom();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(104)))), ((int)(((byte)(195)))));
            this.label1.Location = new System.Drawing.Point(143, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lấy lại mật khẩu";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Email.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Email.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Email.BorderRadius = 10;
            this.txt_Email.BorderSize = 1;
            this.txt_Email.Location = new System.Drawing.Point(164, 85);
            this.txt_Email.Multiline = false;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Email.PasswordChar = false;
            this.txt_Email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Email.PlaceholderText = "";
            this.txt_Email.Size = new System.Drawing.Size(197, 30);
            this.txt_Email.TabIndex = 1;
            this.txt_Email.Texts = "";
            this.txt_Email.UnderlinedStyle = false;
            // 
            // txt_OTP
            // 
            this.txt_OTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_OTP.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_OTP.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_OTP.BorderRadius = 10;
            this.txt_OTP.BorderSize = 1;
            this.txt_OTP.Location = new System.Drawing.Point(164, 157);
            this.txt_OTP.Multiline = false;
            this.txt_OTP.Name = "txt_OTP";
            this.txt_OTP.Padding = new System.Windows.Forms.Padding(7);
            this.txt_OTP.PasswordChar = false;
            this.txt_OTP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_OTP.PlaceholderText = "";
            this.txt_OTP.Size = new System.Drawing.Size(197, 30);
            this.txt_OTP.TabIndex = 1;
            this.txt_OTP.Texts = "";
            this.txt_OTP.UnderlinedStyle = false;
            // 
            // txt_MK_New
            // 
            this.txt_MK_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_MK_New.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_MK_New.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MK_New.BorderRadius = 10;
            this.txt_MK_New.BorderSize = 1;
            this.txt_MK_New.Location = new System.Drawing.Point(164, 227);
            this.txt_MK_New.Multiline = false;
            this.txt_MK_New.Name = "txt_MK_New";
            this.txt_MK_New.Padding = new System.Windows.Forms.Padding(7);
            this.txt_MK_New.PasswordChar = true;
            this.txt_MK_New.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MK_New.PlaceholderText = "*";
            this.txt_MK_New.Size = new System.Drawing.Size(197, 30);
            this.txt_MK_New.TabIndex = 1;
            this.txt_MK_New.Texts = "";
            this.txt_MK_New.UnderlinedStyle = false;
            this.txt_MK_New.Visible = false;
            this.txt_MK_New.Load += new System.EventHandler(this.textBoxCustom2_03_Load);
            // 
            // txt_XacNhan_MK
            // 
            this.txt_XacNhan_MK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_XacNhan_MK.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_XacNhan_MK.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_XacNhan_MK.BorderRadius = 10;
            this.txt_XacNhan_MK.BorderSize = 1;
            this.txt_XacNhan_MK.Location = new System.Drawing.Point(164, 302);
            this.txt_XacNhan_MK.Multiline = false;
            this.txt_XacNhan_MK.Name = "txt_XacNhan_MK";
            this.txt_XacNhan_MK.Padding = new System.Windows.Forms.Padding(7);
            this.txt_XacNhan_MK.PasswordChar = false;
            this.txt_XacNhan_MK.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_XacNhan_MK.PlaceholderText = "";
            this.txt_XacNhan_MK.Size = new System.Drawing.Size(197, 30);
            this.txt_XacNhan_MK.TabIndex = 1;
            this.txt_XacNhan_MK.Texts = "";
            this.txt_XacNhan_MK.UnderlinedStyle = false;
            this.txt_XacNhan_MK.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(104)))), ((int)(((byte)(195)))));
            this.label2.Location = new System.Drawing.Point(90, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(104)))), ((int)(((byte)(195)))));
            this.label3.Location = new System.Drawing.Point(38, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã xác nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(104)))), ((int)(((byte)(195)))));
            this.label4.Location = new System.Drawing.Point(29, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(104)))), ((int)(((byte)(195)))));
            this.label5.Location = new System.Drawing.Point(-1, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập lại mật khảu";
            // 
            // buttonCustom1
            // 
            this.buttonCustom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(135)))), ((int)(((byte)(127)))));
            this.buttonCustom1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(135)))), ((int)(((byte)(127)))));
            this.buttonCustom1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom1.BorderRadius = 20;
            this.buttonCustom1.BorderSize = 0;
            this.buttonCustom1.FlatAppearance.BorderSize = 0;
            this.buttonCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustom1.ForeColor = System.Drawing.Color.White;
            this.buttonCustom1.Location = new System.Drawing.Point(164, 362);
            this.buttonCustom1.Name = "buttonCustom1";
            this.buttonCustom1.Size = new System.Drawing.Size(197, 37);
            this.buttonCustom1.TabIndex = 2;
            this.buttonCustom1.Text = "Xác nhận";
            this.buttonCustom1.TextColor = System.Drawing.Color.White;
            this.buttonCustom1.UseVisualStyleBackColor = false;
            this.buttonCustom1.Click += new System.EventHandler(this.buttonCustom1_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(104)))), ((int)(((byte)(195)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(367, 82);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(41, 38);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(104)))), ((int)(((byte)(195)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(367, 152);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(41, 38);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // FrmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(407, 432);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.buttonCustom1);
            this.Controls.Add(this.txt_XacNhan_MK);
            this.Controls.Add(this.txt_MK_New);
            this.Controls.Add(this.txt_OTP);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuenMatKhau";
            this.Text = "FrmQuenMatKhau";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQuenMatKhau_FormClosing);
            this.Load += new System.EventHandler(this.FrmQuenMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CustomControl.TextBoxCustom2_0 txt_Email;
        private CustomControl.TextBoxCustom2_0 txt_OTP;
        private CustomControl.TextBoxCustom2_0 txt_MK_New;
        private CustomControl.TextBoxCustom2_0 txt_XacNhan_MK;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CustomControl.ButtonCustom buttonCustom1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}