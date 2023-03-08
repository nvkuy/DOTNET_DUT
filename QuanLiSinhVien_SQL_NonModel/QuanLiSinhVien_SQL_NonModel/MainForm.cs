using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_SQL_NonModel
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            initDisplay();
        }

        private void initDisplay()
        {
            cobLopSinhHoat.Items.Clear();
            foreach (DataRow row in BusinessHandle.Instance.getAllClass().Rows) {
                cobLopSinhHoat.Items.Add(row["MaLop"]);
            }
            cobLopSinhHoat.SelectedIndex = 0;
            cobThuocTinh.SelectedIndex = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgSinhVien.DataSource = null;
            dgSinhVien.DataSource = BusinessHandle.Instance.getStudent(cobLopSinhHoat.SelectedItem.ToString(), tbTimKiem.Text);
        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            this.Hide();
            if (dgSinhVien.SelectedRows.Count > 0)
                detailForm.setUpdateMode(((DataRowView)dgSinhVien.SelectedRows[0].DataBoundItem).Row);
            detailForm.ShowDialog();
            this.Show();
            dgSinhVien.DataSource = null;
            dgSinhVien.DataSource = BusinessHandle.Instance.getStudent(cobLopSinhHoat.SelectedItem.ToString(), tbTimKiem.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgSinhVien.SelectedRows.Count > 0)
            {
                BusinessHandle.Instance.delStudent(dgSinhVien.SelectedRows[0].Cells["MSV"].Value.ToString());
                dgSinhVien.DataSource = null;
                dgSinhVien.DataSource = BusinessHandle.Instance.getStudent(cobLopSinhHoat.SelectedItem.ToString(), tbTimKiem.Text);
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            dgSinhVien.DataSource = null;
            dgSinhVien.DataSource = BusinessHandle.Instance.getStudent(cobLopSinhHoat.SelectedItem.ToString(), tbTimKiem.Text, cobThuocTinh.SelectedItem.ToString());
        }
    }
}
