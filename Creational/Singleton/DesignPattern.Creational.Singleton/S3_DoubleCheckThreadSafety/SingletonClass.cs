using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Singleton.S3_DoubleCheckThreadSafety
{
    public sealed class SingletonClass
    {
        private static volatile SingletonClass instance = null;
        private static readonly object plock = new object();

        private SingletonClass()
        {

        }

        public static SingletonClass Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (plock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonClass();
                        }
                       
                    }
                }

                return instance;
            }

        }



        public void GetInfo()
        {
            Console.WriteLine(string.Format("S3 I am {0}.", this.GetType().Name));
        }
    }
}
