using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_CONNECT_SQL
{
    public class DBHelper
    {
        private static DBHelper instance;
        private SqlConnection cnn;
        private SqlCommand cmd;

        private DBHelper()
        {
            cnn = new SqlConnection("server=LAPTOP-7BLM86RC\\SQLEXPRESS;database=QuanLySinhVien;integrated security = SSPI");
        }

        public static DBHelper Instance
        {
            get { 
                if (instance == null)
                    instance = new DBHelper();
                return instance;
            }
            private set { }
        }

        public DataTable query(SqlCommand qr)
        {
            cnn.Open();
            cmd.CommandText = qr.CommandText;
            
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            cnn.Close();
            return dt;
        }

        public void update(SqlCommand qr)
        {
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
