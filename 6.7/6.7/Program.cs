using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DoOperation(2, 4, Add);

            //void DoOperation(int a, int b, Action<int, int> op) => op(a, b);

            //void Add(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");

            //void Multiply(int x, int y) => Console.WriteLine($"{x} * {y} = {x * y}");

            //Predicate<int> isPositive = (int x) => x > 0;

            

            //Console.WriteLine(isPositive(20));
            //Console.WriteLine(isPositive(-20));


            int result1 = DoOperation(6, DoubleNumber); // 12
            Console.WriteLine(result1);

            int result2 = DoOperation(6, SquareNumber); // 36
            Console.WriteLine(result2);

            int DoOperation(int n, Func<int, int> operation) => operation(n);
            int DoubleNumber(int n) => 2 * n;
            int SquareNumber(int n) => n * n;
        }


    }
}
