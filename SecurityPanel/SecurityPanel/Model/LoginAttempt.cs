using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityPanel.Model
{
    public class LoginAttempt
    {
        private string date;
        private string state;

        public string Date { get { return date; } set { date = value; } }
        public string State { get { return state; } set { state = value; } }

        public LoginAttempt(string date, string state)
        {
            Date = date;
            State = state;
        }
    }
}
