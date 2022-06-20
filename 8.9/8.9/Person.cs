using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public record Person
//{
//    public string Name { get; init; }
//    public int Age { get; init; }
//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public void Deconstruct(out string name, out int age) => (name, age) = (Name, Age);
//}

public record Person(string Name, int Age);

public class User
{
    public string Name { get; init; }
    public User(string name) => Name = name;
}
