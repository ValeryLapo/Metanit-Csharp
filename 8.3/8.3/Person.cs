using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;

    }

    class Company
    {
        Person[] personal;
        public Company(Person[] people) => personal = people;

        public Person this[int index]
        {
            get
            {
                //Если индекс имееется в массиве
                if (index >= 0 && index < personal.Length)
                    return personal[index];
                else
                    throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < personal.Length)
                    personal[index] = value;
            }
        }
    }
}
