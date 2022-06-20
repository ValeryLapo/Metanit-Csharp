using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1
{
    class Empoyee
    {
        public virtual void Work() => Console.WriteLine("Employee works");
    }

    class Manager: Empoyee
    {
        public override void Work() => Console.WriteLine("Manager works");
        public bool IsOnVacation { get; set; }
    }
}
