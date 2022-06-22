//var employees = new List<string> { "Tom", "Sam", "Bob" };
//Queue<string> people = new Queue<string>(employees);
//foreach (var person in people) Console.WriteLine(person);

//Console.WriteLine(people.Count); // 3



//var people = new Queue<string>();

//// добавляем элементы
//people.Enqueue("Tom");  // people = { Tom }
//people.Enqueue("Bob");  // people = { Tom, Bob }
//people.Enqueue("Sam");  // people = { Tom, Bob, Sam }

//// получаем элемент из самого начала очереди 
//var firstPerson = people.Peek();
//Console.WriteLine(firstPerson); // Tom

//// удаляем элементы
//var person1 = people.Dequeue();  // people = { Bob, Sam  }
//Console.WriteLine(person1); // Tom
//var person2 = people.Dequeue();  // people = { Sam  }
//Console.WriteLine(person2); // Bob
//var person3 = people.Dequeue();  // people = {  }
//Console.WriteLine(person3); // Sam


//var people = new Queue<string>();

//// добавляем элементы
//people.Enqueue("Tom");  // people = { Tom }

//// удаляем элементы
//var success1 = people.TryDequeue(out var person1);  // success1 = true
//if (success1) Console.WriteLine(person1); // Tom

//var success2 = people.TryPeek(out var person2);  // success2 = false
//if (success2) Console.WriteLine(person2);

var patients = new Queue<Person>();
patients.Enqueue(new Person("Tom"));
patients.Enqueue(new Person("Bob"));
patients.Enqueue(new Person("Sam"));

var practitioner = new Doctor();
practitioner.TakePatients(patients);

class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}

class Doctor
{
    public void TakePatients(Queue<Person> patients)
    {
        while (patients.Count > 0)
        {
            var patient = patients.Dequeue();
            Console.WriteLine($"Осмотр пациента {patient.Name}");
        }
        Console.WriteLine("Доктор закончил осматривать пациентов");
    }
}