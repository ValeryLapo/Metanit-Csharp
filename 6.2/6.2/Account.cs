using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    // Объявляем делегат
    public delegate void AccountHandler(string message);
    public class Account
    {
        int sum;
        // Создаем переменную делегата
        AccountHandler taken;
        public Account(int sum) => this.sum = sum;

        // Регистрируем делегат
        public void RegisterHandler(AccountHandler del)
        {
            taken += del;
        }

        // Отмена регистрации делегата
        public void UnregisterHandler(AccountHandler del)
        {
            taken -= del; // удаляем делегат
        }
        public void Add(int sum) => this.sum += sum;
        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                // вызываем делегат, передавая ему сообщение
                taken?.Invoke($"Со счета списано {sum} у.е.");
            }
            else
            {
                taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");
            }
        }
    }
}
