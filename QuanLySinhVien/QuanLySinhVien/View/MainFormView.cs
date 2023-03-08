using QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.View
{
    public class MainFormView
    {

        private DataGridView dgSinhVien;
        private ComboBox cmbSinhVien, cmbThuocTinh;
        private TextBox txtSinhVien;

        private MainFormView() { }

        private static MainFormView instance;

        public static MainFormView Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainFormView();
                return instance;
            }
        }

        public void Init(DataGridView dg, ComboBox cb, TextBox tb, ComboBox tt)
        {
            dgSinhVien = dg;
            cmbSinhVien = cb;
            txtSinhVien = tb;
            cmbThuocTinh = tt;
        }

        public void ShowStudentList(List<SinhVien> arr)
        {
            dgSinhVien.DataSource = null;
            dgSinhVien.DataSource = arr;
        }

        public List<SinhVien> GetCurrentStudentList()
        {
            return (List<SinhVien>) dgSinhVien.DataSource;
        }

        public int GetSortMode()
        {
            return Math.Max(cmbThuocTinh.SelectedIndex, 0);
        }

        public String GetClassCode()
        {
            String res = "";
            if (cmbSinhVien.SelectedIndex >= 0) res = cmbSinhVien.SelectedItem.ToString();
            return res;
        }

        public String GetCurSearch()
        {
            return txtSinhVien.Text;
        }

        public List<SinhVien> GetSelectedList()
        {
            List<SinhVien> t1 = new List<SinhVien>();
            List<int> t2 = new List<int>();
            List<SinhVien> t3 = GetCurrentStudentList();
            if (t3 != null)
            {
                for (int i = 0; i < dgSinhVien.SelectedRows.Count; i++)
                    t2.Add(dgSinhVien.SelectedRows[i].Index);
                for (int i = 0; i < t3.Count; i++)
                {
                    if (!t2.Contains(i)) continue;
                    t1.Add(t3[i]);
                }
            }
            return t1;
        }
    }
}
