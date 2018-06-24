using DesignPattern.Creational.Builder.B2_RealLifeExample_v1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Builder.B2_RealLifeExample_v1
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    public class Shop
    {
        // Builder uses a complex series of steps
        public void Construct(IVehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
