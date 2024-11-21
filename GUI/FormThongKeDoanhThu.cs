﻿using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class FormThongKeDoanhThu : Form
    {
        public FormThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            dateBatDau.MaxDate = DateTime.Now;
            dateKetThuc.MaxDate = DateTime.Now;
            dateBatDau.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dateKetThuc.Value = dateKetThuc.MaxDate;


        }

        private void tblThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime dateBD = dateBatDau.Value;
            DateTime dateKT = dateKetThuc.Value;
            if ( dateBD > dateKT)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show(dateBD.ToString() + " - " + dateKetThuc.ToString() );

        }
    }
}
