using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Singleton.S7_GenericSingleton
{
    public class GenericSingletonClass<T> where T : class
    {
        private static T instance;

        private static readonly object Locker = new object();

        public static T GetInstance()
        {
            if (instance == null)
            {
                lock (Locker)
                {
                    if (instance == null)
                    {
                        instance = Activator.CreateInstance(typeof(T), true) as T;
                    }
                }
            }
            return instance;
        }

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.", this.GetType().Name));
        }
    }
}
