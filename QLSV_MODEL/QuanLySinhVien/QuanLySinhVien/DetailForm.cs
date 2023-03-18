using QuanLySinhVien.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
            DetailFormController.Instance.Init(tbMaSinhVien, tbTen, tbDiemTrungBinh, dtpNgaySinh, cobLopSinhHoat, rbNam, cbAnh, cbHocBa, cbCCCD);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DetailFormController.Instance.AddOrUpdate();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
