using DesignPattern.Creational.Prototype.P1_BasicExample_v1;
using DesignPattern.Creational.Prototype.P2_BasicExample_v2;
using DesignPattern.Creational.Prototype.P3_RealLifeExample;
using System;

namespace DesignPattern.Creational.Prototype
{
    class Program
    {

        static void Main(string[] args)
        {

            Ex_P1_BasicExample_v1();
            Ex_P2_BasicExample_v2();
            Ex_P3_RealLife();
            Console.ReadLine();
        }

        private static void Ex_P1_BasicExample_v1()
        {
            Console.WriteLine("Start of P1_BasicExample_v1");

            Developer dev = new Developer();
            dev.Name = "Rahul";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Arif"; //Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            Typist typist = new Typist();
            typist.Name = "Monu";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Sahil";
            typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());
            Console.WriteLine("End of P1_BasicExample_v1");
        }

        private static void Ex_P2_BasicExample_v2()
        {
            Console.WriteLine("Start of P2_BasicExample_v2");
            EmployeeManager employee = new EmployeeManager();

            employee["John"] = new Employee("John", "Smith", 40000);
            employee["Bill"] = new Employee("Bill", "Jones", 50000);

            Console.WriteLine((employee["John"] as Employee).GetDetails());
            Console.WriteLine((employee["Bill"] as Employee).GetDetails());

            //now let's clone 'John Smith'
            Employee employee1 = employee["John"].Clone(false) as Employee;
            employee1.LastName = "Masud";
            employee1.Salary = 60000;
            Console.WriteLine(employee1.GetDetails());

            Console.WriteLine("End of P2_BasicExample_v2");


        }

        private static void Ex_P3_RealLife()
        {
            Console.WriteLine("Start of P3_RealLifeExample");
            Email email = new Email()
            {
                Sender = "noreply@cmb.com",
                Subject = "Subject",
                Content = "Content",
                Footer = "Footer"
            };

            for (int i = 0; i < 3; i++)
            {
                string receiver = string.Format("kehu{0}@qq.com", i);
                string name = string.Format("Name: {0}", i);
                var cloneEmail = email.Clone() as Email;
                cloneEmail.Receiver = receiver;
                cloneEmail.Name = name;

                SendEmail(cloneEmail);
            }

            Console.WriteLine("End of P3_RealLifeExample");
        }


        private static void SendEmail(Email email)
        {
            Console.WriteLine(string.Format("Send Email：   {0}    {1}",email.Name, email.Receiver));
        }
    }
}
