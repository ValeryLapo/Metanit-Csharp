using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._9
{
    class Message
    {
        public string Text { get; set; }
        public Message(string text) => Text = text;

    }

    class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text) { }
    }

    //class EmailMessenger : IMessanger<EmailMessage>
    //{
    //    public EmailMessage WriteMessage(string text)
    //    {
    //        return new EmailMessage($"Email: {text}");
    //    }
    //}
    //class SimpleMessenger : IMessanger<Message>
    //{
    //    public void SendMessage(Message message)
    //    {
    //        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    //    }
    //}
    class SimpleMessenger : IMessenger<Message, EmailMessage>
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine($"Отправляется сообщение {message.Text}");
        }

        public EmailMessage WriteMessage(string text)
        {
            return new EmailMessage($"Email: {text}");
        }
    }

}
