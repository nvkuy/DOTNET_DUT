using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Model
{
    public class DataHelper
    {
        private static SqlConnection conn;
        private static DataHelper instance;
        private static List<SinhVien> allStudent;
        private static List<LSH> allClass;
        public delegate bool CMP(SinhVien s1, SinhVien s2);

        public static DataHelper Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataHelper();
                return instance;
            }
            private set { }
        }

        public List<LSH> GetAllClass()
        {
            return allClass;
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
            allStudent = new List<SinhVien>();
            allClass = new List<LSH>();
        }

        private DataTable readData(string query, List<SqlParameter> sqlParameters)
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

        private bool updateData(string query, List<SqlParameter> sqlParameters)
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

        public void ReadAllData()
        {
            allStudent.Clear();
            allClass.Clear();

            String qs = "SELECT * FROM SINHVIEN";
            foreach (DataRow r in readData(qs, new List<SqlParameter>()).Rows)
            {
                allStudent.Add(new SinhVien(r));
            }

            String qc = "SELECT * FROM LSH";
            foreach (DataRow r in readData(qc, new List<SqlParameter>()).Rows)
            {
                allClass.Add(new LSH(r));
            }

        }

        private int findPosStudent(string studentID)
        {
            for (int i = 0; i < allStudent.Count; i++)
            {
                if (allStudent[i].MSV == studentID)
                    return i;
            }
            return -1;
        }

        public void AddOrUpdateStudent(SinhVien s)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MSV", s.MSV));
            parameters.Add(new SqlParameter("@Ten", s.Ten));
            parameters.Add(new SqlParameter("@Lop", s.Lop));
            parameters.Add(new SqlParameter("@NgaySinh", s.NgaySinh));
            parameters.Add(new SqlParameter("@DTB", s.DTB));
            parameters.Add(new SqlParameter("@Nam", s.GioiTinh));
            parameters.Add(new SqlParameter("@Anh", s.CoAnh));
            parameters.Add(new SqlParameter("@HB", s.CoHocBa));
            parameters.Add(new SqlParameter("@CCCD", s.CoCCCD));
            string query = "INSERT INTO SINHVIEN VALUES (" +
                "@MSV, " +
                "@Ten, " +
                "@Lop, " +
                "@NgaySinh, " +
                "@DTB, " +
                "@Nam, " +
                "@Anh, " +
                "@HB, " +
                "@CCCD " +
                ")";
            int pos = findPosStudent(s.MSV);
            if (pos >= 0)
            {
                allStudent[pos] = s;
                query = "UPDATE SINHVIEN SET " +
                    "Ten = @Ten," +
                    "Lop = @Lop," +
                    "NgaySinh = @NgaySinh," +
                    "DTB = @DTB," +
                    "Nam = @Nam," +
                    "CoAnh = @Anh," +
                    "CoHocBa = @HB," +
                    "CoCCCD = @CCCD " +
                    "WHERE MSV = @MSV";
            } else
                allStudent.Add(s);
            updateData(query, parameters);
        }

        public List<SinhVien> SearchByName(String c, String tn)
        {
            List<SinhVien> res = new List<SinhVien>();
            foreach (SinhVien s in allStudent)
            {
                if (s.Lop == c && s.Ten.Contains(tn))
                    res.Add(s);
            }
            return res;
        }

        public void DelStudent(List<SinhVien> ls)
        {
            foreach (SinhVien s in ls)
            {
                int pos = findPosStudent(s.MSV);
                if (pos >= 0)
                {
                    allStudent.RemoveAt(pos);
                    string query = "DELETE FROM SINHVIEN WHERE MSV = @ID";
                    List<SqlParameter> parameters = new List<SqlParameter>();
                    parameters.Add(new SqlParameter("@ID", s.MSV));
                    updateData(query, parameters);
                }
            }
        }

        public static bool CmpByName(SinhVien s1, SinhVien s2)
        {
            return s1.Ten.CompareTo(s2.Ten) > 0;
        }

        public static bool CmpByDTB(SinhVien s1, SinhVien s2)
        {
            return s1.DTB > s2.DTB;
        }

        public static bool CmpByBD(SinhVien s1, SinhVien s2)
        {
            return s1.NgaySinh < s2.NgaySinh;
        }

        public void SortLR(int l, int r, List<SinhVien> arr, CMP cmp)
        {
            if (l >= r || l < 0 || r >= arr.Count) return;
            int m = (l + r) / 2;
            SortLR(l, m, arr, cmp);
            SortLR(m + 1, r, arr, cmp);
            List<SinhVien> tmp = new List<SinhVien>();
            while (tmp.Count < r - l + 1) tmp.Add(new SinhVien());
            int p1 = l, p2 = m + 1, p3 = 0;
            while (p1 <= m && p2 <= r)
            {
                int tt = p1;
                if (cmp(arr[p2], arr[tt]))
                {
                    tt = p2;
                    p2++;
                }
                else
                    p1++;
                tmp[p3] = arr[tt];
                p3++;
            }
            while (p1 <= m)
            {
                tmp[p3] = arr[p1];
                p3++;
                p1++;
            }
            while (p2 <= r)
            {
                tmp[p3] = arr[p2];
                p3++;
                p2++;
            }
            for (int i = 0; i < tmp.Count; i++)
                arr[i + l] = tmp[i];
        }

    }
}
