using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoAnTotNghiep
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            init();
            display();
        }

        private void init()
        {
            foreach (ComboBoxItem item in QLDATN.GetHuongNC(true))
            {
                cobHuongNC.Items.Add(item);
            }
            cobHuongNC.SelectedIndex = 0;
            foreach (ComboBoxItem item in QLDATN.GetTinhTrang(true))
            {
                cobTinhTrang.Items.Add(item);
            }
            cobTinhTrang.SelectedIndex = 0;
        }

        private void display()
        {
            dgvDATN.DataSource = null;
            dgvDATN.DataSource = QLDATN.GetDATN(tbTimTen.Text, ((ComboBoxItem)(cobHuongNC.SelectedItem)).Value.ToString(), Int32.Parse(((ComboBoxItem)(cobTinhTrang.SelectedItem)).Value.ToString()), ((ComboBoxItem)(cobGVHD.SelectedItem)).Value.ToString());
            dgvDATN.Columns["MaDoAn"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            display();
        }

        private bool okDel()
        {
            string message = "Xác nhận xóa sinh viên?";
            string title = "Xóa sinh viên";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            return result == DialogResult.Yes;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvDATN.SelectedRows.Count == 0 || !okDel()) return;
            string MaDoAn = dgvDATN.SelectedRows[0].Cells["MaDoAn"].Value.ToString();
            QLDATN.DelDATN(MaDoAn);
            display();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDATN.SelectedRows.Count == 0) return;
            string MaDoAn = dgvDATN.SelectedRows[0].Cells["MaDoAn"].Value.ToString();
            string TenDoAn = dgvDATN.SelectedRows[0].Cells["TenDoAn"].Value.ToString();
            string TenTacGia = dgvDATN.SelectedRows[0].Cells["TenTacGia"].Value.ToString();
            string HuongNC = dgvDATN.SelectedRows[0].Cells["HuongNghienCuu"].Value.ToString();
            string GVHD = dgvDATN.SelectedRows[0].Cells["TenGiangVien"].Value.ToString();
            Boolean TinhTrang = Boolean.Parse(dgvDATN.SelectedRows[0].Cells["TinhTrang"].Value.ToString());
            int NamBaoVe = Int32.Parse(dgvDATN.SelectedRows[0].Cells["NamBaoVe"].Value.ToString());
            AddAndEditForm f = new AddAndEditForm();
            this.Hide();
            f.display(MaDoAn, TenDoAn, TenTacGia, HuongNC, GVHD, TinhTrang, NamBaoVe);
            f.ShowDialog();
            this.Show();
            display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAndEditForm f = new AddAndEditForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
            display();
        }

        private void cobHuongNC_SelectedIndexChanged(object sender, EventArgs e)
        {
            cobGVHD.Items.Clear();
            foreach (ComboBoxItem item in QLDATN.GetGVHD(((ComboBoxItem)(cobHuongNC.SelectedItem)).Value.ToString(), true))
            {
                cobGVHD.Items.Add(item);
            }
            cobGVHD.SelectedIndex = 0;
        }
    }
}
