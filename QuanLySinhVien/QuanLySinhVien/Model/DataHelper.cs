using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Model
{
    public class DataHelper
    {
        private const string DATABASE_PATH = "data.txt";
        private static DataHelper instance;
        private static List<SinhVien> allData;
        public delegate bool CMP(SinhVien s1, SinhVien s2);

        private DataHelper() { }

        public static DataHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataHelper();
                    allData = new List<SinhVien>();
                }
                return instance;
            }
        }

        public void ReadAllData()
        {
            allData.Clear();
            if (File.Exists(DATABASE_PATH))
            {
                foreach (String line in File.ReadAllLines(DATABASE_PATH))
                {
                    allData.Add(new SinhVien(line));
                }
            }

        }

        public void AddOrUpdateStudent(SinhVien s)
        {

            for (int i =  0; i < allData.Count; i++)
            {
                if (s.MSV == allData[i].MSV)
                {
                    allData[i] = s;
                    return;
                }
            }
            allData.Add(s);
        }

        public void SaveData()
        {
            File.WriteAllText(DATABASE_PATH, "");
            foreach (SinhVien s in allData)
            {
                File.AppendAllText(DATABASE_PATH, s.ToString() + Environment.NewLine);
            }
        }

        public List<SinhVien> SearchByName(String c, String tn)
        {
            List<SinhVien> res = new List<SinhVien>();
            foreach (SinhVien s in allData)
            {
                if (s.Lop == c && s.Ten.Contains(tn))
                    res.Add(s);
            }
            return res;
        }

        public void DelStudent(List<SinhVien> ls)
        {
            List<SinhVien> tmp = new List<SinhVien>();
            foreach (SinhVien s in allData)
            {
                if (ls.Contains(s))
                    continue;
                tmp.Add(s);
            }
            allData = tmp;
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
            while (tmp.Count < r - l + 1) tmp.Add(new SinhVien(""));
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
