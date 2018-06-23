using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Prototype.P1_BasicExample_v1
{
    /// <summary>
    /// The 'Prototype' interface
    /// </summary>
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }
}
