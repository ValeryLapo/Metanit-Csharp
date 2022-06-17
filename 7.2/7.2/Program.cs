//Person person = new Person();
//Car car = new Car();
//DoAction(person);
//DoAction(car);

//void DoAction(IMovable movable) => movable.Move();

//interface IMovable
//{
//    void Move();
//}

//// применение интерфейса в классе
//class Person : IMovable
//{
//    public void Move()
//    {
//        Console.WriteLine("Человек идет");
//    }
//}
//// применение интерфейса в структуре
//struct Car : IMovable
//{
//    public void Move()
//    {
//        Console.WriteLine("Машина едет");
//    }
//}

Message hello = new Message("Hello World");
hello.Print();  // Hello World

interface IMessage
{
    string Text { get; set; }
}
interface IPrintable
{
    void Print();
}
class Message : IMessage, IPrintable
{
    public string Text { get; set; }
    public Message(string text) => Text = text;
    public void Print() => Console.WriteLine(Text);
}