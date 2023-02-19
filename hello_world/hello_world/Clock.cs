using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    public class Clock
    {
        public delegate void SecondChangeHandle(object o, TimeEventData e);
        public event SecondChangeHandle OnSecondChange;

        public void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (OnSecondChange != null)
                    OnSecondChange?.Invoke(this, new TimeEventData { Time = DateTime.Now });
            }
        }

    }
}
