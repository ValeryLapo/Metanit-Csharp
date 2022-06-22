//var employees = new List<string> { "Tom", "Sam", "Bob" };

//LinkedList<string> people = new LinkedList<string>(employees);
//foreach (string person in people)
//{
//    Console.WriteLine(person);
//}


//var employees = new List<string> { "Tom", "Sam", "Bob" };

//LinkedList<string> people = new LinkedList<string>(employees);
//Console.WriteLine(people.Count);            // 3
//Console.WriteLine(people.First?.Value);    // Tom
//Console.WriteLine(people.Last?.Value);    // Bob

//LinkedList<string> people = new LinkedList<string>(new[] { "Tom", "Sam", "Bob" });

//// от начала до конца списка
//var currentNode = people.First;
//while (currentNode != null)
//{
//    Console.WriteLine(currentNode.Value);
//    currentNode = currentNode.Next;
//}

//// с конца до начала списка
//currentNode = people.Last;
//while (currentNode != null)
//{
//    Console.WriteLine(currentNode.Value);
//    currentNode = currentNode.Previous;
//}

var people = new LinkedList<string>();
people.AddLast("Tom"); // вставляем узел со значением Tom на последнее место
                       //так как в списке нет узлов, то последнее будет также и первым
people.AddFirst("Bob"); // вставляем узел со значением Bob на первое место

// вставляем после первого узла новый узел со значением Mike
if (people.First != null) people.AddAfter(people.First, "Mike");

// теперь у нас список имеет следующую последовательность: Bob Mike Tom
foreach (var person in people) Console.WriteLine(person);

var company = new LinkedList<Person>();

company.AddLast(new Person("Tom"));
company.AddLast(new Person("Sam"));
company.AddFirst(new Person("Bill"));

foreach (var person in company) Console.WriteLine(person.Name);

class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}