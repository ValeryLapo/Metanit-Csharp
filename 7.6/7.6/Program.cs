
// создаем мессенджер
//var telegram = new Messenger<Message>();
//// создаем сообщение
//var message = new Message("Hello World!");
//// отправляем сообщение
//telegram.Send(message);

//var telegram = new Messenger<IPrintableMessage>();
//var message = new PrintableMessage("Hello World!");
//telegram.Send(message);



//interface IMessage
//{
//    string Text { get; } // текст сообщения
//}
//interface IPrintable
//{
//    void Print();
//}
//class Message : IMessage, IPrintable
//{
//    public string Text { get; }
//    public Message(string text) => Text = text;

//    public void Print() => Console.WriteLine(Text);
//}

//class Messenger<T> where T : IMessage, IPrintable
//{
//    public void Send(T message)
//    {
//        Console.WriteLine("Отправка сообщения:");
//        message.Print();
//    }
//}

//interface IPrintableMessage : IPrintable, IMessage { }
//class PrintableMessage : IPrintableMessage
//{
//    public string Text { get; }
//    public PrintableMessage(string text) => Text = text;
//    public void Print() => Console.WriteLine(Text);
//}

IUser<int> user1 = new User<int>(6789);
Console.WriteLine(user1.Id);    // 6789

IUser<string> user2 = new User<string>("12345");
Console.WriteLine(user2.Id);    // 12345

interface IUser<T>
{
    T Id { get; }
}
class User<T> : IUser<T>
{
    public T Id { get; }
    public User(T id) => Id = id;
}