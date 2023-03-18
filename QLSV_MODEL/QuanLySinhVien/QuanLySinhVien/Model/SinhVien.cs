using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Model
{
    public class SinhVien
    {
        private String msv;
        private String ten;
        private String lop;
        private DateTime ngaySinh;
        private double dtb;
        private bool gioiTinh, coAnh, coHocBa, coCCCD;

        public String MSV { get { return msv; } set { msv = value; } }
        public String Ten { get { return ten; } set { ten = value; } }
        public string Lop { get { return lop; } set { lop = value; } }
        public double DTB { get { return dtb; } set { dtb = value; } }
        public DateTime NgaySinh { get { return ngaySinh; } set { ngaySinh = value; } }
        public bool GioiTinh { get { return gioiTinh;} set { gioiTinh = value; } }
        public bool CoAnh { get { return coAnh; } set { coAnh = value; } }
        public bool CoHocBa { get { return coHocBa; } set { coHocBa = value; } }
        public bool CoCCCD { get { return coCCCD; } set { coCCCD = value; } }

        public SinhVien() { }

        public SinhVien(DataRow row)
        {
            MSV = row["MSV"].ToString();
            Ten = row["Ten"].ToString();
            Lop = row["Lop"].ToString();
            NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
            DTB = Double.Parse(row["DTB"].ToString());
            GioiTinh = Boolean.Parse(row["Nam"].ToString());
            CoAnh = Boolean.Parse(row["CoAnh"].ToString());
            CoHocBa = Boolean.Parse(row["CoHocBa"].ToString());
            CoCCCD = Boolean.Parse(row["CoCCCD"].ToString());
        }

        public bool IsValidInfo()
        {
            return MSV.Length > 0 && Ten.Length > 0 && DTB >= 0 && DTB <= 10 && Lop != null;
        }

    }
}
