using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    public class ACclock
    {
        public void ShowTime(object o, TimeEventData e)
        {
            DateTime t = DateTime.Now;
            Console.WriteLine("AC CLOCK: " + e.Time.Millisecond);
        }
    }
}
