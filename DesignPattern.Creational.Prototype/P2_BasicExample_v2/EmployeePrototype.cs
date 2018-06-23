using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Prototype.P2_BasicExample_v2
{
    public abstract class EmployeePrototype
    {
        public abstract EmployeePrototype Clone(bool deepClone);
    }
}
