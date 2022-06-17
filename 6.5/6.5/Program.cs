using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account(100);
            //account.Notify += DisplayMessage;

            //account.Put(20);    // добавляем на счет 20
            ////Console.WriteLine($"Сумма на счете: {account.Sum}");

            //account.Notify -= DisplayMessage;

            //account.Take(70);   // пытаемся снять со счета 70
            ////Console.WriteLine($"Сумма на счете: {account.Sum}");

            //account.Take(180);  // пытаемся снять со счета 180
            ////Console.WriteLine($"Сумма на счете: {account.Sum}");

            //void DisplayMessage(string msg) => Console.WriteLine(msg);
            //void DisplayRedMessage(string message)
            //{
            //    // Устанавливаем красный цвет символов
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(message);
            //    // Сбрасываем настройки цвета
            //    Console.ResetColor();
            //}


            Account acc = new Account(100);
            acc.Notify += DisplayMessage;
            acc.Put(20);
            acc.Take(70);
            acc.Take(150);

            void DisplayMessage(Account sender, AccountEventArgs e)
            {
                Console.WriteLine($"Сумма транзакции: {e.Sum}");
                Console.WriteLine(e.Message);
                Console.WriteLine($"Текущая сумма на счете: {sender.Sum}");
            }
        }

    }
}
