Numbers numbers = new Numbers();
foreach (int n in numbers)
{
    Console.WriteLine(n);
}

class Numbers
{
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i <= 6; i++)
        {
            yield return i * i;
        }
    }
}



//foreach (var n in 5) Console.WriteLine(n);
//foreach (var n in -5) Console.WriteLine(n);

//var people = new Person[]
//{
//    new Person("Tom"),
//    new Person("Bob"),
//    new Person("Sam")
//};
//var microsoft = new Company(people);

//foreach (Person employee in microsoft)
//{
//    Console.WriteLine(employee.Name);
//}

//class Person
//{
//    public string Name { get; }
//    public Person(string name) => Name = name;
//}
//class Company
//{
//    Person[] personnel;
//    public Company(Person[] personnel) => this.personnel = personnel;
//    public int Length => personnel.Length;
//    public IEnumerator<Person> GetEnumerator()
//    {
//        for (int i = 0; i < personnel.Length; i++)
//        {
//            yield return personnel[i];
//        }
//    }
//    public IEnumerable<Person> GetPersonnel(int max)
//    {
//        for (int i = 0; i < max; i++)
//        {
//            if (i == personnel.Length)
//            {
//                yield break;
//            }
//            else
//            {
//                yield return personnel[i];
//            }
//        }
//    }
//}
//static class Int32Extension
//{
//    public static IEnumerator<int> GetEnumerator(this int number)
//    {
//        int k = (number > 0) ? number : 0;
//        for (int i = number - k; i <= k; i++) yield return i;
//    }
//}