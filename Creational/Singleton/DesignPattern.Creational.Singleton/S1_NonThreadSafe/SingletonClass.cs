using System;
using System.Collections.Generic;
using System.Text;


//Example From : http://csharpindepth.com/Articles/General/Singleton.aspx

namespace DesignPattern.Creational.Singleton.S1_NonThreadSafe
{   
    //Bad code!
   public sealed class SingletonClass
    {
        private static  SingletonClass instance = null;

        private SingletonClass()
        {

        }

        public static SingletonClass Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SingletonClass();
                }

                return instance;
            }
        }
    }
}
