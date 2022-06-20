using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = new Counter { Value = 23 };
            Counter counter2 = new Counter { Value = 45 };
            bool result = counter1 > counter2;
            Console.WriteLine(result);

            Counter counter3 = counter1 + counter2;
            Console.WriteLine(counter3.Value);

            Bread bread = new Bread { Weight = 80 };
            Butter butter = new Butter { Weight = 20 };
            Sandwich sandwich = bread + butter;
            Console.WriteLine(sandwich.Weight);  // 100
        }
    }
}
