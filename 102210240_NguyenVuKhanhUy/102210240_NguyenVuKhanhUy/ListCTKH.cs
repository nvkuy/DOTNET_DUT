using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _102210240_NguyenVuKhanhUy
{
    internal class ListCTKH
    {
        private int size;
        private CongTrinhKhoaHoc[] data;

        public int Size
        {
            get { return size; }
        }

        public ListCTKH()
        {
            size = 0;
            data = new CongTrinhKhoaHoc[size];
        }

        public void ShowList()
        {
            foreach (CongTrinhKhoaHoc ctkh in data)
                Console.WriteLine(ctkh.ToString());
        }

        public void AddCTKH(int pos, CongTrinhKhoaHoc ctkh)
        {
            if (pos < 0 || pos > Size) return;
            CongTrinhKhoaHoc[] tmp = data;
            data = new CongTrinhKhoaHoc[Size + 1];
            for (int i = 0; i < pos; i++)
                data[i] = tmp[i];
            data[pos] = ctkh;
            for (int i = pos + 1; i <= Size; i++)
                data[i] = tmp[i - 1];
            size++;
        }

        public void DelCTKH(int pos)
        {
            if (pos < 0 || pos >= Size) return;
            CongTrinhKhoaHoc[] tmp = data;
            data = new CongTrinhKhoaHoc[Size - 1];
            for (int i = 0; i < pos; i++)
                data[i] = tmp[i];
            for (int i = pos + 1; i < Size; i++)
                data[i - 1] = tmp[i];
            size--;
        }

        public void EditCTKH(int pos, CongTrinhKhoaHoc ctkh)
        {
            if (pos < 0 || pos >= Size) return;
            data[pos] = ctkh;
        }

        public int SearchByYear(int year)
        {
            int l = 0, r = size - 1, m;
            while (l < r)
            {
                m = (l + r) / 2;
                if (data[m].NamXuatBan < year)
                    l = m + 1;
                else
                    r = m;
            }
            return (year == data[r].NamXuatBan ? r : -1);
        }

        public void SortByYear(int l, int r)
        {
            if (l >= r || l < 0 || r >= Size) return;
            int m = (l + r) / 2;
            SortByYear(l, m);
            SortByYear(m + 1, r);
            CongTrinhKhoaHoc[] tmp = new CongTrinhKhoaHoc[r - l + 1];
            int p1 = l, p2 = m + 1, p3 = 0;
            while (p1 <= m && p2 <= r)
            {
                int tt = p1;
                if (data[tt].NamXuatBan > data[p2].NamXuatBan)
                {
                    tt = p2;
                    p2++;
                }
                else
                    p1++;
                tmp[p3] = data[tt];
                p3++;
            }
            while (p1 <= m)
            {
                tmp[p3] = data[p1];
                p3++;
                p1++;
            }
            while (p2 <= r)
            {
                tmp[p3] = data[p2];
                p3++;
                p2++;
            }
            for (int i = 0; i < tmp.Length; i++)
                data[i + l] = tmp[i];
        }

    }
}
