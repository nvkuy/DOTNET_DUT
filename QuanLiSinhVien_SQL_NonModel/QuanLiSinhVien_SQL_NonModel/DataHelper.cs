using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_SQL_NonModel
{
    public class DataHelper
    {

        private static DataHelper instance;
        private static SqlConnection conn;

        public static DataHelper Instance {
            get
            {
                if (instance == null)
                    instance = new DataHelper();
                return instance;
            }
            private set { }
        }

        private string getConnectString()
        {
            var DbCStringBuilder = new SqlConnectionStringBuilder();
            DbCStringBuilder["Server"] = "127.0.0.1,1433";
            DbCStringBuilder["Database"] = "QuanLySinhVien";
            DbCStringBuilder["User Id"] = "LoveLGK";
            DbCStringBuilder["Password"] = "secuoikhanh10namnua";
            return DbCStringBuilder.ToString();
        }

        private DataHelper()
        {
            conn = new SqlConnection(getConnectString());
        }

        public DataTable readData(string query, List<SqlParameter> sqlParameters)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, conn);
            foreach (var sp in sqlParameters)
                cmd.Parameters.Add(sp);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool updateData(string query, List<SqlParameter> sqlParameters)
        {
            bool success = false;

            SqlCommand sqlCommand = new SqlCommand(query, conn);
            foreach (var sp in sqlParameters)
                sqlCommand.Parameters.Add(sp);
            conn.Open();
            success = sqlCommand.ExecuteNonQuery() > 0;
            conn.Close();

            return success;
        }

    }
}
