using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiBaoKhoaHoc
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
            foreach (ComboBoxItem item in QLCTKH.GetLoaiTapChi(true))
            {
                cobLoaiTapChi.Items.Add(item);
            }
            cobLoaiTapChi.SelectedIndex = 0;
            foreach (ComboBoxItem item in QLCTKH.GetNXB(true))
            {
                cobNhaXB.Items.Add(item);
            }
            cobNhaXB.SelectedIndex = 0;
        }

        private void display()
        {
            dgvBaiBao.DataSource = null;
            dgvBaiBao.DataSource = QLCTKH.GetBaiBao(tbTimTen.Text, ((ComboBoxItem)(cobLoaiTapChi.SelectedItem)).Value.ToString(), tbNamXB.Text.Trim(), ((ComboBoxItem)(cobNhaXB.SelectedItem)).Value.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            display();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvBaiBao.SelectedRows.Count == 0) return;
            string MaBaiBao = dgvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
            QLCTKH.DelBaiBao(MaBaiBao);
            display();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBaiBao.SelectedRows.Count == 0) return;
            string MaBaiBao = dgvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
            string TenBaiBao = dgvBaiBao.SelectedRows[0].Cells["TenBaiBao"].Value.ToString();
            string TenTacGia = dgvBaiBao.SelectedRows[0].Cells["TenTacGia"].Value.ToString();
            string LoaiTapChi = dgvBaiBao.SelectedRows[0].Cells["TenLoaiTapChi"].Value.ToString();
            string TenTapChi = dgvBaiBao.SelectedRows[0].Cells["TenTapChi"].Value.ToString();
            string NamXB = dgvBaiBao.SelectedRows[0].Cells["NamXuatBan"].Value.ToString();
            string NhaXB = dgvBaiBao.SelectedRows[0].Cells["TenNXB"].Value.ToString();
            AddAndEditForm f = new AddAndEditForm();
            this.Hide();
            f.display(MaBaiBao, TenBaiBao, TenTacGia, LoaiTapChi, TenTapChi, NamXB, NhaXB);
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
    }
}
