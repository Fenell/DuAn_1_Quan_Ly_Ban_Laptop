using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmSanPham : Form
    {
        private Form currentForm;
        public FrmSanPham()
        {
            InitializeComponent();
            panelUnderline1.BackColor = Color.Blue;
            btnLaptop.BorderColor = Color.White;
            btnLaptop.BorderRadius = 0;
            OpenChildForm(new FrmLaptop());
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelSanPham.Controls.Clear();
            panelSanPham.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLinhKien_Click(object sender, EventArgs e)
        {
            panelUnderline1.BackColor = Color.FromArgb(240, 240, 240);
            panelUnderline2.BackColor = Color.Blue;
            OpenChildForm(new FrmLinhKien());
        }

        private void btnLaptop_Click(object sender, EventArgs e)
        {
            panelUnderline1.BackColor = Color.Blue;
            panelUnderline2.BackColor = Color.FromArgb(240, 240, 240);
            OpenChildForm(new FrmLaptop());
        }
    }
}
