using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Builder.B1_BasicStructure
{
    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public abstract Product GetResult();
    }
}
