using QuanLySinhVien.Model;
using QuanLySinhVien.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.Controller
{
    public class MainFormController
    {
        private MainFormController() { }

        private static MainFormController instance;

        public static MainFormController Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainFormController();
                return instance;
            }
        }

        public void Init(DataGridView dg)
        {
            MainFormView.Instance.Init(dg);
            DataHelper.Instance.ReadAllData();
        }

        public void SearchStudent(String c, String tn)
        {
            List<SinhVien> tmp = DataHelper.Instance.SearchByName(c, tn);
            MainFormView.Instance.ShowStudentList(tmp);
        }

        public void SortStudent(int mode)
        {
            List<SinhVien> tmp = MainFormView.Instance.GetCurrentStudentList();
        }

    }
}
