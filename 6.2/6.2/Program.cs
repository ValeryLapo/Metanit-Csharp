using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создаем банковский счет
            Account account = new Account(200);

            // Добавляем в делегат ссылку на методы
            account.RegisterHandler(PrintSimpleMessage);
            account.RegisterHandler(PrintColorMessage);
            // Два раза подряд пытаемся снять деньги
            account.Take(100);
            account.Take(150);

            // Удаляем делегат
            account.UnregisterHandler(PrintColorMessage);
            // снова пытаемся снять деньги
            account.Take(50);

            void PrintSimpleMessage(string message) => Console.WriteLine(message);

            void PrintColorMessage(string message)
            {
                // Устанавливаем красный цвет символов
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                // Сбрасываем настройки цвета
                Console.ResetColor();
            }
        }
    }
}
