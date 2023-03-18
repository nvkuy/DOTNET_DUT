using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiBaoKhoaHoc
{
    internal class QLCTKH
    {
        public static DataTable GetBaiBao(string searchName, string maLoaiTapChi, string namXB, string maNhaXB)
        {
            string query = "SELECT MaBaiBao, TenBaiBao, TenTacGia, TenTapChi, TenLoaiTapChi, NamXuatBan, TenNXB FROM BaiBao " +
                "JOIN NXB ON BaiBao.MaNXB = NXB.MaNXB AND NXB.MaNXB LIKE @Publisher " +
                "JOIN TapChi ON BaiBao.MaTapChi = TapChi.MaTapChi " +
                "JOIN LoaiTapChi ON TapChi.MaLoaiTapChi = LoaiTapChi.MaLoaiTapChi AND TapChi.MaLoaiTapChi LIKE @Category " +
                "WHERE TenBaiBao LIKE @Name " +
                "AND NamXuatBan LIKE @Year";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Name", "%" + searchName + "%"));
            parameters.Add(new SqlParameter("@Category", maLoaiTapChi.Length == 0 ? "%%" : maLoaiTapChi));
            parameters.Add(new SqlParameter("@Year", namXB.Length == 0 ? "%%" : namXB));
            parameters.Add(new SqlParameter("@Publisher", maNhaXB.Length == 0 ? "%%" : maNhaXB));
            DataTable dt = DBHelper.Instance.readData(query, parameters);
            dt.Columns.Add("STT", typeof(int)).SetOrdinal(0);
            for (int i = 0; i < dt.Rows.Count; i++) dt.Rows[i]["STT"] = i + 1;
            return dt;
        }

        public static List<ComboBoxItem> GetLoaiTapChi(bool AllowSelectAll)
        {
            List<ComboBoxItem> rs = new List<ComboBoxItem>();
            if (AllowSelectAll)
                rs.Add(new ComboBoxItem { Text = "All", Value = "" });
            string query = "SELECT * FROM LoaiTapChi";
            foreach (DataRow row in DBHelper.Instance.readData(query, new List<SqlParameter>()).Rows) {
                rs.Add(new ComboBoxItem {
                    Text = row["TenLoaiTapChi"].ToString(),
                    Value = row["MaLoaiTapChi"].ToString()
                });
            }
            return rs;
        }

        public static List<ComboBoxItem> GetTenTapChi(string MaLoaiTapChi, bool AllowSelectAll)
        {
            List<ComboBoxItem> rs = new List<ComboBoxItem>();
            if (AllowSelectAll)
                rs.Add(new ComboBoxItem { Text = "All", Value = "" });
            string query = "SELECT * FROM TapChi WHERE MaLoaiTapChi = @LoaiTapChi";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@LoaiTapChi", MaLoaiTapChi));
            foreach (DataRow row in DBHelper.Instance.readData(query, parameters).Rows)
            {
                rs.Add(new ComboBoxItem
                {
                    Text = row["TenTapChi"].ToString(),
                    Value = row["MaTapChi"].ToString()
                });
            }
            return rs;
        }

        public static List<ComboBoxItem> GetNXB(bool AllowSelectAll)
        {
            List<ComboBoxItem> rs = new List<ComboBoxItem>();
            if (AllowSelectAll)
                rs.Add(new ComboBoxItem { Text = "All", Value = "" });
            string query = "SELECT * FROM NXB";
            foreach (DataRow row in DBHelper.Instance.readData(query, new List<SqlParameter>()).Rows)
            {
                rs.Add(new ComboBoxItem
                {
                    Text = row["TenNXB"].ToString(),
                    Value = row["MaNXB"].ToString()
                });
            }
            return rs;
        }

        public static bool DelBaiBao(string MaBaiBao)
        {
            string query = "DELETE FROM BaiBao WHERE MaBaiBao = @ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", MaBaiBao));
            return DBHelper.Instance.updateData(query, parameters);
        }

        private static bool isExist(string MaBaiBao)
        {
            string query = "SELECT * FROM BaiBao WHERE MaBaiBao = @ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", MaBaiBao));
            return DBHelper.Instance.readData(query, parameters).Rows.Count > 0;
        }

        public static bool AddOrUpdate(string MaBaiBao, string TenBaiBao, string TenTacGia, string MaTapChi, string NamXB, string MaNhaXB)
        {
            string query = "INSERT INTO BaiBao VALUES (" +
                "@MaBaiBao, " +
                "@TenBaiBao, " +
                "@TenTacGia, " +
                "@MaTapChi, " +
                "@NamXB, " +
                "@MaNhaXB" +
                ")";
            if (isExist(MaBaiBao))
            {
                query = "UPDATE BaiBao SET " +
                    "TenBaiBao = @TenBaiBao, " +
                    "TenTacGia = @TenTacGia, " +
                    "MaTapChi = @MaTapChi, " +
                    "NamXuatBan = @NamXB, " +
                    "MaNXB = @MaNhaXB " +
                    "WHERE MaBaiBao = @MaBaiBao";
            }
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MaBaiBao", MaBaiBao));
            parameters.Add(new SqlParameter("@TenBaiBao", TenBaiBao));
            parameters.Add(new SqlParameter("@TenTacGia", TenTacGia));
            parameters.Add(new SqlParameter("@MaTapChi", MaTapChi));
            parameters.Add(new SqlParameter("@NamXB", NamXB));
            parameters.Add(new SqlParameter("@MaNhaXB", MaNhaXB));
            return DBHelper.Instance.updateData(query, parameters);
        }

    }
}
