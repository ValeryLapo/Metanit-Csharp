using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = 8;
            Operation operation = delegate (int x, int y)
            {
                return x + y + z;
            };

            int result = operation(4, 5);
            Console.WriteLine(result);       // 17


        }
        delegate int Operation(int x, int y);
    }

}
