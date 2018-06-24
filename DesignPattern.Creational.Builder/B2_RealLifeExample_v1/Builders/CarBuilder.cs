using DesignPattern.Creational.Builder.B2_RealLifeExample_v1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Builder.B2_RealLifeExample_v1.Builders
{
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
   public class CarBuilder : IVehicleBuilder
    {
        public Vehicle Vehicle { get; }

        public CarBuilder()
        {
            Vehicle = new Vehicle("Car");
        }

        public void BuildFrame()
        {
            Vehicle["frame"] = "Car Frame";
        }

        public void BuildEngine()
        {
            Vehicle["engine"] = "2500 cc";
        }

        public void BuildWheels()
        {
            Vehicle["wheels"] = "4";
        }

        public void BuildDoors()
        {
            Vehicle["doors"] = "4";
        }
    }
}
