using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Builder.B2_RealLifeExample_v1.Interfaces
{
   public interface IVehicleBuilder
    {
        Vehicle Vehicle { get; }

        void BuildDoors();
        void BuildEngine();
        void BuildFrame();
        void BuildWheels();
    }
}
