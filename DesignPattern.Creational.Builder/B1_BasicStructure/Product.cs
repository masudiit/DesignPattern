using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Builder.B1_BasicStructure
{
    public class Product
    {
        ArrayList parts = new ArrayList();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            foreach (string part in parts)
                Console.WriteLine(part);
        }
    }
}
