using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoWINFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private double TinhTien()
        {
            double tien = 0;
            if (cbCaoVoi.Checked) tien += 100000;
            if (cbChupHinhRang.Checked) tien += 200000;
            if (cbTayTrang.Checked) tien += 1200000;
            if (cobTramRang.SelectedIndex >= 0) tien += (Convert.ToInt32(cobTramRang.SelectedItem) * 80000);

            return tien;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (tbTen.Text.Length == 0)
                MessageBox.Show("Tên không được để trống");
            else
            {
                tbTongTien.Text = "$" + TinhTien();
            }
        }
    }
}
