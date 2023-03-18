using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_3_LAYER.DTO
{
    internal class LSH
    {

        private String classID;
        public String ClassID { get { return classID; } set { classID = value; } }

        public LSH() { }

        public LSH(string classID)
        {
            ClassID = classID;
        }

        public LSH(DataRow row)
        {
            ClassID = row["MaLop"].ToString();
        }

    }
}
