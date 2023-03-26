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
            iconButton8 = new FontAwesome.Sharp.IconButton();
            textBoxCustom2_04 = new CustomControl.TextBoxCustom2_0();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            buttonCustom1 = new CustomControl.ButtonCustom();
            textBoxCustom2_01 = new CustomControl.TextBoxCustom2_0();
            iconButton12 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // iconButton8
            // 
            iconButton8.BackColor = Color.White;
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 23;
            iconButton8.Location = new Point(12, 12);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(32, 25);
            iconButton8.TabIndex = 49;
            iconButton8.UseVisualStyleBackColor = false;
            // 
            // textBoxCustom2_04
            // 
            textBoxCustom2_04.BackColor = Color.White;
            textBoxCustom2_04.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2_04.BorderFocusColor = Color.HotPink;
            textBoxCustom2_04.BorderRadius = 10;
            textBoxCustom2_04.BorderSize = 1;
            textBoxCustom2_04.Location = new Point(6, 8);
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(12, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 216);
            panel1.TabIndex = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(284, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 154);
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // buttonCustom1
            // 
            buttonCustom1.BackColor = Color.MediumSlateBlue;
            buttonCustom1.BackgroundColor = Color.MediumSlateBlue;
            buttonCustom1.BorderColor = Color.PaleVioletRed;
            buttonCustom1.BorderRadius = 10;
            buttonCustom1.BorderSize = 0;
            buttonCustom1.FlatAppearance.BorderSize = 0;
            buttonCustom1.FlatStyle = FlatStyle.Flat;
            buttonCustom1.ForeColor = Color.White;
            buttonCustom1.Location = new Point(331, 172);
            buttonCustom1.Name = "buttonCustom1";
            buttonCustom1.Size = new Size(150, 33);
            buttonCustom1.TabIndex = 52;
            buttonCustom1.Text = "Bật camera";
            buttonCustom1.TextColor = Color.White;
            buttonCustom1.UseVisualStyleBackColor = false;
            // 
            // textBoxCustom2_01
            // 
            textBoxCustom2_01.BackColor = Color.FromArgb(244, 245, 255);
            textBoxCustom2_01.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2_01.BorderFocusColor = Color.HotPink;
            textBoxCustom2_01.BorderRadius = 0;
            textBoxCustom2_01.BorderSize = 2;
            textBoxCustom2_01.Location = new Point(284, 238);
            textBoxCustom2_01.Multiline = false;
            textBoxCustom2_01.Name = "textBoxCustom2_01";
            textBoxCustom2_01.Padding = new Padding(7);
            textBoxCustom2_01.PasswordChar = false;
            textBoxCustom2_01.PlaceholderColor = Color.DarkGray;
            textBoxCustom2_01.PlaceholderText = "";
            textBoxCustom2_01.Size = new Size(184, 30);
            textBoxCustom2_01.TabIndex = 53;
            textBoxCustom2_01.Texts = "";
            textBoxCustom2_01.UnderlinedStyle = true;
            // 
            // iconButton12
            // 
            iconButton12.BackColor = Color.FromArgb(244, 245, 255);
            iconButton12.FlatAppearance.BorderSize = 0;
            iconButton12.FlatStyle = FlatStyle.Flat;
            iconButton12.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            iconButton12.IconColor = Color.FromArgb(115, 176, 244);
            iconButton12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton12.IconSize = 28;
            iconButton12.Location = new Point(474, 232);
            iconButton12.Name = "iconButton12";
            iconButton12.Padding = new Padding(0, 4, 0, 0);
            iconButton12.Size = new Size(43, 36);
            iconButton12.TabIndex = 54;
            iconButton12.UseVisualStyleBackColor = false;
            // 
            // FrmImei
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(527, 282);
            Controls.Add(iconButton12);
            Controls.Add(textBoxCustom2_01);
            Controls.Add(buttonCustom1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(iconButton8);
            Controls.Add(textBoxCustom2_04);
            Name = "FrmImei";
            Text = "Nhập Imei";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton8;
        private CustomControl.TextBoxCustom2_0 textBoxCustom2_04;
        private Panel panel1;
        private PictureBox pictureBox1;
        private CustomControl.ButtonCustom buttonCustom1;
        private CustomControl.TextBoxCustom2_0 textBoxCustom2_01;
        private FontAwesome.Sharp.IconButton iconButton12;
    }
}