using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._9
{
    //interface IMessanger<out T>
    //{
    //    T WriteMessage(string text);
    //}

    //interface IMessanger <in T>
    //{
    //    void SendMessage(T message);
    //}


    interface IMessenger<in T, out K>
    {
        void SendMessage(T message);
        K WriteMessage(string text);
    }

    
}
