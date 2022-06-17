﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    public class AccountEventArgs
    {
        // Сообщение
        public string Message { get; }

        // Сумма, на которую изменился счет
        public int Sum { get; }

        public AccountEventArgs(string message, int sum)
        {
            Message = message;
            Sum = sum;
        }
    }
}
