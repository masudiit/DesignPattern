using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Builder.B1_BasicStructure
{
    public class Director
    {
        Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}
