using DEMO_3_LAYER.DAL;
using DEMO_3_LAYER.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_3_LAYER.BLL
{
    internal class QLSV_BLL
    {
        public static List<SinhVien> GetStudentByClass(LSH l)
        {
            List<SinhVien> students = QLSV_DAL.GetAllStudentInClass(l);
            return students;
        }

        public static List<LSH> GetAllClass()
        {
            List<LSH> ls = QLSV_DAL.GetAllClass();
            return ls;
        }

        public static bool DelStudent(SinhVien s)
        {
            return QLSV_DAL.DeleteStudent(s);
        }

    }
}
