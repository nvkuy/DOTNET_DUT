using System;

namespace hello_world
{
    public class Program
    {

        static void Main()
        {
            Clock clock = new Clock();
            clock.OnSecondChange += new Clock.SecondChangeHandle(new DCclock().ShowTime);
            clock.OnSecondChange += new Clock.SecondChangeHandle(new ACclock().ShowTime);

            clock.Run();
            
        }
    }
}
