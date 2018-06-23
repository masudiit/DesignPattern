using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Prototype.P2_BasicExample_v2
{
    [Serializable()]
    public class Employee : EmployeePrototype
    {
        private string _firstName;
        private string _lastName;
        private int _salary;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public Employee(string fName, string lName,int salary)
        {
            this._firstName = fName;
            this._lastName = lName;
            this._salary = salary;
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}", FirstName, LastName, Salary);
        }

        public override EmployeePrototype Clone(bool deepClone)
        {
            switch (deepClone)
            {
                case true:
                    return this.DoDeepClone() as EmployeePrototype;
                case false:
                    return this.MemberwiseClone() as EmployeePrototype;
                default:
                    return this.MemberwiseClone() as EmployeePrototype;
            }
        }
    }
}
