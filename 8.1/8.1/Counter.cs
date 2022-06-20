using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    internal class Counter
    {
        public int Value { get; set; }


        public static Counter operator +(Counter counter1, Counter coounter2)
        {
            return new Counter { Value = counter1.Value + coounter2.Value };
        }
        public static Counter operator +(Counter counter1, int val)
        {
            return new Counter { Value = counter1.Value + val };
        }

        public static bool operator >(Counter counter1, Counter coounter2)
        {
            return counter1.Value > coounter2.Value;
        }
        public static bool operator <(Counter counter1, Counter coounter2)
        {
            return counter1.Value < coounter2.Value;
        }

        public static bool operator true(Counter counter1)
        {
            return counter1.Value != 0;
        }

        public static bool operator false(Counter counter1)
        {
            return counter1.Value == 0;
        }

        public static bool operator !(Counter counter1)
        {
            return counter1.Value == 0;
        }
    }
}
