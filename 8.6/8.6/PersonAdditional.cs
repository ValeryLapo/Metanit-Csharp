using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class Person
{
    public void Eat() => Console.WriteLine("I'm eating");

    partial void Read() => Console.WriteLine("I'm reading a book");

}
