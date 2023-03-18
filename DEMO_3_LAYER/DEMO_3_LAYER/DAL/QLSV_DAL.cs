using DEMO_3_LAYER.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_3_LAYER.DAL
{
    internal class QLSV_DAL
    {
        public static List<SinhVien> GetAllStudentInClass(LSH l)
        {
            List<SinhVien> data = new List<SinhVien>();
            String sql_query = "SELECT * FROM SINHVIEN WHERE Lop = @ClassName";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ClassName", l.ClassID));
            foreach (DataRow r in DataHelper.Instance.readData(sql_query, parameters).Rows)
            {
                data.Add(new SinhVien(r));
            }
            return data;
        }

        public static List<LSH> GetAllClass()
        {
            List<LSH> data = new List<LSH>();
            String sql_query = "SELECT * FROM LSH";
            foreach (DataRow r in DataHelper.Instance.readData(sql_query, new List<SqlParameter>()).Rows)
            {
                data.Add(new LSH(r));
            }
            return data;
        }

        public static bool DeleteStudent(SinhVien s)
        {
            string query = "DELETE FROM SINHVIEN WHERE MSV = @ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", s.MSV));
            return DataHelper.Instance.updateData(query, parameters);
        }

    }
}
