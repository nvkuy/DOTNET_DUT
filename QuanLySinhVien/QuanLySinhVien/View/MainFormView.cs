using QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.View
{
    public class MainFormView
    {

        private DataGridView dgSinhVien;

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

        public void Init(DataGridView dg)
        {
            dgSinhVien = dg;
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

    }
}
