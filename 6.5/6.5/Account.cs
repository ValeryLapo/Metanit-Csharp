using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    public class Account
    {
        // Делегат  и событие которое его будет представлять
        public delegate void AccountHandler(Account sender, AccountEventArgs e);
        public event AccountHandler Notify;  // 1. Определение события
        //{
        //    add
        //    {
        //        notify += value;
        //        Console.WriteLine($"{value.Method.Name} добавлен");
        //    }
        //    remove
        //    {
        //        notify -= value;
        //        Console.WriteLine($"{value.Method.Name} удален");
        //    }
        //}
        // в конструкторе устанавливаем начальную сумму на счете
        public Account(int sum) => Sum = sum;

        // сумма на счете
        public int Sum { get; private set; }


        // добавление средств на счет
        public void Put(int sum)
        {
            Sum += sum;
            if (Notify != null)
                Notify.Invoke(this, new AccountEventArgs($"На счет поступило: {sum}", sum)); // 2. Вызов события
            
        }

        // списание средств со счета
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                if (Notify != null)
                    Notify.Invoke(this, new AccountEventArgs($"Со счета снято: {sum}", sum)); // 2. Вызов события
            }
            else
            {
                if (Notify != null)
                    Notify.Invoke(this, new AccountEventArgs($"Недостаточно денег на счете", sum)); // 2. Вызов события
            }
        }
    }
}
