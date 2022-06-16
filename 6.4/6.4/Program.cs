using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Message hello = () => Console.WriteLine("METANIT.COM");

            //Message message = () => Console.Write("Hello ");
            //message += () => Console.WriteLine("World"); // добавляем анонимное лямбда-выражение
            //message += hello;   // добавляем лямбда-выражение из переменной hello
            //message += Print;   // добавляем метод

            //message();
            //Console.WriteLine("--------------"); // для разделения вывода

            //message -= Print;   // удаляем метод
            //message -= hello;   // удаляем лямбда-выражение из переменной hello

            //message?.Invoke();  // на случай, если в message больше нет действий

            //void Print() => Console.WriteLine("Welcome to C#");



            //int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ////Найдём сумму чисел больше 5
            //int result1 = Sum(integers, x => x > 5);
            //Console.WriteLine(result1);

            //int Sum(int[] numbers, IsEqual func)
            //{
            //    int result = 0;
            //    foreach (int i in numbers)
            //    {
            //        if (func(i))
            //            result += i;
            //    }
            //    return result;
            //}



            Operation operation = SelectOperation(OperationType.Add);
            Console.WriteLine(operation(10, 4));    // 14

            operation = SelectOperation(OperationType.Subtract);
            Console.WriteLine(operation(10, 4));    // 6

            operation = SelectOperation(OperationType.Multiply);
            Console.WriteLine(operation(10, 4));    // 40

            Operation SelectOperation(OperationType opType)
            {
                switch (opType)
                {
                    case OperationType.Add: return (x, y) => x + y;
                    case OperationType.Subtract: return (x, y) => x - y;
                    default: return (x, y) => x * y;
                }
            }
        }
        enum OperationType
        {
            Add, Subtract, Multiply
        }

        delegate int Operation(int x, int y);
        delegate void Message();
        delegate bool IsEqual(int x);
    }
}
