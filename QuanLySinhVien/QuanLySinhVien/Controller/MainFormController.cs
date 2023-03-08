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

        public void Init(DataGridView dg, ComboBox cb, TextBox tb, ComboBox tt)
        {
            MainFormView.Instance.Init(dg, cb, tb, tt);
            DataHelper.Instance.ReadAllData();
        }

        public void SearchStudent()
        {
            if (MainFormView.Instance.GetClassCode().Length == 0) return;
            List<SinhVien> tmp = DataHelper.Instance.SearchByName(MainFormView.Instance.GetClassCode(), MainFormView.Instance.GetCurSearch());
            MainFormView.Instance.ShowStudentList(tmp);
        }

        public SinhVien getSelectedStudent()
        {
            SinhVien s = new SinhVien("");
            List<SinhVien> tmp = MainFormView.Instance.GetSelectedList();
            if (tmp.Count == 1)
                s = tmp[0];
            return s;
        }

        public void DelStudent()
        {
            List<SinhVien> ls = MainFormView.Instance.GetSelectedList();
            DataHelper.Instance.DelStudent(ls);
            DataHelper.Instance.SaveData();
            SearchStudent();
        }

        public void SortStudent()
        {
            DataHelper.CMP mCMP = DataHelper.CmpByName;
            switch (MainFormView.Instance.GetSortMode())
            {
                case 1:
                    mCMP = DataHelper.CmpByDTB;
                    break;
                case 2:
                    mCMP = DataHelper.CmpByDTB;
                    break;
            }
            List<SinhVien> tmp = MainFormView.Instance.GetCurrentStudentList();
            if (tmp != null)
                DataHelper.Instance.SortLR(0, tmp.Count - 1, tmp, mCMP);
            MainFormView.Instance.ShowStudentList(tmp);
        }

    }
}
