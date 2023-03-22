namespace _3_GUI_PresentationLayer.View
{
    partial class FrmHangLaptop
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            textBoxCustom2_01 = new CustomControl.TextBoxCustom2_0();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 238);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(259, 232);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(iconButton5);
            panel2.Controls.Add(iconButton3);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(textBoxCustom2_01);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(294, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 237);
            panel2.TabIndex = 1;
            // 
            // iconButton3
            // 
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Pen;
            iconButton3.IconColor = Color.FromArgb(61, 39, 76);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 45;
            iconButton3.Location = new Point(62, 177);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(53, 37);
            iconButton3.TabIndex = 18;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton2.IconColor = Color.FromArgb(61, 39, 76);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 45;
            iconButton2.Location = new Point(7, 177);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(53, 37);
            iconButton2.TabIndex = 17;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxCustom2_01
            // 
            textBoxCustom2_01.BorderColor = Color.MediumSlateBlue;
            textBoxCustom2_01.BorderFocusColor = Color.HotPink;
            textBoxCustom2_01.BorderRadius = 10;
            textBoxCustom2_01.BorderSize = 1;
            textBoxCustom2_01.Location = new Point(13, 113);
            textBoxCustom2_01.Multiline = false;
            textBoxCustom2_01.Name = "textBoxCustom2_01";
            textBoxCustom2_01.Padding = new Padding(7);
            textBoxCustom2_01.PasswordChar = false;
            textBoxCustom2_01.PlaceholderColor = Color.DarkGray;
            textBoxCustom2_01.PlaceholderText = "";
            textBoxCustom2_01.Size = new Size(200, 30);
            textBoxCustom2_01.TabIndex = 1;
            textBoxCustom2_01.Texts = "";
            textBoxCustom2_01.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(66, 35);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 0;
            label3.Text = "1234";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 35);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 90);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên hãng";
            // 
            // iconButton5
            // 
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconButton5.IconColor = Color.FromArgb(61, 39, 76);
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 45;
            iconButton5.Location = new Point(171, 177);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(53, 37);
            iconButton5.TabIndex = 19;
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton1.IconColor = Color.FromArgb(61, 39, 76);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 45;
            iconButton1.Location = new Point(121, 177);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(53, 37);
            iconButton1.TabIndex = 19;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // FrmHangLaptop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(550, 262);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmHangLaptop";
            Text = "FrmHangLaptop";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private CustomControl.TextBoxCustom2_0 textBoxCustom2_01;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton5;
    }
}