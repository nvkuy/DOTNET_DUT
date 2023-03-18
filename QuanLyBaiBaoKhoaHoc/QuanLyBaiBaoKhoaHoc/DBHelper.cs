using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiBaoKhoaHoc
{
    internal class DBHelper
    {

        private static SqlConnection conn;
        private static DBHelper instance;

        public static DBHelper Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBHelper();
                return instance;
            }
            private set { }
        }

        private string getConnectString()
        {
            var DbCStringBuilder = new SqlConnectionStringBuilder();
            DbCStringBuilder["Server"] = "127.0.0.1,1433";
            DbCStringBuilder["Database"] = "QuanLyBaiBaoKhoaHoc";
            DbCStringBuilder["User Id"] = "LoveLGK";
            DbCStringBuilder["Password"] = "secuoikhanh10namnua";
            return DbCStringBuilder.ToString();
        }

        private DBHelper()
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
