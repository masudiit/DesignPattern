using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Prototype.P2_BasicExample_v2
{
    public class EmployeeManager
    {
        public Dictionary<string, EmployeePrototype> _employees = new Dictionary<string, EmployeePrototype>();

        public EmployeePrototype this[string idx]
        {
            get { return _employees[idx]; }
            set { _employees.Add(idx, value); }
        }
    }
}
