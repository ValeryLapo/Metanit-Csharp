using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// делегату с базовым типом передаем метод с производным типом
            //MessageBuilder messageBuilder = WriteEmailMessage; // ковариантность
            //Message message = messageBuilder("Hello");
            //message.Print();    // Email: Hello

            //EmailMessage WriteEmailMessage(string text) => new EmailMessage(text);

            //// делегату с производным типом передаем метод с базовым типом
            //EmailReceiver emailBox = ReceiveMessage; // контравариантность
            //emailBox(new EmailMessage("Welcome"));  // Email: Welcome

            //void ReceiveMessage(Message message) => message.Print();

            //MessageBuilder<Message> msgBuilder = WriteEmailMessage;

            //Message msg = msgBuilder("Hello");

            //msg.Print();

            //EmailMessage WriteEmailMessage(string text) => new EmailMessage(text);

            //MessageReceiver<EmailMessage> msgReceiver = ReceiveMessage;

            //msgReceiver(new EmailMessage("Heloooo"));

            //void ReceiveMessage(Message msg) => msg.Print();

            //MessageConverter<SmsMessage, Message> converter = ConvertToEmail;
            //Message message = converter(new SmsMessage("Delegates"));
            //message.Print();    // Email: Delegates

            //EmailMessage ConvertToEmail(Message msg) => new EmailMessage(msg.Text);



            DisplayHandler<Person> personHandler = PersonInfo;
            DisplayHandler<Client> clientHandler = personHandler;

            clientHandler(new Client { Name = "Bob" });
            Console.Read();

        }

        //delegate Message MessageBuilder(string text);

        //delegate void EmailReceiver(EmailMessage message);

        //delegate T MessageBuilder<out T>(string text);

        //delegate void MessageReceiver<in T>(T message);

        delegate E MessageConverter<in M, out E>(M message);


        private static void PersonInfo(Person p) => p.Display();
        private static void ClientInfo(Client p) => p.Display();

        delegate void DisplayHandler<in T>(T item);
        class Person
        {
            public string Name { get; set; }
            public virtual void Display() => Console.WriteLine($"Person {Name}");
        }
        class Client : Person
        {
            public override void Display() => Console.WriteLine($"Client {Name}");
        }
    }
}
