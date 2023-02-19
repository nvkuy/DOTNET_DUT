using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityPanel.Model
{

    public class DataHelper
    {
        private const string PASSWORD = "13579";
        private const string DATABASE_PATH = "data.txt";
        private static DataHelper instance;

        private DataHelper() { }

        public static DataHelper Instance { 
            get
            {
                if (instance == null) instance = new DataHelper();
                return instance;
            }
        }

        public void appendLoginAttempt(LoginAttempt la)
        {
            File.AppendAllText(DATABASE_PATH, la.Date + "|" + la.State + Environment.NewLine);
        }

        public List<LoginAttempt> readAllLoginHistory()
        {
            List<LoginAttempt> res = new List<LoginAttempt>();
            if (File.Exists(DATABASE_PATH))
            {
                foreach (string line in File.ReadAllLines(DATABASE_PATH))
                {
                    string[] la = line.Split('|');
                    res.Add(new LoginAttempt(la[0], la[1]));
                }
            }
            return res;
        }

        public bool checkPassword(string pass) {
            return pass == PASSWORD;
        }

    }
}
