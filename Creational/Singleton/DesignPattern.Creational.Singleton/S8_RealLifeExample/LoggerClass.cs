using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Singleton.S8_RealLifeExample
{
   
   public sealed class LoggerClass
    {
        private static readonly Lazy<LoggerClass> lazy = new Lazy<LoggerClass>(() => new LoggerClass());

        public static LoggerClass Instance { get { return lazy.Value; } }

        private LoggerClass()
        {
        }

        // Pretend we're writing the message to a file here.
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

}
