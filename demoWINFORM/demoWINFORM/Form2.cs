using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace demoWINFORM
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            initLV();
        }

        private void initLV()
        {
            lvSinhVien.Columns.AddRange(new ColumnHeader[]
            {
                new ColumnHeader(Text = "MSV"),
                new ColumnHeader(Text = "Ten"),
                new ColumnHeader(Text = "DTB")
            });

            ListViewItem lvi1 = new ListViewItem();
            lvi1.Text = "101";
            lvi1.SubItems.Add("ABC");
            lvi1.SubItems.Add("2.3");

            ListViewItem lvi2 = new ListViewItem();
            lvi2.Text = "102";
            lvi2.SubItems.Add("XYZ");
            lvi2.SubItems.Add("2.3");

            lvSinhVien.Items.AddRange(new ListViewItem[] {lvi1, lvi2});
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            string s = "";
            foreach(ListViewItem i in lvSinhVien.SelectedItems)
            {
                s += i.Text + " " + i.SubItems[1].Text + " " + i.SubItems[2].Text + "\n";
            }
            MessageBox.Show(s);
        }
    }
}
