using SecurityPanel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityPanel.View
{
    public class AppView
    {
        private TextBox tbPass;
        private DataGridView dgLoginHistory;

        private AppView() { }

        private static AppView instance;

        public static AppView Instance
        {
            get
            {
                if (instance == null)
                    instance = new AppView();
                return instance;
            }
        }

        public void Init(TextBox tb, DataGridView dg)
        {
            tbPass = tb;
            dgLoginHistory = dg;
        }

        public void DisplayPassword(string pass) {
            tbPass.Text = pass;
        }

        public void DisplayLoginHistory(List<LoginAttempt> data)
        {
            dgLoginHistory.DataSource = null;
            dgLoginHistory.DataSource = data;
        }

    }
}
