using DEMO_3_LAYER.BLL;
using DEMO_3_LAYER.DTO;
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

namespace DEMO_3_LAYER
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
            DisplayClassList();
            DisplayStudentList();
        }

        private void DisplayClassList()
        {
            List<LSH> ls = QLSV_BLL.GetAllClass();
            foreach (LSH l in ls) cobLopSinhHoat.Items.Add(l.ClassID);
            cobLopSinhHoat.SelectedIndex = 0;
        }

        private void DisplayStudentList()
        {
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = QLSV_BLL.GetStudentByClass(new LSH(cobLopSinhHoat.SelectedItem.ToString()));
        }

        private void cobLopSinhHoat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobLopSinhHoat.SelectedIndex >= 0)
            {
                DisplayStudentList();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                QLSV_BLL.DelStudent((SinhVien)dgvSinhVien.SelectedRows[0].DataBoundItem);
                DisplayStudentList();
            }
        }
    }
}
