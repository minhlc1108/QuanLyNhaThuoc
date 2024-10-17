using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }


        private void Load_Form(object sender, EventArgs e)
        {
            lsvThemHoaDon.Columns[0].Width = (int)(lsvThemHoaDon.Width * 0.2);
            lsvThemHoaDon.Columns[1].Width = (int)(lsvThemHoaDon.Width * 0.2);
            lsvThemHoaDon.Columns[2].Width = (int)(lsvThemHoaDon.Width * 0.2);
            lsvThemHoaDon.Columns[3].Width = (int)(lsvThemHoaDon.Width * 0.2);
            lsvThemHoaDon.Columns[4].Width = (int)(lsvThemHoaDon.Width * 0.2);
            lsvThemHoaDon.View = View.Details;
            lsvThemHoaDon.GridLines = true;
            lsvThemHoaDon.FullRowSelect = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoMoiKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panelHoaDon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lsvThemHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
