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
            label1 = new Label();
            txt_Email = new CustomControl.TextBoxCustom2_0();
            txt_OTP = new CustomControl.TextBoxCustom2_0();
            txt_MK_New = new CustomControl.TextBoxCustom2_0();
            txt_XacNhan_MK = new CustomControl.TextBoxCustom2_0();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonCustom1 = new CustomControl.ButtonCustom();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(86, 104, 195);
            label1.Location = new Point(143, 10);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 0;
            label1.Text = "Lấy lại mật khẩu";
            // 
            // txt_Email
            // 
            txt_Email.BackColor = Color.FromArgb(204, 204, 204);
            txt_Email.BorderColor = Color.MediumSlateBlue;
            txt_Email.BorderFocusColor = Color.HotPink;
            txt_Email.BorderRadius = 10;
            txt_Email.BorderSize = 1;
            txt_Email.Location = new Point(164, 85);
            txt_Email.Multiline = false;
            txt_Email.Name = "txt_Email";
            txt_Email.Padding = new Padding(7);
            txt_Email.PasswordChar = false;
            txt_Email.PlaceholderColor = Color.DarkGray;
            txt_Email.PlaceholderText = "";
            txt_Email.Size = new Size(197, 30);
            txt_Email.TabIndex = 1;
            txt_Email.Texts = "";
            txt_Email.UnderlinedStyle = false;
            // 
            // txt_OTP
            // 
            txt_OTP.BackColor = Color.FromArgb(204, 204, 204);
            txt_OTP.BorderColor = Color.MediumSlateBlue;
            txt_OTP.BorderFocusColor = Color.HotPink;
            txt_OTP.BorderRadius = 10;
            txt_OTP.BorderSize = 1;
            txt_OTP.Location = new Point(164, 157);
            txt_OTP.Multiline = false;
            txt_OTP.Name = "txt_OTP";
            txt_OTP.Padding = new Padding(7);
            txt_OTP.PasswordChar = false;
            txt_OTP.PlaceholderColor = Color.DarkGray;
            txt_OTP.PlaceholderText = "";
            txt_OTP.Size = new Size(197, 30);
            txt_OTP.TabIndex = 1;
            txt_OTP.Texts = "";
            txt_OTP.UnderlinedStyle = false;
            // 
            // txt_MK_New
            // 
            txt_MK_New.BackColor = Color.FromArgb(204, 204, 204);
            txt_MK_New.BorderColor = Color.MediumSlateBlue;
            txt_MK_New.BorderFocusColor = Color.HotPink;
            txt_MK_New.BorderRadius = 10;
            txt_MK_New.BorderSize = 1;
            txt_MK_New.Location = new Point(164, 227);
            txt_MK_New.Multiline = false;
            txt_MK_New.Name = "txt_MK_New";
            txt_MK_New.Padding = new Padding(7);
            txt_MK_New.PasswordChar = true;
            txt_MK_New.PlaceholderColor = Color.DarkGray;
            txt_MK_New.PlaceholderText = "*";
            txt_MK_New.Size = new Size(197, 30);
            txt_MK_New.TabIndex = 1;
            txt_MK_New.Texts = "";
            txt_MK_New.UnderlinedStyle = false;
            txt_MK_New.Visible = false;
            txt_MK_New.Load += textBoxCustom2_03_Load;
            // 
            // txt_XacNhan_MK
            // 
            txt_XacNhan_MK.BackColor = Color.FromArgb(204, 204, 204);
            txt_XacNhan_MK.BorderColor = Color.MediumSlateBlue;
            txt_XacNhan_MK.BorderFocusColor = Color.HotPink;
            txt_XacNhan_MK.BorderRadius = 10;
            txt_XacNhan_MK.BorderSize = 1;
            txt_XacNhan_MK.Location = new Point(164, 302);
            txt_XacNhan_MK.Multiline = false;
            txt_XacNhan_MK.Name = "txt_XacNhan_MK";
            txt_XacNhan_MK.Padding = new Padding(7);
            txt_XacNhan_MK.PasswordChar = true;
            txt_XacNhan_MK.PlaceholderColor = Color.DarkGray;
            txt_XacNhan_MK.PlaceholderText = "";
            txt_XacNhan_MK.Size = new Size(197, 30);
            txt_XacNhan_MK.TabIndex = 1;
            txt_XacNhan_MK.Texts = "";
            txt_XacNhan_MK.UnderlinedStyle = false;
            txt_XacNhan_MK.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(86, 104, 195);
            label2.Location = new Point(90, 94);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(86, 104, 195);
            label3.Location = new Point(38, 166);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 0;
            label3.Text = "Mã xác nhận";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(86, 104, 195);
            label4.Location = new Point(29, 236);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(86, 104, 195);
            label5.Location = new Point(-1, 311);
            label5.Name = "label5";
            label5.Size = new Size(139, 21);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại mật khảu";
            // 
            // buttonCustom1
            // 
            buttonCustom1.BackColor = Color.FromArgb(2, 135, 127);
            buttonCustom1.BackgroundColor = Color.FromArgb(2, 135, 127);
            buttonCustom1.BorderColor = Color.PaleVioletRed;
            buttonCustom1.BorderRadius = 20;
            buttonCustom1.BorderSize = 0;
            buttonCustom1.FlatAppearance.BorderSize = 0;
            buttonCustom1.FlatStyle = FlatStyle.Flat;
            buttonCustom1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCustom1.ForeColor = Color.White;
            buttonCustom1.Location = new Point(164, 362);
            buttonCustom1.Name = "buttonCustom1";
            buttonCustom1.Size = new Size(197, 37);
            buttonCustom1.TabIndex = 2;
            buttonCustom1.Text = "Xác nhận";
            buttonCustom1.TextColor = Color.White;
            buttonCustom1.UseVisualStyleBackColor = false;
            buttonCustom1.Click += buttonCustom1_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(204, 204, 204);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            iconButton1.IconColor = Color.FromArgb(86, 104, 195);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(367, 82);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(0, 3, 0, 0);
            iconButton1.Size = new Size(41, 38);
            iconButton1.TabIndex = 3;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(204, 204, 204);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconButton2.IconColor = Color.FromArgb(86, 104, 195);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(367, 152);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(0, 3, 0, 0);
            iconButton2.Size = new Size(41, 38);
            iconButton2.TabIndex = 3;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // FrmQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(204, 204, 204);
            ClientSize = new Size(407, 432);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(buttonCustom1);
            Controls.Add(txt_XacNhan_MK);
            Controls.Add(txt_MK_New);
            Controls.Add(txt_OTP);
            Controls.Add(txt_Email);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmQuenMatKhau";
            Text = "FrmQuenMatKhau";
            FormClosing += FrmQuenMatKhau_FormClosing;
            Load += FrmQuenMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
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