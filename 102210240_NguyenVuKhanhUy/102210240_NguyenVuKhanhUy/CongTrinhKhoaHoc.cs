using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102210240_NguyenVuKhanhUy
{
    internal class CongTrinhKhoaHoc
    {
        private string macongtrinh;
        private int namxuatban;
        private bool khuvucxuatban;

        public string MaCongTrinh {
            get { return macongtrinh; }
            set { macongtrinh = value; }
        }
        public int NamXuatBan
        {
            get { return namxuatban; }
            set { namxuatban = Math.Max(value, 1900); }
        }

        public bool KhuVucXuatBan
        {
            get { return khuvucxuatban; }
            set { khuvucxuatban = value; }
        }

        public CongTrinhKhoaHoc() {
            MaCongTrinh = "0";
            NamXuatBan = 1900;
            khuvucxuatban = false;
        }

        public CongTrinhKhoaHoc(string mct, int nxb, bool kv)
        {
            MaCongTrinh = mct;
            NamXuatBan = nxb;
            KhuVucXuatBan = kv;
        }

        public override string ToString()
        {
            return MaCongTrinh + "|" + NamXuatBan + "|" + (KhuVucXuatBan ? "Quoc te" : "Trong nuoc");
        }

    }
}
