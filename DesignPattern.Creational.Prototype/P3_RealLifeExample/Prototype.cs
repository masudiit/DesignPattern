using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Prototype.P3_RealLifeExample
{
  public abstract class Prototype :ICloneable
    {
        public Prototype() { }
        public abstract object Clone();
    }
}
