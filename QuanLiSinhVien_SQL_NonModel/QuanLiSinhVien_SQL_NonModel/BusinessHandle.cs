using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_SQL_NonModel
{
    public class BusinessHandle
    {

        private static BusinessHandle instance;
        public DataTable dataTable;

        public static BusinessHandle Instance
        {
            get {
                if (instance == null)
                    instance = new BusinessHandle();
                return instance;
            }
            private set { }
        }

        private BusinessHandle() {
            dataTable = getStudent("", "");
        }

        public DataTable getAllClass()
        {
            string query = "SELECT * FROM LSH";
            return DataHelper.Instance.readData(query, new List<SqlParameter>());
        }

        public DataTable getStudent(string classCode, string searchName, string orderBy = "MSV")
        {
            string query = "SELECT * FROM SINHVIEN " +
                "WHERE Lop = @ClassCode AND Ten LIKE @Name " +
                "ORDER BY " + orderBy;
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ClassCode", classCode));
            parameters.Add(new SqlParameter("@Name", "%" + searchName + "%"));
            return DataHelper.Instance.readData(query, parameters);
        }

        public bool delStudent(string studentID) {
            string query = "DELETE FROM SINHVIEN WHERE MSV = @ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", studentID));
            return DataHelper.Instance.updateData(query, parameters);
        }

        /*public DataRow getStudentByID(string studentID)
        {
            string query = "SELECT * FROM SINHVIEN " +
                "WHERE MSV = @ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", studentID));
            return DataHelper.Instance.readData(query, parameters).Rows[0];
        }*/

        private bool isExist(string studentID)
        {
            string query = "SELECT * FROM SINHVIEN " +
                "WHERE MSV = @ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", studentID));
            return DataHelper.Instance.readData(query, parameters).Rows.Count > 0;
        }

        public bool insertStudent(DataRow row)
        {
            if (isExist(row["MSV"].ToString())) return false;
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
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MSV", row["MSV"]));
            parameters.Add(new SqlParameter("@Ten", row["Ten"]));
            parameters.Add(new SqlParameter("@Lop", row["Lop"]));
            parameters.Add(new SqlParameter("@NgaySinh", row["NgaySinh"]));
            parameters.Add(new SqlParameter("@DTB", row["DTB"]));
            parameters.Add(new SqlParameter("@Nam", row["Nam"]));
            parameters.Add(new SqlParameter("@Anh", row["CoAnh"]));
            parameters.Add(new SqlParameter("@HB", row["CoHocBa"]));
            parameters.Add(new SqlParameter("@CCCD", row["CoCCCD"]));
            return DataHelper.Instance.updateData(query, parameters);
        }

        public bool updateStudent(DataRow row)
        {
            if (!isExist(row["MSV"].ToString())) return false;
            string query = "UPDATE SINHVIEN SET " +
                "Ten = @Ten," +
                "Lop = @Lop," +
                "NgaySinh = @NgaySinh," +
                "DTB = @DTB," +
                "Nam = @Nam," +
                "CoAnh = @Anh," +
                "CoHocBa = @HB," +
                "CoCCCD = @CCCD " +
                "WHERE MSV = @MSV";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MSV", row["MSV"]));
            parameters.Add(new SqlParameter("@Ten", row["Ten"]));
            parameters.Add(new SqlParameter("@Lop", row["Lop"]));
            parameters.Add(new SqlParameter("@NgaySinh", row["NgaySinh"]));
            parameters.Add(new SqlParameter("@DTB", row["DTB"]));
            parameters.Add(new SqlParameter("@Nam", row["Nam"]));
            parameters.Add(new SqlParameter("@Anh", row["CoAnh"]));
            parameters.Add(new SqlParameter("@HB", row["CoHocBa"]));
            parameters.Add(new SqlParameter("@CCCD", row["CoCCCD"]));
            return DataHelper.Instance.updateData(query, parameters);
        }

    }
}
