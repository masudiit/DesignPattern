using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Builder.B1_BasicStructure
{
    public class ConcreteBuilder2 : Builder
    {
        Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Part A");
        }

        public override void BuildPartB()
        {
            product.Add("Part B");
        }

        public override void BuildPartC()
        {
            product.Add("Part C");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
