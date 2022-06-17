
//var tom = new Person("Tom", 37);
//var bob = new Person("Bob", 41);
//var sam = new Person("Sam", 25);

//Person[] people = { tom, bob, sam };
//Array.Sort(people);

//foreach (Person person in people)
//{
//    Console.WriteLine($"{person.Name} - {person.Age}");
//}


//class Person : IComparable<Person>
//{
//    public string Name { get; }
//    public int Age { get; set; }
//    public Person(string name, int age)
//    {
//        Name = name; Age = age;
//    }
//    public int CompareTo(Person? person)
//    {
//        if (person is null) throw new ArgumentException("Некорректное значение параметра");
//        return Age - person.Age;
//    }
//}

var alice = new Person("Alice", 41);
var tom = new Person("Tom", 37);
var kate = new Person("Kate", 25);

Person[] people = { alice, tom, kate };
Array.Sort(people, new PeopleComparer());

foreach (Person person in people)
{
    Console.WriteLine($"{person.Name} - {person.Age}");
}

class PeopleComparer : IComparer<Person>
{
    public int Compare(Person? p1, Person? p2)
    {
        if (p1 is null || p2 is null)
            throw new ArgumentException("Некорректное значение параметра");
        return p1.Name.Length - p2.Name.Length;
    }
}

class Person
{
    public string Name { get; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name; Age = age;
    }
}