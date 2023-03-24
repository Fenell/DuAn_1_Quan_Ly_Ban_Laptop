namespace _3_GUI_PresentationLayer.View
{
    partial class FrmHome
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
            components = new System.ComponentModel.Container();
            lblClock = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.FlatStyle = FlatStyle.Flat;
            lblClock.Font = new Font("Adidas 2018 font . King sport (", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblClock.ForeColor = Color.FromArgb(186, 197, 216);
            lblClock.Location = new Point(605, 544);
            lblClock.Margin = new Padding(3, 0, 0, 0);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(77, 120);
            lblClock.TabIndex = 0;
            lblClock.Text = " ";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(648, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 351);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(244, 245, 255);
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(89, 62, 103);
            label3.Location = new Point(365, 21);
            label3.Name = "label3";
            label3.Size = new Size(950, 86);
            label3.TabIndex = 3;
            label3.Text = "Quản lý bán Laptop và Linh kiện";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(1537, 729);
            Controls.Add(lblClock);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHome";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClock;
        private PictureBox pictureBox1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}