using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IMessanger<Message> outlook = new EmailMessenger();
            //Message message = outlook.WriteMessage("Hello World");
            //Console.WriteLine(message.Text);

            //IMessanger<EmailMessage> emailClient = new EmailMessenger();
            //IMessanger<Message> messenger = emailClient;
            //Message emailMessage = messenger.WriteMessage("Hi!");
            //Console.WriteLine(emailMessage.Text);

            //IMessanger<EmailMessage> outlook = new SimpleMessenger();
            //outlook.SendMessage(new EmailMessage("Hi!"));

            //IMessanger<Message> telegram = new SimpleMessenger();
            //IMessanger<EmailMessage> emailClient = telegram;
            //emailClient.SendMessage(new EmailMessage("Hello"));

            IMessenger<EmailMessage, Message> messenger = new SimpleMessenger();
            Message message = messenger.WriteMessage("Hello World");
            Console.WriteLine(message.Text);
            messenger.SendMessage(new EmailMessage("Test"));

            IMessenger<EmailMessage, EmailMessage> outlook = new SimpleMessenger();
            EmailMessage emailMessage = outlook.WriteMessage("Message from Outlook");
            outlook.SendMessage(emailMessage);

            IMessenger<Message, Message> telegram = new SimpleMessenger();
            Message simpleMessage = telegram.WriteMessage("Message from Telegram");
            telegram.SendMessage(simpleMessage);
        }
    }
}
