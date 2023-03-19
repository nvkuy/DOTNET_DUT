using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoAnTotNghiep
{
    internal class QLDATN
    {
        public static DataTable GetDATN(string searchName, string huongNC, int tinhTrang, string maGVHD)
        {
            string query = "SELECT MaDoAn, TenDoAn, TenTacGia, HuongNghienCuu, TenGiangVien, TinhTrang, NamBaoVe " +
                "FROM DATN JOIN GVHD ON DATN.MaGiangVien = GVHD.MaGiangVien ";
            if (maGVHD.Length > 0) query += "AND GVHD.MaGiangVien = @MaGVHD ";
            query += "WHERE TenDoAn LIKE @Name ";
            if (huongNC.Length > 0) query += "AND HuongNghienCuu = @HuongNC ";
            if (tinhTrang >= 0) query += "AND TinhTrang = @TinhTrang ";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Name", "%" + searchName + "%"));
            parameters.Add(new SqlParameter("@HuongNC", huongNC));
            parameters.Add(new SqlParameter("@TinhTrang", tinhTrang));
            parameters.Add(new SqlParameter("@MaGVHD", maGVHD));
            DataTable dt = DBHelper.Instance.readData(query, parameters);
            dt.Columns.Add("STT", typeof(int)).SetOrdinal(0);
            for (int i = 0; i < dt.Rows.Count; i++) dt.Rows[i]["STT"] = i + 1;
            return dt;
        }

        public static List<ComboBoxItem> GetHuongNC(bool AllowSelectAll)
        {
            List<ComboBoxItem> rs = new List<ComboBoxItem>();
            if (AllowSelectAll)
                rs.Add(new ComboBoxItem { Text = "All", Value = "" });
            string query = "SELECT DISTINCT HuongNghienCuu FROM GVHD";
            foreach (DataRow row in DBHelper.Instance.readData(query, new List<SqlParameter>()).Rows)
            {
                rs.Add(new ComboBoxItem
                {
                    Text = row["HuongNghienCuu"].ToString(),
                    Value = row["HuongNghienCuu"].ToString()
                });
            }
            return rs;
        }

        public static List<ComboBoxItem> GetGVHD(string HuongNC, bool AllowSelectAll)
        {
            List<ComboBoxItem> rs = new List<ComboBoxItem>();
            if (AllowSelectAll)
                rs.Add(new ComboBoxItem { Text = "All", Value = "" });
            string query = "SELECT * FROM GVHD WHERE HuongNghienCuu = @HuongNC";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@HuongNC", HuongNC));
            foreach (DataRow row in DBHelper.Instance.readData(query, parameters).Rows)
            {
                rs.Add(new ComboBoxItem
                {
                    Text = row["TenGiangVien"].ToString(),
                    Value = row["MaGiangVien"].ToString()
                });
            }
            return rs;
        }

        public static List<ComboBoxItem> GetTinhTrang(bool AllowSelectAll)
        {
            List<ComboBoxItem> rs = new List<ComboBoxItem>();
            if (AllowSelectAll)
                rs.Add(new ComboBoxItem { Text = "All", Value = -1 });
            rs.Add(new ComboBoxItem
            {
                Text = "Đã bảo vệ",
                Value = 1
            });
            rs.Add(new ComboBoxItem
            {
                Text = "Chưa bảo vệ",
                Value = 0
            });
            return rs;
        }

        public static bool DelDATN(string MaDATN)
        {
            string query = "DELETE FROM DATN WHERE MaDoAn = @ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", MaDATN));
            return DBHelper.Instance.updateData(query, parameters);
        }

        private static bool isExist(string MaDATN)
        {
            string query = "SELECT * FROM DATN WHERE MaDoAn = @ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", MaDATN));
            return DBHelper.Instance.readData(query, parameters).Rows.Count > 0;
        }

        public static bool AddOrUpdate(string MaDoAn, string TenDoAn, string TenTacGia, int NamBaoVe, Boolean TinhTrang, string MaGiangVien)
        {
            string query = "INSERT INTO DATN VALUES (" +
                "@MaDoAn, " +
                "@TenDoAn, " +
                "@TenTacGia, " +
                "@NamBaoVe, " +
                "@TinhTrang, " +
                "@MaGiaoVien" +
                ")";
            if (isExist(MaDoAn))
            {
                query = "UPDATE DATN SET " +
                    "TenDoAn = @TenDoAn, " +
                    "TenTacGia = @TenTacGia, " +
                    "NamBaoVe = @NamBaoVe, " +
                    "NamXuatBan = @NamXB, " +
                    "TinhTrang = @TinhTrang " +
                    "MaGiangVien = @MaGiaoVien" +
                    "WHERE MaDoAn = @MaDoAn";
            }
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MaDoAn", MaDoAn));
            parameters.Add(new SqlParameter("@TenDoAn", TenDoAn));
            parameters.Add(new SqlParameter("@TenTacGia", TenTacGia));
            parameters.Add(new SqlParameter("@NamBaoVe", NamBaoVe));
            parameters.Add(new SqlParameter("@TinhTrang", TinhTrang));
            parameters.Add(new SqlParameter("@MaGiaoVien", MaGiangVien));
            return DBHelper.Instance.updateData(query, parameters);
        }
    }
}
