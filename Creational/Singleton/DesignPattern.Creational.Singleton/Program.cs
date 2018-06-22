using System;
using System.Threading;

namespace DesignPattern.Creational.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex_S1_NonThreadSafe();
            Ex_S2_SimpleThreadSafety();
            Ex_S3_DoubleCheckThreadSafety();
            Ex_S4_LazyInstantiation_v1();
            Ex_S5_LazyInstantiation_v2();
            Ex_S6_ThreadSafeLazyInstantiation_v3();
            Ex_S7_GenericSingleton();
            Ex_S8_RealLifeExample();
            Console.ReadLine();
        }

        private static void Ex_S1_NonThreadSafe()
        {
            Console.WriteLine("Start Non Thread Safe Singleton");

            S1_NonThreadSafe.SingletonClass s1 = DesignPattern.Creational.Singleton.S1_NonThreadSafe.SingletonClass.Instance;
            S1_NonThreadSafe.SingletonClass s2 = DesignPattern.Creational.Singleton.S1_NonThreadSafe.SingletonClass.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Console.WriteLine("End Non Thread Safe Singleton");
        }

        private static void Ex_S2_SimpleThreadSafety()
        {
            Console.WriteLine("Start Simple Thread Safety");

            for (int i = 0; i < 2; i++)
            {
                Thread thread = new Thread(ExecuteInForegroundS2);

                thread.Start();
            }

            Console.WriteLine("End Simple Thread Safety");
        }

        private static void Ex_S3_DoubleCheckThreadSafety()
        {
            Console.WriteLine("Start Double Check Thread Safety");

            for (int i = 0; i < 2; i++)
            {
                Thread thread = new Thread(ExecuteInForegroundS3);

                thread.Start();
            }

            Console.WriteLine("End Double Check Thread Safety");
        }

        private static void Ex_S4_LazyInstantiation_v1()
        {
            Console.WriteLine("Start Lazy Instantiation v1 ");

            S4_LazyInstantiation_v1.SingletonClass s1 = DesignPattern.Creational.Singleton.S4_LazyInstantiation_v1.SingletonClass.Instance;
            S4_LazyInstantiation_v1.SingletonClass s2 = DesignPattern.Creational.Singleton.S4_LazyInstantiation_v1.SingletonClass.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Console.WriteLine("End Lazy Instantiation v1");
        }

        private static void Ex_S5_LazyInstantiation_v2()
        {
            Console.WriteLine("Start Lazy Instantiation v2 ");

            S5_LazyInstantiation_v2.SingletonClass s1 = DesignPattern.Creational.Singleton.S5_LazyInstantiation_v2.SingletonClass.Instance;
            S5_LazyInstantiation_v2.SingletonClass s2 = DesignPattern.Creational.Singleton.S5_LazyInstantiation_v2.SingletonClass.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Console.WriteLine("End Lazy Instantiation v2");
        }

        private static void Ex_S6_ThreadSafeLazyInstantiation_v3()
        {
            Console.WriteLine("Start Lazy Instantiation v3 ");

            S6_ThreadSafeLazyInstantiation_v3.SingletonClass s1 = DesignPattern.Creational.Singleton.S6_ThreadSafeLazyInstantiation_v3.SingletonClass.Instance;
            S6_ThreadSafeLazyInstantiation_v3.SingletonClass s2 = DesignPattern.Creational.Singleton.S6_ThreadSafeLazyInstantiation_v3.SingletonClass.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Console.WriteLine("End Lazy Instantiation v3");
        }

        private static void Ex_S7_GenericSingleton()
        {
            Console.WriteLine("Start Generic Singleton ");

            S7_GenericSingleton.SingletonClass s1 = DesignPattern.Creational.Singleton.S7_GenericSingleton.SingletonClass.Instance;
            S7_GenericSingleton.SingletonClass s2 = DesignPattern.Creational.Singleton.S7_GenericSingleton.SingletonClass.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Console.WriteLine("End Generic Singleton");
        }

        private static void Ex_S8_RealLifeExample()
        {
            Console.WriteLine("Start Real Life Example ");

            S8_RealLifeExample.LoggerClass s1 = DesignPattern.Creational.Singleton.S8_RealLifeExample.LoggerClass.Instance;
            S8_RealLifeExample.LoggerClass s2 = DesignPattern.Creational.Singleton.S8_RealLifeExample.LoggerClass.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
                s1.WriteMessage("This is S1 logger");
                s2.WriteMessage("This is S2 logger");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }



            Console.WriteLine("End Real Life Example ");

        }



        private static void ExecuteInForegroundS2()
        {
            Console.WriteLine("S2 Thread {0}: {1}, Priority {2}",
                              Thread.CurrentThread.ManagedThreadId,
                              Thread.CurrentThread.ThreadState,
                              Thread.CurrentThread.Priority);

            S2_SimpleThreadSafety.SingletonClass s1 = DesignPattern.Creational.Singleton.S2_SimpleThreadSafety.SingletonClass.Instance;
            s1.GetInfo();

        }

        private static void ExecuteInForegroundS3()
        {
            Console.WriteLine("S3 Thread {0}: {1}, Priority {2}",
                              Thread.CurrentThread.ManagedThreadId,
                              Thread.CurrentThread.ThreadState,
                              Thread.CurrentThread.Priority);

            S3_DoubleCheckThreadSafety.SingletonClass s1 = DesignPattern.Creational.Singleton.S3_DoubleCheckThreadSafety.SingletonClass.Instance;
            s1.GetInfo();

        }

    }
}
