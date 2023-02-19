using SecurityPanel.Model;
using SecurityPanel.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityPanel.Controller
{
    public class AppController
    {
        private List<LoginAttempt> loginHistory;
        private string pass;
        private AppController() { }

        private static AppController instance;

        public static AppController Instance
        {
            get
            {
                if (instance == null)
                    instance = new AppController();
                return instance;
            }
        }

        public void Init(TextBox tb, DataGridView dg)
        {
            AppView.Instance.Init(tb, dg);
            loginHistory = DataHelper.Instance.readAllLoginHistory();
            loginHistory.Reverse();
            AppView.Instance.DisplayLoginHistory(loginHistory);
            pass = "";
        }

        public void Type(string c) {
            pass += c;
            AppView.Instance.DisplayPassword(pass);
        }

        public void Erase()
        {
            pass = "";
            AppView.Instance.DisplayPassword(pass);
        }

        public void AttemptLogin()
        {
            bool isOk = DataHelper.Instance.checkPassword(pass);
            string date = DateTime.Now.ToString();
            LoginAttempt la = new LoginAttempt(date, isOk ? "Success" : "Wrong password");
            loginHistory.Insert(0, la);
            DataHelper.Instance.appendLoginAttempt(la);
            AppView.Instance.DisplayLoginHistory(loginHistory);
        }

    }
}
