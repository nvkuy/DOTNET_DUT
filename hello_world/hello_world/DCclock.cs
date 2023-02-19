using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    public class DCclock
    {
        public void ShowTime(object o, TimeEventData e)
        {
            DateTime t = DateTime.Now;
            Console.WriteLine("DC CLOCK: " + e.Time.Millisecond);
        }
    }
}
