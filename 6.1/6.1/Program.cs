using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1
{
    public class Program
    {
        delegate void Message();
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Operation operation = new Operation(Add);
            int result = operation(3, 4);
            Console.WriteLine(result);

            operation = Multiply;
            Console.WriteLine(operation(4,6));

            Message? longMes;
            longMes = Hello;
            longMes -= Hello;

            longMes();


            longMes.Invoke();
            int Add(int x, int y) => x + y;

            int Multiply(int x, int y) => x * y;

            void Hello() => Console.WriteLine("Hello");
            void Valera() => Console.WriteLine("valera");

        }

    }
}
