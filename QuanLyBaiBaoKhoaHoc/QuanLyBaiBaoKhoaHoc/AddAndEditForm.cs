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
    public partial class AddAndEditForm : Form
    {
        public AddAndEditForm()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            foreach (ComboBoxItem item in QLCTKH.GetLoaiTapChi(false))
            {
                cobLoaiTapChi.Items.Add(item);
            }
            cobLoaiTapChi.SelectedIndex = 0;
            foreach (ComboBoxItem item in QLCTKH.GetNXB(false))
            {
                cobNhaXuatBan.Items.Add(item);
            }
            cobNhaXuatBan.SelectedIndex = 0;
        }

        private int cobIndexByText(ComboBox cob, string text)
        {
            for (int i = 0; i < cob.Items.Count; i++)
                if (((ComboBoxItem)cob.Items[i]).Text == text)
                    return i;
            return -1;
        }

        public void display(string MaBaiBao, string TenBaiBao, string TenTacGia, string LoaiTapChi, string TenTapChi, string NamXB, string NhaXB)
        {
            tbMaBaiBao.Text = MaBaiBao;
            tbTenBaiBao.Text = TenBaiBao;
            tbTacGia.Text = TenTacGia;
            cobLoaiTapChi.SelectedIndex = cobIndexByText(cobLoaiTapChi, LoaiTapChi);
            cobLoaiTapChi.SelectedIndex = cobIndexByText(cobTenTapChi, TenTapChi);
            tbNamXuatBan.Text = NamXB;
            cobNhaXuatBan.SelectedIndex = cobIndexByText(cobNhaXuatBan, NhaXB);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int year = Int32.Parse(tbNamXuatBan.Text);
                if (year > DateTime.Now.Year)
                {
                    MessageBox.Show("Năm không hợp lệ");
                    return;
                }
            } catch (FormatException)
            {
                MessageBox.Show("Lỗi định dạng năm");
            }
            QLCTKH.AddOrUpdate(tbMaBaiBao.Text, tbTenBaiBao.Text, tbTacGia.Text, ((ComboBoxItem)(cobTenTapChi.SelectedItem)).Value.ToString(), tbNamXuatBan.Text.Trim(), ((ComboBoxItem)(cobNhaXuatBan.SelectedItem)).Value.ToString());
        }

        private void cobLoaiTapChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in QLCTKH.GetTenTapChi(((ComboBoxItem)(cobLoaiTapChi.SelectedItem)).Value.ToString(), false))
            {
                cobTenTapChi.Items.Add(item);
            }
            cobTenTapChi.SelectedIndex = 0;
        }
    }
}
