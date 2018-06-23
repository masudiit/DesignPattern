using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Prototype.P3_RealLifeExample
{
    public class Email : Prototype
    {
        public Email() : base() { }

        public Email(string receiver, string sender, string subject, string name, string content, string footer)
        {
            Receiver = receiver;
            Sender = sender;
            Subject = subject;
            Name = name;
            Content = content;
            Footer = footer;
        }

        public string Receiver { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Footer { get; set; }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
