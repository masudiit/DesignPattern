using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Singleton.S7_GenericSingleton
{
    public class SingletonClass
    {
      
        private SingletonClass()
        {

        }

       
        public static SingletonClass Instance
        {
            get
            {
                return GenericSingletonClass<SingletonClass>.GetInstance();
            }
        }

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.", this.GetType().Name));
        }

    }
}
