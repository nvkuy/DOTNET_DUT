using QuanLySinhVien.Model;
using QuanLySinhVien.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.Controller
{
    public class DetailFormController
    {
        private DetailFormController() { }

        private static DetailFormController instance;

        public static DetailFormController Instance
        {
            get
            {
                if (instance == null)
                    instance = new DetailFormController();
                return instance;
            }
        }

        public void Init(TextBox msv, TextBox ten, TextBox dtb, DateTimePicker ns, ComboBox lop, RadioButton gt, CheckBox anh, CheckBox hb, CheckBox cccd)
        {
            DetailFormView.Instance.Init(msv, ten, dtb, ns, lop, gt, anh, hb, cccd);
            DataHelper.Instance.ReadAllData();
        }

        public void UpdateView(SinhVien s) {
            DetailFormView.Instance.DisplayStudent(s);
        }

        public void AddOrUpdate()
        {
            SinhVien s = DetailFormView.Instance.GetStudent();
            if (!s.IsValidInfo())
            {
                DetailFormView.Instance.ShowMes("Thông tin sinh viên không hợp lệ");
                return;
            }
            DetailFormView.Instance.ShowMes("Thành công");
            DataHelper.Instance.AddOrUpdateStudent(s);
            DataHelper.Instance.SaveData();
        }

    }
}
