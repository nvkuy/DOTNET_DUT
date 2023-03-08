using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO_CONNECT_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string _connectionString = "server=LAPTOP-7BLM86RC\\SQLEXPRESS;database=QuanLySinhVien;integrated security = SSPI";
            SqlConnection cnn = new SqlConnection(_connectionString);
            cnn.Open();

            string sql_query = "SELECT * FROM SINHVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sql_query, cnn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "SV");

            cnn.Close();*/

            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@name";
            sqlParameter.Value = textBox1.Text;
            string sql_query = "SELECT * FROM SINHVIEN WHERE HOTEN = @name";
            dataGridView1.DataSource = DBHelper.Instance.query("SELECT * FROM SINHVIEN");

        }
    }
}
