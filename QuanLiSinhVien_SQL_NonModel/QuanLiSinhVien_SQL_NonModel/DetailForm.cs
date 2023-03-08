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
    public partial class DetailForm : Form
    {

        private bool updateMode = false;

        public DetailForm()
        {
            InitializeComponent();
            initDisplay();
        }

        private void initDisplay()
        {
            cobLopSinhHoat.Items.Clear();
            foreach (DataRow row in BusinessHandle.Instance.getAllClass().Rows)
            {
                cobLopSinhHoat.Items.Add(row["MaLop"]);
            }
            cobLopSinhHoat.SelectedIndex = 0;
        }

        public void setUpdateMode(DataRow row)
        {
            updateMode = true;
            tbMaSinhVien.Text = row["MSV"].ToString();
            tbTen.Text = row["Ten"].ToString();
            cobLopSinhHoat.SelectedIndex = cobLopSinhHoat.Items.IndexOf(row["Lop"]);
            dtpNgaySinh.Value = DateTime.Parse(row["NgaySinh"].ToString());
            tbDiemTrungBinh.Text = row["DTB"].ToString();
            rbNam.Checked = Boolean.Parse(row["Nam"].ToString());
            cbAnh.Checked = Boolean.Parse(row["CoAnh"].ToString());
            cbHocBa.Checked = Boolean.Parse(row["CoHocBa"].ToString());
            cbCCCD.Checked = Boolean.Parse(row["CoCCCD"].ToString());
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataRow row = BusinessHandle.Instance.dataTable.NewRow();
            row["MSV"] = tbMaSinhVien.Text;
            row["Ten"] = tbTen.Text;
            row["Lop"] = cobLopSinhHoat.SelectedItem.ToString();
            row["NgaySinh"] = dtpNgaySinh.Value;
            row["DTB"] = tbDiemTrungBinh.Text;
            row["Nam"] = rbNam.Checked;
            row["CoAnh"] = cbAnh.Checked;
            row["CoHocBa"] = cbHocBa.Checked;
            row["CoCCCD"] = cbCCCD.Checked;
            bool isOk = updateMode ? BusinessHandle.Instance.updateStudent(row) : BusinessHandle.Instance.insertStudent(row);
            if (!isOk) MessageBox.Show("Thông tin không hợp lệ!");
            Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
