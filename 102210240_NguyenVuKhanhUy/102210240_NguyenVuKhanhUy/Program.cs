using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102210240_NguyenVuKhanhUy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListCTKH arr = new ListCTKH();
            arr.AddCTKH(0, new CongTrinhKhoaHoc("yeuKhanh", 2030, true));
            arr.AddCTKH(0, new CongTrinhKhoaHoc("uy", 2077, true));
            arr.AddCTKH(0, new CongTrinhKhoaHoc("abc", 1991, true));
            arr.AddCTKH(0, new CongTrinhKhoaHoc("xyz", 2000, false));
            Console.WriteLine("List nhap vao:");
            arr.ShowList();
            arr.SortByYear(0, arr.Size - 1);
            Console.WriteLine("Sort theo nam:");
            arr.ShowList();
            Console.WriteLine("Tim kem nhi phan cong trinh nam 1991 nam o vi tri: {0}", arr.SearchByYear(1991));
            Console.ReadKey();
        }
    }
}
