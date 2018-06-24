using DesignPattern.Creational.Builder.B2_RealLifeExample_v1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Builder.B2_RealLifeExample_v1.Builders
{
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    public class MotorCycleBuilder : IVehicleBuilder
    {
        public Vehicle Vehicle { get; }

        public MotorCycleBuilder()
        {
            Vehicle = new Vehicle("MotorCycle");
        }

        public void BuildFrame()
        {
            Vehicle["frame"] = "MotorCycle Frame";
        }

        public void BuildEngine()
        {
            Vehicle["engine"] = "500 cc";
        }

        public void BuildWheels()
        {
            Vehicle["wheels"] = "2";
        }

        public void BuildDoors()
        {
            Vehicle["doors"] = "0";
        }
    }
}
