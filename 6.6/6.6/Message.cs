using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6
{
    class Message
    {
        public string Text { get; }
        public Message(string text) => Text = text;
        public virtual void Print() => Console.WriteLine($"Message: {Text}");
    }
    class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text) { }
        public override void Print() => Console.WriteLine($"Email: {Text}");
    }
    class SmsMessage : Message
    {
        public SmsMessage(string text) : base(text) { }
        public override void Print() => Console.WriteLine($"Sms: {Text}");
    }
}
