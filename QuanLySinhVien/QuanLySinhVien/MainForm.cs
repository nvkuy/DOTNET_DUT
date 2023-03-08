using QuanLySinhVien.Controller;
using QuanLySinhVien.Model;
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
            MainFormController.Instance.Init(dgSinhVien, cobLopSinhHoat, tbTimKiem, cobThuocTinh);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            MainFormController.Instance.SearchStudent();
        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            this.Hide();
            DetailFormController.Instance.UpdateView(MainFormController.Instance.getSelectedStudent());
            detailForm.ShowDialog();
            this.Show();
            MainFormController.Instance.SearchStudent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MainFormController.Instance.DelStudent();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            MainFormController.Instance.SortStudent();
        }
    }
}
