using SecurityPanel.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityPanel
{
    public partial class AppForm : Form
    {

        public AppForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            AppController.Instance.Init(txtPass, dgLoginHistory);
        }

        private void btnNumClick(object sender, EventArgs e)
        {
            Button tmp = (Button) sender;
            AppController.Instance.Type(tmp.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AppController.Instance.Erase();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            AppController.Instance.AttemptLogin();
        }
    }
}
