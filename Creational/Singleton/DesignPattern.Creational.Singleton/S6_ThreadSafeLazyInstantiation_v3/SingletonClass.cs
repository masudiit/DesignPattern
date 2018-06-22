using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Singleton.S6_ThreadSafeLazyInstantiation_v3
{
    public sealed class SingletonClass
    {
        private static readonly Lazy<SingletonClass> lazy = new Lazy<SingletonClass>(() => new SingletonClass());

        public static SingletonClass Instance { get { return lazy.Value; } }

        private SingletonClass()
        {
        }
    }
}
