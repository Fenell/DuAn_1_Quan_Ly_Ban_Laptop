namespace _3_GUI_PresentationLayer.View
{
    partial class FrmImei
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
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            textBoxCustom2_01 = new CustomControl.TextBoxCustom2_0();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            textBoxCustom2_02 = new CustomControl.TextBoxCustom2_0();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 0;
            label1.Text = "Thêm Imei";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(17, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 120);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBoxCustom2_01);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(17, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 60);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 0;
            label2.Text = "Tìm kiếm";
            // 
            // textBoxCustom2_01
            // 
            textBoxCustom2_01.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2_01.BorderFocusColor = Color.HotPink;
            textBoxCustom2_01.BorderRadius = 0;
            textBoxCustom2_01.BorderSize = 2;
            textBoxCustom2_01.Location = new Point(15, 18);
            textBoxCustom2_01.Multiline = false;
            textBoxCustom2_01.Name = "textBoxCustom2_01";
            textBoxCustom2_01.Padding = new Padding(7);
            textBoxCustom2_01.PasswordChar = false;
            textBoxCustom2_01.PlaceholderColor = Color.DarkGray;
            textBoxCustom2_01.PlaceholderText = "";
            textBoxCustom2_01.Size = new Size(188, 30);
            textBoxCustom2_01.TabIndex = 1;
            textBoxCustom2_01.Texts = "";
            textBoxCustom2_01.UnderlinedStyle = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(iconButton2);
            panel3.Controls.Add(textBoxCustom2_02);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(17, 202);
            panel3.Name = "panel3";
            panel3.Size = new Size(405, 44);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(228, 34);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 0;
            label3.Text = "Tổng: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(304, 34);
            label4.Name = "label4";
            label4.Size = new Size(19, 21);
            label4.TabIndex = 0;
            label4.Text = "2";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(2, 135, 127);
            pictureBox1.Image = Properties.Resources.icons8_microsoft_excel_80;
            pictureBox1.Location = new Point(349, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // textBoxCustom2_02
            // 
            textBoxCustom2_02.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2_02.BorderFocusColor = Color.HotPink;
            textBoxCustom2_02.BorderRadius = 0;
            textBoxCustom2_02.BorderSize = 2;
            textBoxCustom2_02.Location = new Point(96, 6);
            textBoxCustom2_02.Multiline = false;
            textBoxCustom2_02.Name = "textBoxCustom2_02";
            textBoxCustom2_02.Padding = new Padding(7);
            textBoxCustom2_02.PasswordChar = false;
            textBoxCustom2_02.PlaceholderColor = Color.DarkGray;
            textBoxCustom2_02.PlaceholderText = "";
            textBoxCustom2_02.Size = new Size(154, 30);
            textBoxCustom2_02.TabIndex = 9;
            textBoxCustom2_02.Texts = "";
            textBoxCustom2_02.UnderlinedStyle = true;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton2.IconColor = Color.FromArgb(61, 39, 76);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 45;
            iconButton2.Location = new Point(279, 6);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(53, 37);
            iconButton2.TabIndex = 18;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // FrmImei
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(434, 256);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmImei";
            Text = "FrmImei";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private CustomControl.TextBoxCustom2_0 textBoxCustom2_01;
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private PictureBox pictureBox1;
        private CustomControl.TextBoxCustom2_0 textBoxCustom2_02;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}