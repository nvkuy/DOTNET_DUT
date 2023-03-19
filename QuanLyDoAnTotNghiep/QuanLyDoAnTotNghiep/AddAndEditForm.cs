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
    public partial class AddAndEditForm : Form
    {
        public AddAndEditForm()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            foreach (ComboBoxItem item in QLDATN.GetHuongNC(false))
            {
                cobHuongNC.Items.Add(item);
            }
            cobHuongNC.SelectedIndex = 0;
        }

        private int cobIndexByText(ComboBox cob, string text)
        {
            for (int i = 0; i < cob.Items.Count; i++)
                if (((ComboBoxItem)cob.Items[i]).Text == text)
                    return i;
            return -1;
        }

        public void display(string MaDoAn, string TenDoAn, string TenTacGia, string HuongNC, string GVHD, Boolean TinhTrang, int NamBaoVe)
        {
            tbMaDATN.Text = MaDoAn;
            tbTenDATN.Text = TenDoAn;
            tbTacGia.Text = TenTacGia;
            cobHuongNC.SelectedIndex = cobIndexByText(cobHuongNC, HuongNC);
            cobHuongNC.SelectedIndex = cobIndexByText(cobGVHD, GVHD);
            tbNamBaoVe.Text = NamBaoVe.ToString();
            rbTinhTrang.Checked = TinhTrang;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int year = Int32.Parse(tbNamBaoVe.Text);
                if (year > DateTime.Now.Year)
                {
                    MessageBox.Show("Năm không hợp lệ");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi định dạng năm");
            }
            QLDATN.AddOrUpdate(tbMaDATN.Text, tbTenDATN.Text, tbTacGia.Text, Int32.Parse(tbNamBaoVe.Text), rbTinhTrang.Checked, ((ComboBoxItem)(cobGVHD.SelectedItem)).Value.ToString());
        }

        private void cobHuongNC_SelectedIndexChanged(object sender, EventArgs e)
        {
            cobGVHD.Items.Clear();
            foreach (ComboBoxItem item in QLDATN.GetGVHD(((ComboBoxItem)(cobHuongNC.SelectedItem)).Value.ToString(), false))
            {
                cobGVHD.Items.Add(item);
            }
            cobGVHD.SelectedIndex = 0;
        }
    }
}
