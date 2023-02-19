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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainFormController.Instance.Init(dgSinhVien);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            MainFormController.Instance.SearchStudent(cobLopSinhHoat.SelectedItem.ToString(), tbTimKiem.Text);
        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            this.Hide();
            detailForm.ShowDialog();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {

        }
    }
}
