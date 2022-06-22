
using System.Threading;

//// создаем новые потоки
//Thread myThread1 = new Thread(new ParameterizedThreadStart(Print));
//Thread myThread2 = new Thread(Print);
//Thread myThread3 = new Thread(message => Console.WriteLine(message));

//// запускаем потоки
//myThread1.Start("Hello");
//myThread2.Start("Привет");
//myThread3.Start("Salut");


//void Print(object? message) => Console.WriteLine(message);

//int number = 4;
//// создаем новый поток
//Thread myThread = new Thread(Print);
//myThread.Start(number);    // n * n = 16


//// действия, выполняемые во втором потокке
//void Print(object? obj)
//{
//    // здесь мы ожидаем получить число
//    if (obj is int n)
//    {
//        Console.WriteLine($"n * n = {n * n}");
//    }
//}


//Person tom = new Person("Tom", 37);
//// создаем новый поток
//Thread myThread = new Thread(Print);
//myThread.Start(tom);

//void Print(object? obj)
//{
//    // здесь мы ожидаем получить объект Person
//    if (obj is Person person)
//    {
//        Console.WriteLine($"Name = {person.Name}");
//        Console.WriteLine($"Age = {person.Age}");
//    }
//}

//record class Person(string Name, int Age);


Person tom = new Person("Tom", 37);
// создаем новый поток
Thread myThread = new Thread(tom.Print);
myThread.Start();

record class Person(string Name, int Age)
{
    public void Print()
    {
        Console.WriteLine($"Name = {Name}");
        Console.WriteLine($"Age = {Age}");
    }
}