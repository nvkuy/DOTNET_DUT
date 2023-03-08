using QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.View
{
    public class DetailFormView
    {

        private TextBox tbMSV, tbTen, tbDTB;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cobLop;
        private RadioButton rbGioiTinh;
        private CheckBox cbAnh, cbHB, cbCCCD;

        private DetailFormView() { }

        private static DetailFormView instance;

        public static DetailFormView Instance
        {
            get
            {
                if (instance == null)
                    instance = new DetailFormView();
                return instance;
            }
        }

        public void Init(TextBox msv, TextBox ten, TextBox dtb, DateTimePicker ns, ComboBox lop, RadioButton gt, CheckBox anh, CheckBox hb, CheckBox cccd)
        {
            tbMSV = msv;
            tbTen = ten;
            tbDTB = dtb;
            dtpNgaySinh = ns;
            cbAnh = anh;
            cbHB = hb;
            cbCCCD = cccd;
            cobLop = lop;
            rbGioiTinh = gt;
        }

        public void DisplayStudent(SinhVien s)
        {
            if (s.MSV == null) return;
            tbMSV.Text = s.MSV;
            tbTen.Text = s.Ten;
            tbDTB.Text = s.DTB.ToString();
            dtpNgaySinh.Value = s.NgaySinh;
            cbAnh.Checked = s.CoAnh;
            cbCCCD.Checked = s.CoCCCD;
            cbHB.Checked = s.CoHocBa;
            cobLop.SelectedItem = s.Lop;
            rbGioiTinh.Checked = s.GioiTinh;

        }

        public SinhVien GetStudent() {
            SinhVien s = new SinhVien("");
            try
            {
                s.MSV = tbMSV.Text;
                s.Ten = tbTen.Text;
                s.DTB = Double.Parse(tbDTB.Text, 0);
                s.NgaySinh = dtpNgaySinh.Value;
                s.CoAnh = cbAnh.Checked;
                s.CoCCCD = cbCCCD.Checked;
                s.CoHocBa = cbHB.Checked;
                s.Lop = cobLop.SelectedItem.ToString();
                s.GioiTinh = rbGioiTinh.Checked;
            }
            catch { }
            return s;
        }

        public void ShowMes(String mes)
        {
            MessageBox.Show(mes);
        }

    }
}
