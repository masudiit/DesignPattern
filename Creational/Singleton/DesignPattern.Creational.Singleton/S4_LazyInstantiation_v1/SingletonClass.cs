using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Singleton.S4_LazyInstantiation_v1
{
  
    public sealed class SingletonClass
    {
        private SingletonClass()
        {
        }

        public static SingletonClass Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly SingletonClass instance = new SingletonClass();
        }
    }
}
