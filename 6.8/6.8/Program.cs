using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var fn = Outer();   // fn = Inner, так как метод Outer возвращает функцию Inner
            //                    // вызываем внутреннюю функцию Inner
            //fn();   // 6
            //fn();   // 7
            //fn();   // 8

            //Action Outer()  // метод или внешняя функция
            //{
            //    int x = 5;  // лексическое окружение - локальная переменная
            //    void Inner()    // локальная функция
            //    {
            //        x++;        // операции с лексическим окружением
            //        Console.WriteLine(x);
            //    }
            //    return Inner;   // возвращаем локальную функцию
            //}

            var fn = Multiply(5);

            Console.WriteLine(fn(5));   // 25
            Console.WriteLine(fn(6));   // 30
            Console.WriteLine(fn(7));   // 35

            Operation Multiply(int n)
            {
                int Inner(int m)
                {
                    return n * m;
                }
                return Inner;
            }

        }
        delegate int Operation(int n);
    }
}
