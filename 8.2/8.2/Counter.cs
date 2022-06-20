using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    class Counter
    {
        public int Seconds { get; set; }
        public static implicit operator Counter (int x)
        {
            return new Counter { Seconds = x };
        }
        public static explicit operator int(Counter counter)
        {
            return counter.Seconds;
        }
        public static explicit operator Counter(Timer timer)
        {
            int h = timer.Hours * 3600;
            int m = timer.Minutes * 60;
            return new Counter { Seconds = h + m + timer.Seconds };            
        }

        public static implicit operator Timer(Counter counter)
        {
            int h = counter.Seconds / 3600;
            int m = (counter.Seconds % 3600) / 60;
            int s = counter.Seconds % 60;
            return new Timer { Hours = h, Minutes = m, Seconds = s };
        }
    }

    class Timer
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
    }
}
