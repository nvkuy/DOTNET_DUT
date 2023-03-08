using System;
using System.Collections.Generic;
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

        public SinhVien(String dataLine) {
            String[] tmp = dataLine.Split('|');
            if (tmp.Length < 9) return;
            MSV = tmp[0];
            Ten = tmp[1];
            Lop = tmp[2];
            NgaySinh = DateTime.Parse(tmp[3]);
            DTB = Double.Parse(tmp[4]);
            GioiTinh = Boolean.Parse(tmp[5]);
            CoAnh = Boolean.Parse(tmp[6]);
            CoHocBa = Boolean.Parse(tmp[7]);
            CoCCCD = Boolean.Parse(tmp[8]);
        }

        public override string ToString()
        {
            return MSV + "|" + Ten + "|" + Lop + "|" + NgaySinh.ToString() + "|" + DTB + "|" + GioiTinh + "|" + CoAnh + "|" + CoHocBa + "|" + CoCCCD;
        }

        public bool IsValidInfo()
        {
            return MSV.Length > 0 && Ten.Length > 0 && DTB >= 0 && DTB <= 10 && Lop != null;
        }

    }
}
