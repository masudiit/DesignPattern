using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Singleton.S5_LazyInstantiation_v2
{
    class SingletonClass
    {
          // because of the static constructor, this won't get created until first use
       private static readonly SingletonClass _instance = new SingletonClass();
    
       // Returns the singleton instance using lazy-instantiation
       public static SingletonClass Instance
       {
           get { return _instance; }
       }
    
       // private to prevent direct instantiation
       private SingletonClass()
       {
       }

       // removes BeforeFieldInit on class so static fields not
       // initialized before they are used
       /*
        * Pretty straightforward, but ugly as all heck.  Well, you could also take advantage of the C# standard's
        * BeforeFieldInit and define your class with a static constructor.  It need not have a body, just the presence 
        * of the static constructor will remove the BeforeFieldInit attribute on the class and guarantee that no fields
        * are initialized until the first static field, property, or method is called.
        */
       static SingletonClass()
       {
       }
    }
}
