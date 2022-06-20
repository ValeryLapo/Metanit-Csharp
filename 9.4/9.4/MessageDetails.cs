using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4
{
    internal class MessageDetails
    {
        public string Language { get; set; } = "";    // язык пользователя
        public string DateTime { get; set; } = "";    // время суток
        public string Status { get; set; } = "";     // статус пользователя

        public void Deconstruct(out string lang, out string datetime, out string status)
        {
            lang = Language;
            datetime = DateTime;
            status = Status;
        }
    }
}
